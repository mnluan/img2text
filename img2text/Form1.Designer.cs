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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btnCONVERT = new System.Windows.Forms.Button();
            this.textConverted = new System.Windows.Forms.TextBox();
            this.path = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
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
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(12, 96);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(233, 282);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
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
            this.btnCONVERT.Click += new System.EventHandler(this.btnCONVERT_Click);
            // 
            // textConverted
            // 
            this.textConverted.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textConverted.Enabled = false;
            this.textConverted.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textConverted.Location = new System.Drawing.Point(252, 13);
            this.textConverted.Multiline = true;
            this.textConverted.Name = "textConverted";
            this.textConverted.ReadOnly = true;
            this.textConverted.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textConverted.Size = new System.Drawing.Size(281, 365);
            this.textConverted.TabIndex = 3;
            // 
            // path
            // 
            this.path.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.path.Enabled = false;
            this.path.Location = new System.Drawing.Point(13, 70);
            this.path.Name = "path";
            this.path.ReadOnly = true;
            this.path.Size = new System.Drawing.Size(232, 20);
            this.path.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 390);
            this.Controls.Add(this.path);
            this.Controls.Add(this.textConverted);
            this.Controls.Add(this.btnCONVERT);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.btnOPEN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Image to Text Converter";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOPEN;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btnCONVERT;
        private System.Windows.Forms.TextBox textConverted;
        private System.Windows.Forms.TextBox path;
    }
}

