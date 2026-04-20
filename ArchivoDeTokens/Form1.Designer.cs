namespace ArchivoDeTokens
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLexico = new System.Windows.Forms.Button();
            this.rtxtCodigo = new System.Windows.Forms.RichTextBox();
            this.rtxtTokens = new System.Windows.Forms.RichTextBox();
            this.DgvErrores = new System.Windows.Forms.DataGridView();
            this.linea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.error = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvSimbolos = new System.Windows.Forms.DataGridView();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipodedato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nLinea = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvErrores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSimbolos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLexico
            // 
            this.btnLexico.Location = new System.Drawing.Point(421, 151);
            this.btnLexico.Margin = new System.Windows.Forms.Padding(2);
            this.btnLexico.Name = "btnLexico";
            this.btnLexico.Size = new System.Drawing.Size(78, 33);
            this.btnLexico.TabIndex = 1;
            this.btnLexico.Text = "button1";
            this.btnLexico.UseVisualStyleBackColor = true;
            this.btnLexico.Click += new System.EventHandler(this.btnLexico_Click);
            // 
            // rtxtCodigo
            // 
            this.rtxtCodigo.Location = new System.Drawing.Point(103, 35);
            this.rtxtCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.rtxtCodigo.Name = "rtxtCodigo";
            this.rtxtCodigo.Size = new System.Drawing.Size(290, 256);
            this.rtxtCodigo.TabIndex = 3;
            this.rtxtCodigo.Text = "";
            this.rtxtCodigo.WordWrap = false;
            this.rtxtCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtxtCodigo_KeyDown);
            // 
            // rtxtTokens
            // 
            this.rtxtTokens.Location = new System.Drawing.Point(503, 35);
            this.rtxtTokens.Margin = new System.Windows.Forms.Padding(2);
            this.rtxtTokens.Name = "rtxtTokens";
            this.rtxtTokens.Size = new System.Drawing.Size(450, 256);
            this.rtxtTokens.TabIndex = 4;
            this.rtxtTokens.Text = "";
            this.rtxtTokens.WordWrap = false;
            // 
            // DgvErrores
            // 
            this.DgvErrores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvErrores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.linea,
            this.error});
            this.DgvErrores.Enabled = false;
            this.DgvErrores.Location = new System.Drawing.Point(103, 323);
            this.DgvErrores.Name = "DgvErrores";
            this.DgvErrores.Size = new System.Drawing.Size(290, 150);
            this.DgvErrores.TabIndex = 5;
            // 
            // linea
            // 
            this.linea.HeaderText = "Linea";
            this.linea.Name = "linea";
            this.linea.ReadOnly = true;
            // 
            // error
            // 
            this.error.HeaderText = "Error";
            this.error.Name = "error";
            this.error.ReadOnly = true;
            // 
            // DgvSimbolos
            // 
            this.DgvSimbolos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSimbolos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numero,
            this.nombre,
            this.tipodedato,
            this.valor});
            this.DgvSimbolos.Enabled = false;
            this.DgvSimbolos.Location = new System.Drawing.Point(503, 323);
            this.DgvSimbolos.Name = "DgvSimbolos";
            this.DgvSimbolos.Size = new System.Drawing.Size(450, 150);
            this.DgvSimbolos.TabIndex = 6;
            // 
            // numero
            // 
            this.numero.HeaderText = "Numero";
            this.numero.Name = "numero";
            this.numero.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // tipodedato
            // 
            this.tipodedato.HeaderText = "Tipo De Dato";
            this.tipodedato.Name = "tipodedato";
            this.tipodedato.ReadOnly = true;
            // 
            // valor
            // 
            this.valor.HeaderText = "Valor";
            this.valor.Name = "valor";
            this.valor.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.nLinea);
            this.panel1.Location = new System.Drawing.Point(31, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(72, 256);
            this.panel1.TabIndex = 7;
            // 
            // nLinea
            // 
            this.nLinea.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nLinea.ForeColor = System.Drawing.Color.Maroon;
            this.nLinea.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.nLinea.Location = new System.Drawing.Point(3, 3);
            this.nLinea.Name = "nLinea";
            this.nLinea.Size = new System.Drawing.Size(66, 13);
            this.nLinea.TabIndex = 0;
            this.nLinea.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 505);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DgvSimbolos);
            this.Controls.Add(this.DgvErrores);
            this.Controls.Add(this.rtxtTokens);
            this.Controls.Add(this.rtxtCodigo);
            this.Controls.Add(this.btnLexico);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DgvErrores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSimbolos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLexico;
        private System.Windows.Forms.RichTextBox rtxtCodigo;
        private System.Windows.Forms.RichTextBox rtxtTokens;
        private System.Windows.Forms.DataGridView DgvErrores;
        private System.Windows.Forms.DataGridViewTextBoxColumn linea;
        private System.Windows.Forms.DataGridViewTextBoxColumn error;
        private System.Windows.Forms.DataGridView DgvSimbolos;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipodedato;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label nLinea;
    }
}

