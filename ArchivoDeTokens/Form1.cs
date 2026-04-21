using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArchivoDeTokens
{
    public partial class Form1 : Form
    {
        private List<ErrorLexico> listaErrores = new List<ErrorLexico>();
        private List<Simbolo> listaSimbolos = new List<Simbolo>();
        private Dictionary<int, Dictionary<string, string>> matrizTransicion = new Dictionary<int, Dictionary<string, string>>();
        private int contadorSimbolos = 1;
        private int contadorLinea = 2;
        private int contE = 0;

        public Form1()
        {
            InitializeComponent();
            CargarMatrizEnMemoria();
            lblEquipo.Text = "Equipo\nHiram García Guerra. #23100161\nJorge Arturo Mata Camacho. #C21100514\nReynaldo Daniel Reyes Parra. #23100202";
            rtxTokens.Text = "1\n";
            rtxLineasCodigo.Text = "1\n";
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
            ActualizarErrores();
            ActualizarSimbolos();
            try
            {
                listaErrores.Clear();
                listaSimbolos.Clear();
                if (string.IsNullOrEmpty(rtxtCodigo.Text))
                    throw new Exception("No hay código");

                string[] lineasCodigo = rtxtCodigo.Lines;
                contadorSimbolos = 1;
                int estadoActual = 1;
                char car;
                string strCar = "";
                string celdaActual = "";
                List<string> filasDeTokens = new List<string>();
                string tokens = "";
                bool cadAbierta = false;
                bool comentario = false, tokenFDLSeguidoCar = false;
                int j = 0;
                contE = 0;
                string val = "";
                string  valCadena = "";
                for (int numLinea = 0; numLinea < lineasCodigo.Length; numLinea++)
                {
                    string lineaCodActual = lineasCodigo[numLinea];
                    string tokensDeLinea = "";
                    string lineaLista = lineaCodActual.TrimEnd();
                    string tokenFDL = "";
                    if (!lineaLista.EndsWith("~"))
                    {
                        tokenFDL = "ERRFDL ";
                        contE++;
                        RegistrarError(numLinea + 1, "Falta el símbolo delimitador '~' al final");
                    }
                    else
                    {
                        tokenFDL = "FDL ";
                    }
                    lineaCodActual = lineaLista+" ";
                    cadAbierta = false;
                    comentario = false;

                    for (int numCaracter = 0; numCaracter < lineaCodActual.Length; numCaracter++)
                    {
                        if (lineaCodActual[numCaracter] == '~' && numCaracter < lineaCodActual.Length - 2)
                        {
                            if (numCaracter > 0 && lineaCodActual[numCaracter - 1] != ' ')
                            {
                                tokenFDLSeguidoCar = true;

                            }
                            else
                            {
                                tokenFDLSeguidoCar = false;
                                tokensDeLinea += "FDL ";
                            }
                            numCaracter++;
                        }
                        else if (lineaCodActual[numCaracter] == '~' && lineaCodActual.Length-2 == numCaracter)
                        {
                            tokenFDL = "FDL ";
                            numCaracter++;
                        }
                        car = lineaCodActual[numCaracter];
                        if (estadoActual == 1 && (car == ' ' || car == '\t' || car == '\r' || car == '\n'))
                        {
                            continue; 
                        }
                        if(car == '"' && !comentario)
                        {
                            cadAbierta = !cadAbierta;
                        }else if(car == '#')
                        {
                            comentario = true;
                        }
                        if (!char.IsWhiteSpace(car) || cadAbierta)
                        {
                            valCadena += car;
                        }


                        if (numCaracter == lineaCodActual.Length - 1)
                        {
                            strCar = "FDC";
                        }
                        else if ((car == ' ' || car == '\t') && !cadAbierta && !comentario)
                        {
                            strCar = "FDC";
                        }
                        else if ((car == ' ' || car == '\t') && (cadAbierta || comentario))
                        {
                            
                            continue;
                        }
                        else
                        {
                            if (char.IsLetter(car))
                            {
                                strCar = car.ToString();
                                if (char.IsLower(car)) { strCar = car + "1"; }
                            }
                            else if (char.IsDigit(car))
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
                                string token = matrizTransicion[int.Parse(celdaActual)]["CAT"];
                                tokensDeLinea += "[ERROR:" + token + "] " ;
                                tokens += "[ERROR:" + token + "] ";
                                RegistrarError(numLinea + 1, token);
                                contE++;
                                valCadena = "";
                                estadoActual = 1;
                                //contadorSimbolos--;

                            }
                            else if (matrizTransicion[int.Parse(celdaActual)]["FDC"] == "ACEPTA")
                            {
                                if (matrizTransicion[int.Parse(celdaActual)]["CAT"] == "IDVAL")
                                {
                                    RegistrarSimbolo(contadorSimbolos++, valCadena);
                                    Simbolo simboloEncontrado = listaSimbolos.FirstOrDefault(s => s.Nombre == valCadena);
                                    
                                    if (simboloEncontrado != null)
                                    {
                                        string idPersonalizado = "IDENT" + simboloEncontrado.Num;
                                        tokensDeLinea += idPersonalizado + " ";
                                        tokens += idPersonalizado + " ";
                                    }
                                }
                                else
                                {
                                    tokensDeLinea += matrizTransicion[int.Parse(celdaActual)]["CAT"] + " ";
                                    tokens += matrizTransicion[int.Parse(celdaActual)]["CAT"] + " ";
                                }
                                estadoActual = 1;
                                val = matrizTransicion[int.Parse(celdaActual)]["CAT"] + " ";
                                valCadena = "";

                                if (strCar != "FDC")
                                {
                                    numCaracter--;
                                }
                            }
                            else
                            {
                                estadoActual = int.Parse(celdaActual);
                            }
                            if (tokenFDLSeguidoCar)
                            {
                                tokensDeLinea += "FDL ";
                                tokenFDLSeguidoCar = false;
                            }
                        }
                        
                    }
                    if (cadAbierta)
                    {
                        tokensDeLinea += "[ERROR:ECADINV] ";
                        tokens += "[ERROR:ECADINV] ";
                        RegistrarError(numLinea + 1, "ECADINV");
                        contE++;
                        cadAbierta = false;
                        estadoActual = 1;
                        valCadena = "";
                    }
                    tokens.TrimEnd(' ');
                    tokens += "\n";
                    tokensDeLinea += tokenFDL;
                    comentario = false;
                    filasDeTokens.Add(tokensDeLinea.TrimEnd());
                }
                rtxtTokens.Lines = filasDeTokens.ToArray();
                ResaltarErrores(rtxtTokens);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ActualizarErrores();
            ActualizarSimbolos();
            lblCE.Text = "Total de errores: " + contE;
        }

        private void RegistrarError(int linea, string mensaje)
        {
            listaErrores.Add(new ErrorLexico
            {
                Linea = linea,
                Descripcion = mensaje
            });
            ActualizarErrores();
        }

        private void RegistrarSimbolo(int num, string nombre)
        {
            bool flag = true;
            foreach (Simbolo simbolo in listaSimbolos)
            {
                if (simbolo.Nombre == nombre)
                {
                    flag = false;
                    contadorSimbolos--;
                }
            }
            if(flag)
            {
                listaSimbolos.Add(new Simbolo
                {
                    Num = num,
                    Nombre = nombre
                });
                ActualizarSimbolos();
            }
            
        }

        private void ActualizarErrores()
        {
            DgvErrores.Rows.Clear();
            foreach (ErrorLexico error in listaErrores)
            {
                switch (error.Descripcion)
                {
                    case "PRINV":
                        error.Descripcion = "Palabra Reservada INVALIDA";
                        break;
                    case "CNINV":
                        error.Descripcion = "Constante Numerica INVALIDA";

                        break;
                    case "VAINV":
                        error.Descripcion = "Valor INVALIDO";

                        break;
                    case "IDINV":
                        error.Descripcion = "Identificador INVALIDO";

                        break;
                    case "EOPARINV":
                        error.Descripcion = "Error aritmetico";

                        break;
                    case "EOPRELINV":
                        error.Descripcion = "Error operador relacion";

                        break;
                    case "ECADINV":
                        error.Descripcion = "Error cadena INVALIDA";

                        break;
                    case "ECARINV":
                        error.Descripcion = "Error caracter INVALIDO";

                        break;
                }
               DgvErrores.Rows.Add(error.Linea, error.Descripcion);
            }
        }
        private void ActualizarSimbolos()
        {
            DgvSimbolos.Rows.Clear();
            foreach (Simbolo simbolo in listaSimbolos)
            {
                DgvSimbolos.Rows.Add(simbolo.Num, simbolo.Nombre);
            }

        }

        private void rtxtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Tab)
            {
                e.SuppressKeyPress = true;
                rtxtCodigo.SelectedText = "     ";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ActualizarNumerosDeLinea()
        {
            
        }

        private void btnCargarProg_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Archivos RTF (*.rtf)|*.rtf|Todos los archivos (*.*)|*.*";
                openFileDialog.Title = "Selecciona un archivo para cargar";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        rtxtCodigo.Enabled = false;
                        string rutaArchivo = openFileDialog.FileName;

                        // Comprobamos la extensión para saber cómo cargarlo
                        if (Path.GetExtension(rutaArchivo).ToLower() == ".rtf")
                        {
                            // Si es un archivo con formato RTF, usamos el método nativo LoadFile
                            rtxtCodigo.LoadFile(rutaArchivo, RichTextBoxStreamType.RichText);
                        }
                        else
                        {
                            // Si es texto plano (.txt, .csv, etc.), leemos todo el texto y lo asignamos
                            rtxtCodigo.Text = File.ReadAllText(rutaArchivo);

                            // Alternativamente, puedes usar: 
                            // richTextBox1.LoadFile(rutaArchivo, RichTextBoxStreamType.PlainText);
                        }
                        ActualizarNumerosDeLinea();
                    }
                    catch (Exception ex)
                    {
                        // Mostramos un mensaje si ocurre algún error (ej. archivo bloqueado)
                        rtxtCodigo.Enabled = true;
                        MessageBox.Show("Ocurrió un error al cargar el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnGuardarProg_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                // Configuramos los filtros (por defecto seleccionará .txt)
                saveFileDialog.FileName = "Tokens.txt";
                saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Archivos RTF (*.rtf)|*.rtf|Todos los archivos (*.*)|*.*";
                saveFileDialog.Title = "Guardar contenido como...";
                saveFileDialog.DefaultExt = "txt"; // Extensión por defecto si el usuario no escribe una

                // Si el usuario elige dónde guardar y hace clic en "Guardar"
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string rutaArchivo = saveFileDialog.FileName;

                        // Verificamos si el usuario decidió guardar como RTF (con formato)
                        if (Path.GetExtension(rutaArchivo).ToLower() == ".rtf")
                        {
                            // Guarda conservando colores, negritas, etc.
                            rtxtCodigo.SaveFile(rutaArchivo, RichTextBoxStreamType.RichText);
                        }
                        else
                        {
                            // GUARDA COMO TEXTO PLANO
                            // La propiedad .Text contiene el texto tal cual, con sus saltos de línea nativos.
                            File.WriteAllText(rutaArchivo, rtxtCodigo.Text);

                            // Nota: Otra forma igualmente válida de hacerlo es:
                            // richTextBox1.SaveFile(rutaArchivo, RichTextBoxStreamType.PlainText);
                        }

                        // Opcional: Mostrar un mensaje de éxito
                        MessageBox.Show("El archivo se guardó correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        // Manejo de errores por si no hay permisos de escritura en esa carpeta, etc.
                        MessageBox.Show("Ocurrió un error al guardar el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnGuardarArchTokens_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                // Configuramos los filtros (por defecto seleccionará .txt)
                saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Archivos RTF (*.rtf)|*.rtf|Todos los archivos (*.*)|*.*";
                saveFileDialog.Title = "Guardar contenido como...";
                saveFileDialog.DefaultExt = "txt"; // Extensión por defecto si el usuario no escribe una

                // Si el usuario elige dónde guardar y hace clic en "Guardar"
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string rutaArchivo = saveFileDialog.FileName;

                        // Verificamos si el usuario decidió guardar como RTF (con formato)
                        if (Path.GetExtension(rutaArchivo).ToLower() == ".rtf")
                        {
                            // Guarda conservando colores, negritas, etc.
                            rtxtTokens.SaveFile(rutaArchivo, RichTextBoxStreamType.RichText);
                        }
                        else
                        {
                            // GUARDA COMO TEXTO PLANO
                            // La propiedad .Text contiene el texto tal cual, con sus saltos de línea nativos.
                            File.WriteAllText(rutaArchivo, rtxtTokens.Text);

                            // Nota: Otra forma igualmente válida de hacerlo es:
                            // richTextBox1.SaveFile(rutaArchivo, RichTextBoxStreamType.PlainText);
                        }

                        // Opcional: Mostrar un mensaje de éxito
                        MessageBox.Show("El archivo se guardó correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        // Manejo de errores por si no hay permisos de escritura en esa carpeta, etc.
                        MessageBox.Show("Ocurrió un error al guardar el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnEditarProg_Click(object sender, EventArgs e)
        {
            rtxtCodigo.Enabled = true;
        }
        private void ResaltarErrores(RichTextBox rtxt)
        {
            string[] palabrasClave = { "[ERROR:VAINV]","[ERROR:IDINV]","[ERROR:CNINV]","[ERROR:PRINV]","[ERROR:EOPARINV]","[ERROR:EOPRELINV]","[ERROR:ECADINV]","[ERROR:ECARINV]","ERRFDL"};

            foreach (string palabra in palabrasClave)
            {
                int startindex = 0;
                while (startindex < rtxt.TextLength)
                {
                    // Busca la palabra a partir del último índice encontrado
                    int wordinterv = rtxt.Find(palabra, startindex, RichTextBoxFinds.None);

                    if (wordinterv != -1)
                    {
                        rtxt.Select(wordinterv, palabra.Length);
                        rtxt.SelectionColor = Color.Red; // Cambia a rojo
                        startindex = wordinterv + palabra.Length;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            // Quitar la selección al terminar para que no quede texto marcado
            rtxt.SelectionStart = rtxt.Text.Length;
            rtxt.SelectionLength = 0;
            rtxt.SelectionColor = Color.Black;
        }

        private void rtxtCodigo_TextChanged(object sender, EventArgs e)
        {
            Point pt = new Point(0, 0);
            int firstIndex = rtxtCodigo.GetCharIndexFromPosition(pt);
            int firstLine = rtxtCodigo.GetLineFromCharIndex(firstIndex);

            pt.X = rtxtCodigo.ClientRectangle.Width;
            pt.Y = rtxtCodigo.ClientRectangle.Height;
            int lastIndex = rtxtCodigo.GetCharIndexFromPosition(pt);
            int lastLine = rtxtCodigo.GetLineFromCharIndex(lastIndex);

            rtxLineasCodigo.SelectionAlignment = HorizontalAlignment.Center;
            rtxLineasCodigo.Text = "";
            rtxTokens.SelectionAlignment = HorizontalAlignment.Center;
            rtxTokens.Text = "";

            for (int i = firstLine; i< lastLine + 1; i++)
            {
                rtxLineasCodigo.Text += (i + 1) + "\n";
                rtxTokens.Text += (i + 1) + "\n";
            }
        }

        private void rtxtCodigo_VScroll(object sender, EventArgs e)
        {
            Point pt = new Point(0, 0);
            int firstIndex = rtxtCodigo.GetCharIndexFromPosition(pt);
            int firstLine = rtxtCodigo.GetLineFromCharIndex(firstIndex);

            pt.X = rtxtCodigo.ClientRectangle.Width;
            pt.Y = rtxtCodigo.ClientRectangle.Height;
            int lastIndex = rtxtCodigo.GetCharIndexFromPosition(pt);
            int lastLine = rtxtCodigo.GetLineFromCharIndex(lastIndex);

            rtxLineasCodigo.SelectionAlignment = HorizontalAlignment.Center;
            rtxLineasCodigo.Text = "";
            rtxTokens.SelectionAlignment = HorizontalAlignment.Center;
            rtxTokens.Text = "";

            for (int i = firstLine; i < lastLine + 1; i++)
            {
                rtxLineasCodigo.Text += (i + 1) + "\n";
                rtxTokens.Text += (i + 1) + "\n";
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void tabControl1_KeyDown(object sender, KeyEventArgs e)
        {
        }
    }
}
