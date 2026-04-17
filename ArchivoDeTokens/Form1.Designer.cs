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
            this.SuspendLayout();
            // 
            // btnLexico
            // 
            this.btnLexico.Location = new System.Drawing.Point(362, 186);
            this.btnLexico.Name = "btnLexico";
            this.btnLexico.Size = new System.Drawing.Size(104, 41);
            this.btnLexico.TabIndex = 1;
            this.btnLexico.Text = "button1";
            this.btnLexico.UseVisualStyleBackColor = true;
            this.btnLexico.Click += new System.EventHandler(this.btnLexico_Click);
            // 
            // rtxtCodigo
            // 
            this.rtxtCodigo.Location = new System.Drawing.Point(34, 43);
            this.rtxtCodigo.Name = "rtxtCodigo";
            this.rtxtCodigo.Size = new System.Drawing.Size(322, 314);
            this.rtxtCodigo.TabIndex = 3;
            this.rtxtCodigo.Text = "";
            this.rtxtCodigo.WordWrap = false;
            // 
            // rtxtTokens
            // 
            this.rtxtTokens.Location = new System.Drawing.Point(472, 43);
            this.rtxtTokens.Name = "rtxtTokens";
            this.rtxtTokens.Size = new System.Drawing.Size(322, 314);
            this.rtxtTokens.TabIndex = 4;
            this.rtxtTokens.Text = "";
            this.rtxtTokens.WordWrap = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 531);
            this.Controls.Add(this.rtxtTokens);
            this.Controls.Add(this.rtxtCodigo);
            this.Controls.Add(this.btnLexico);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLexico;
        private System.Windows.Forms.RichTextBox rtxtCodigo;
        private System.Windows.Forms.RichTextBox rtxtTokens;
    }
}

