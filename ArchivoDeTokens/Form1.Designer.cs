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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnLexico = new System.Windows.Forms.Button();
            this.rtxtCodigo = new System.Windows.Forms.RichTextBox();
            this.rtxtTokens = new System.Windows.Forms.RichTextBox();
            this.DgvErrores = new System.Windows.Forms.DataGridView();
            this.DgvSimbolos = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nLinea = new System.Windows.Forms.Label();
            this.btnCargarProg = new System.Windows.Forms.Button();
            this.btnEditarProg = new System.Windows.Forms.Button();
            this.btnGuardarProg = new System.Windows.Forms.Button();
            this.btnGuardarArchTokens = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblEquipo = new System.Windows.Forms.Label();
            this.lblCE = new System.Windows.Forms.Label();
            this.linea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.error = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipodedato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvErrores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSimbolos)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLexico
            // 
            this.btnLexico.Location = new System.Drawing.Point(547, 46);
            this.btnLexico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLexico.Name = "btnLexico";
            this.btnLexico.Size = new System.Drawing.Size(104, 41);
            this.btnLexico.TabIndex = 1;
            this.btnLexico.Text = "Analizador Léxico";
            this.btnLexico.UseVisualStyleBackColor = true;
            this.btnLexico.Click += new System.EventHandler(this.btnLexico_Click);
            // 
            // rtxtCodigo
            // 
            this.rtxtCodigo.Location = new System.Drawing.Point(137, 43);
            this.rtxtCodigo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtxtCodigo.Name = "rtxtCodigo";
            this.rtxtCodigo.Size = new System.Drawing.Size(385, 314);
            this.rtxtCodigo.TabIndex = 3;
            this.rtxtCodigo.Text = "";
            this.rtxtCodigo.WordWrap = false;
            this.rtxtCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtxtCodigo_KeyDown);
            // 
            // rtxtTokens
            // 
            this.rtxtTokens.Location = new System.Drawing.Point(671, 43);
            this.rtxtTokens.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtxtTokens.Name = "rtxtTokens";
            this.rtxtTokens.Size = new System.Drawing.Size(599, 314);
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
            this.DgvErrores.Location = new System.Drawing.Point(41, 398);
            this.DgvErrores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DgvErrores.Name = "DgvErrores";
            this.DgvErrores.RowHeadersWidth = 51;
            this.DgvErrores.Size = new System.Drawing.Size(481, 185);
            this.DgvErrores.TabIndex = 5;
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
            this.DgvSimbolos.Location = new System.Drawing.Point(671, 398);
            this.DgvSimbolos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DgvSimbolos.Name = "DgvSimbolos";
            this.DgvSimbolos.RowHeadersWidth = 51;
            this.DgvSimbolos.Size = new System.Drawing.Size(600, 185);
            this.DgvSimbolos.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.nLinea);
            this.panel1.Location = new System.Drawing.Point(41, 43);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(96, 315);
            this.panel1.TabIndex = 7;
            // 
            // nLinea
            // 
            this.nLinea.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nLinea.ForeColor = System.Drawing.Color.Maroon;
            this.nLinea.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.nLinea.Location = new System.Drawing.Point(4, 4);
            this.nLinea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nLinea.Name = "nLinea";
            this.nLinea.Size = new System.Drawing.Size(88, 16);
            this.nLinea.TabIndex = 0;
            this.nLinea.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCargarProg
            // 
            this.btnCargarProg.Location = new System.Drawing.Point(548, 107);
            this.btnCargarProg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCargarProg.Name = "btnCargarProg";
            this.btnCargarProg.Size = new System.Drawing.Size(104, 41);
            this.btnCargarProg.TabIndex = 8;
            this.btnCargarProg.Text = "Cargar Programa";
            this.btnCargarProg.UseVisualStyleBackColor = true;
            this.btnCargarProg.Click += new System.EventHandler(this.btnCargarProg_Click);
            // 
            // btnEditarProg
            // 
            this.btnEditarProg.Location = new System.Drawing.Point(548, 176);
            this.btnEditarProg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditarProg.Name = "btnEditarProg";
            this.btnEditarProg.Size = new System.Drawing.Size(104, 41);
            this.btnEditarProg.TabIndex = 9;
            this.btnEditarProg.Text = "Editar Programa";
            this.btnEditarProg.UseVisualStyleBackColor = true;
            this.btnEditarProg.Click += new System.EventHandler(this.btnEditarProg_Click);
            // 
            // btnGuardarProg
            // 
            this.btnGuardarProg.Location = new System.Drawing.Point(548, 231);
            this.btnGuardarProg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardarProg.Name = "btnGuardarProg";
            this.btnGuardarProg.Size = new System.Drawing.Size(104, 41);
            this.btnGuardarProg.TabIndex = 10;
            this.btnGuardarProg.Text = "Guardar Programa";
            this.btnGuardarProg.UseVisualStyleBackColor = true;
            this.btnGuardarProg.Click += new System.EventHandler(this.btnGuardarProg_Click);
            // 
            // btnGuardarArchTokens
            // 
            this.btnGuardarArchTokens.Location = new System.Drawing.Point(547, 289);
            this.btnGuardarArchTokens.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardarArchTokens.Name = "btnGuardarArchTokens";
            this.btnGuardarArchTokens.Size = new System.Drawing.Size(104, 68);
            this.btnGuardarArchTokens.TabIndex = 11;
            this.btnGuardarArchTokens.Text = "Guardar Archivo de Tokens";
            this.btnGuardarArchTokens.UseVisualStyleBackColor = true;
            this.btnGuardarArchTokens.Click += new System.EventHandler(this.btnGuardarArchTokens_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(671, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Archivo de Tokens";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 378);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tabla de Errores";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(675, 375);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Tabla de Símbolos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(1317, 43);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // lblEquipo
            // 
            this.lblEquipo.AutoSize = true;
            this.lblEquipo.Location = new System.Drawing.Point(1317, 255);
            this.lblEquipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEquipo.Name = "lblEquipo";
            this.lblEquipo.Size = new System.Drawing.Size(37, 16);
            this.lblEquipo.TabIndex = 17;
            this.lblEquipo.Text = "label";
            // 
            // lblCE
            // 
            this.lblCE.AutoSize = true;
            this.lblCE.Location = new System.Drawing.Point(41, 603);
            this.lblCE.Name = "lblCE";
            this.lblCE.Size = new System.Drawing.Size(0, 16);
            this.lblCE.TabIndex = 18;
            // 
            // linea
            // 
            this.linea.HeaderText = "Línea";
            this.linea.MinimumWidth = 6;
            this.linea.Name = "linea";
            this.linea.ReadOnly = true;
            this.linea.Width = 125;
            // 
            // error
            // 
            this.error.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.error.HeaderText = "Error";
            this.error.MinimumWidth = 6;
            this.error.Name = "error";
            this.error.ReadOnly = true;
            this.error.Width = 65;
            // 
            // numero
            // 
            this.numero.HeaderText = "Número";
            this.numero.MinimumWidth = 6;
            this.numero.Name = "numero";
            this.numero.ReadOnly = true;
            this.numero.Width = 125;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 125;
            // 
            // tipodedato
            // 
            this.tipodedato.HeaderText = "Tipo De Dato";
            this.tipodedato.MinimumWidth = 6;
            this.tipodedato.Name = "tipodedato";
            this.tipodedato.ReadOnly = true;
            this.tipodedato.Width = 125;
            // 
            // valor
            // 
            this.valor.HeaderText = "Valor";
            this.valor.MinimumWidth = 6;
            this.valor.Name = "valor";
            this.valor.ReadOnly = true;
            this.valor.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1641, 648);
            this.Controls.Add(this.lblCE);
            this.Controls.Add(this.lblEquipo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuardarArchTokens);
            this.Controls.Add(this.btnGuardarProg);
            this.Controls.Add(this.btnEditarProg);
            this.Controls.Add(this.btnCargarProg);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DgvSimbolos);
            this.Controls.Add(this.DgvErrores);
            this.Controls.Add(this.rtxtTokens);
            this.Controls.Add(this.rtxtCodigo);
            this.Controls.Add(this.btnLexico);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Analizador Léxico";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvErrores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSimbolos)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLexico;
        private System.Windows.Forms.RichTextBox rtxtCodigo;
        private System.Windows.Forms.RichTextBox rtxtTokens;
        private System.Windows.Forms.DataGridView DgvErrores;
        private System.Windows.Forms.DataGridView DgvSimbolos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label nLinea;
        private System.Windows.Forms.Button btnCargarProg;
        private System.Windows.Forms.Button btnEditarProg;
        private System.Windows.Forms.Button btnGuardarProg;
        private System.Windows.Forms.Button btnGuardarArchTokens;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblEquipo;
        private System.Windows.Forms.Label lblCE;
        private System.Windows.Forms.DataGridViewTextBoxColumn linea;
        private System.Windows.Forms.DataGridViewTextBoxColumn error;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipodedato;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
    }
}

