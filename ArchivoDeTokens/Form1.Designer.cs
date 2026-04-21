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
            this.linea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.error = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvSimbolos = new System.Windows.Forms.DataGridView();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipodedato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblCE = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nLinea2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.DgvErrores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSimbolos)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLexico
            // 
            this.btnLexico.Location = new System.Drawing.Point(807, 35);
            this.btnLexico.Margin = new System.Windows.Forms.Padding(2);
            this.btnLexico.Name = "btnLexico";
            this.btnLexico.Size = new System.Drawing.Size(78, 46);
            this.btnLexico.TabIndex = 1;
            this.btnLexico.Text = "Analizador Léxico";
            this.btnLexico.UseVisualStyleBackColor = true;
            this.btnLexico.Click += new System.EventHandler(this.btnLexico_Click);
            // 
            // rtxtCodigo
            // 
            this.rtxtCodigo.Location = new System.Drawing.Point(86, 35);
            this.rtxtCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.rtxtCodigo.Name = "rtxtCodigo";
            this.rtxtCodigo.Size = new System.Drawing.Size(678, 689);
            this.rtxtCodigo.TabIndex = 3;
            this.rtxtCodigo.Text = "";
            this.rtxtCodigo.WordWrap = false;
            this.rtxtCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtxtCodigo_KeyDown);
            // 
            // rtxtTokens
            // 
            this.rtxtTokens.Location = new System.Drawing.Point(86, 38);
            this.rtxtTokens.Margin = new System.Windows.Forms.Padding(2);
            this.rtxtTokens.Name = "rtxtTokens";
            this.rtxtTokens.Size = new System.Drawing.Size(678, 686);
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
            this.DgvErrores.Location = new System.Drawing.Point(13, 31);
            this.DgvErrores.Name = "DgvErrores";
            this.DgvErrores.RowHeadersWidth = 51;
            this.DgvErrores.Size = new System.Drawing.Size(753, 428);
            this.DgvErrores.TabIndex = 5;
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
            this.error.Width = 54;
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
            this.DgvSimbolos.Location = new System.Drawing.Point(15, 30);
            this.DgvSimbolos.Name = "DgvSimbolos";
            this.DgvSimbolos.RowHeadersWidth = 51;
            this.DgvSimbolos.Size = new System.Drawing.Size(751, 429);
            this.DgvSimbolos.TabIndex = 6;
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
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.nLinea);
            this.panel1.Location = new System.Drawing.Point(12, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(72, 688);
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
            // btnCargarProg
            // 
            this.btnCargarProg.Location = new System.Drawing.Point(808, 85);
            this.btnCargarProg.Margin = new System.Windows.Forms.Padding(2);
            this.btnCargarProg.Name = "btnCargarProg";
            this.btnCargarProg.Size = new System.Drawing.Size(78, 52);
            this.btnCargarProg.TabIndex = 8;
            this.btnCargarProg.Text = "Cargar Programa";
            this.btnCargarProg.UseVisualStyleBackColor = true;
            this.btnCargarProg.Click += new System.EventHandler(this.btnCargarProg_Click);
            // 
            // btnEditarProg
            // 
            this.btnEditarProg.Location = new System.Drawing.Point(808, 141);
            this.btnEditarProg.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditarProg.Name = "btnEditarProg";
            this.btnEditarProg.Size = new System.Drawing.Size(78, 41);
            this.btnEditarProg.TabIndex = 9;
            this.btnEditarProg.Text = "Editar Programa";
            this.btnEditarProg.UseVisualStyleBackColor = true;
            this.btnEditarProg.Click += new System.EventHandler(this.btnEditarProg_Click);
            // 
            // btnGuardarProg
            // 
            this.btnGuardarProg.Location = new System.Drawing.Point(808, 186);
            this.btnGuardarProg.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardarProg.Name = "btnGuardarProg";
            this.btnGuardarProg.Size = new System.Drawing.Size(78, 43);
            this.btnGuardarProg.TabIndex = 10;
            this.btnGuardarProg.Text = "Guardar Programa";
            this.btnGuardarProg.UseVisualStyleBackColor = true;
            this.btnGuardarProg.Click += new System.EventHandler(this.btnGuardarProg_Click);
            // 
            // btnGuardarArchTokens
            // 
            this.btnGuardarArchTokens.Location = new System.Drawing.Point(807, 233);
            this.btnGuardarArchTokens.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardarArchTokens.Name = "btnGuardarArchTokens";
            this.btnGuardarArchTokens.Size = new System.Drawing.Size(78, 55);
            this.btnGuardarArchTokens.TabIndex = 11;
            this.btnGuardarArchTokens.Text = "Guardar Archivo de Tokens";
            this.btnGuardarArchTokens.UseVisualStyleBackColor = true;
            this.btnGuardarArchTokens.Click += new System.EventHandler(this.btnGuardarArchTokens_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Archivo de Tokens";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tabla de Errores";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 12);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Tabla de Símbolos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(988, 35);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // lblEquipo
            // 
            this.lblEquipo.AutoSize = true;
            this.lblEquipo.Location = new System.Drawing.Point(988, 207);
            this.lblEquipo.Name = "lblEquipo";
            this.lblEquipo.Size = new System.Drawing.Size(29, 13);
            this.lblEquipo.TabIndex = 17;
            this.lblEquipo.Text = "label";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(777, 755);
            this.tabControl1.TabIndex = 19;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rtxtCodigo);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(769, 729);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Código";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblCE);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.rtxtTokens);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(769, 729);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tokens";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblCE
            // 
            this.lblCE.AutoSize = true;
            this.lblCE.Location = new System.Drawing.Point(590, 38);
            this.lblCE.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCE.Name = "lblCE";
            this.lblCE.Size = new System.Drawing.Size(0, 13);
            this.lblCE.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.nLinea2);
            this.panel2.Location = new System.Drawing.Point(12, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(72, 685);
            this.panel2.TabIndex = 14;
            // 
            // nLinea2
            // 
            this.nLinea2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nLinea2.ForeColor = System.Drawing.Color.Maroon;
            this.nLinea2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.nLinea2.Location = new System.Drawing.Point(3, 3);
            this.nLinea2.Name = "nLinea2";
            this.nLinea2.Size = new System.Drawing.Size(66, 13);
            this.nLinea2.TabIndex = 0;
            this.nLinea2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 19);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Código";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.DgvErrores);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(769, 835);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Errores";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.DgvSimbolos);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(769, 835);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Simbolos";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1231, 806);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblEquipo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnGuardarArchTokens);
            this.Controls.Add(this.btnGuardarProg);
            this.Controls.Add(this.btnEditarProg);
            this.Controls.Add(this.btnCargarProg);
            this.Controls.Add(this.btnLexico);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Analizador Léxico";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvErrores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSimbolos)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn linea;
        private System.Windows.Forms.DataGridViewTextBoxColumn error;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipodedato;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label nLinea2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label lblCE;
    }
}

