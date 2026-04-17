using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace ArchivoDeTokens
{
    public partial class Form1 : Form
    {
        private Dictionary<int, Dictionary<string, string>> matrizTransicion = new Dictionary<int, Dictionary<string, string>>();

        public Form1()
        {
            InitializeComponent();
            CargarMatrizEnMemoria();
        }

        private void CargarMatrizEnMemoria()
        {
            using (SqlConnection con = ConexionBD.ObtenerConexion())
            {
                string query = "SELECT * FROM matriz";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int estadoFila = Convert.ToInt32(reader["ESTADO"]);

                            var filaActual = new Dictionary<string, string>();

                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                string nombreColumna = reader.GetName(i);

                                if (nombreColumna != "ESTADO")
                                {
                                    string valorCelda = reader[i].ToString();
                                    filaActual[nombreColumna] = valorCelda;
                                }
                            }

                            matrizTransicion[estadoFila] = filaActual;
                        }
                    }
                }
            }
        }

        private void btnLexico_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(rtxtCodigo.Text))
                    throw new Exception("No hay código");

                string[] lineasCodigo = rtxtCodigo.Lines;
                int estadoActual = 1;
                char car;
                string strCar = "";
                string celdaActual = "";
                List<string> filasDeTokens = new List<string>();
                string tokens = "";
                bool cadAbierta = false;
                for (int numLinea = 0; numLinea < lineasCodigo.Length; numLinea++)
                {
                    string lineaCodActual = lineasCodigo[numLinea];
                    string tokensDeLinea = "";
                    string lineaLista = lineaCodActual.TrimEnd();
                    if (!lineaLista.EndsWith("~"))
                    {
                        //ERROR por falta de simbolo ~ al final de la linea
                    }
                    lineaCodActual = lineaLista+" ";
                    cadAbierta = false;

                    for (int numCaracter = 0; numCaracter < lineaCodActual.Length; numCaracter++)
                    {
                        car = lineaCodActual[numCaracter];
                        if (estadoActual == 1 && (car == ' ' || car == '\t' || car == '\r' || car == '\n'))
                        {
                            continue; 
                        }
                        if(car == '"')
                        {
                            cadAbierta = !cadAbierta;
                        }
                        
                        if((car == ' ' || car == '\t') && cadAbierta)
                        {
                            numCaracter++;
                            car = lineaCodActual[numCaracter];
                        }

                        if ((car == ' ' || car == '\t') && !cadAbierta)
                        {
                            strCar = "FDC";
                        }
                        else
                        {
                            if (char.IsLetter(car))
                            {

                                strCar = car.ToString();
                                if (char.IsLower(car))
                                {
                                    strCar = car + "1";
                                }
                            }else if (char.IsDigit(car))
                            {
                                strCar = "_" + car;
                            }
                            else
                            {
                                strCar = "c" + (int)car;
                            }
                        }
                        if (!matrizTransicion[estadoActual].ContainsKey(strCar))
                        {
                            throw new Exception("Símbolo fuera de la matriz de transición");
                        }
                        celdaActual = matrizTransicion[estadoActual][strCar];
                        if(celdaActual != "ERROR" && celdaActual != "ACEPTA")
                        {
                            if (matrizTransicion[int.Parse(celdaActual)]["FDC"] == "ERROR")
                            {
                                tokensDeLinea += "[ERROR:" + matrizTransicion[int.Parse(celdaActual)]["CAT"] + "] ";
                                tokens += "[ERROR:" + matrizTransicion[int.Parse(celdaActual)]["CAT"] + "] ";

                                estadoActual = 1;

                            }
                            else if (matrizTransicion[int.Parse(celdaActual)]["FDC"] == "ACEPTA")
                            {
                                tokensDeLinea += matrizTransicion[int.Parse(celdaActual)]["CAT"] + " ";
                                tokens += matrizTransicion[int.Parse(celdaActual)]["CAT"]+" ";
                                estadoActual = 1;

                                if (strCar != "FDC")
                                {
                                    numCaracter--;
                                }
                            }
                            else
                            {
                                estadoActual = int.Parse(celdaActual);
                            }
                        }
                        
                    }
                    tokens.TrimEnd(' ');
                    tokens += "\n";
                    filasDeTokens.Add(tokensDeLinea.TrimEnd());
                }
                rtxtTokens.Lines = filasDeTokens.ToArray();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
