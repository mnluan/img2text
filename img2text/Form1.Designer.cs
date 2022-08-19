namespace img2text
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOPEN = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCONVERT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOPEN
            // 
            this.btnOPEN.Location = new System.Drawing.Point(12, 12);
            this.btnOPEN.Name = "btnOPEN";
            this.btnOPEN.Size = new System.Drawing.Size(233, 23);
            this.btnOPEN.TabIndex = 0;
            this.btnOPEN.Text = "Open Image";
            this.btnOPEN.UseVisualStyleBackColor = true;
            this.btnOPEN.Click += new System.EventHandler(this.btnOPEN_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 309);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnCONVERT
            // 
            this.btnCONVERT.Enabled = false;
            this.btnCONVERT.Location = new System.Drawing.Point(12, 40);
            this.btnCONVERT.Name = "btnCONVERT";
            this.btnCONVERT.Size = new System.Drawing.Size(233, 23);
            this.btnCONVERT.TabIndex = 2;
            this.btnCONVERT.Text = "Convert IMG to TEXT";
            this.btnCONVERT.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 390);
            this.Controls.Add(this.btnCONVERT);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnOPEN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOPEN;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCONVERT;
    }
}

