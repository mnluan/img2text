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
            this.btnCOPY = new System.Windows.Forms.Button();
            this.languagesBOX = new System.Windows.Forms.ComboBox();
            this.btnExportTXT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOPEN
            // 
            this.btnOPEN.Location = new System.Drawing.Point(12, 12);
            this.btnOPEN.Name = "btnOPEN";
            this.btnOPEN.Size = new System.Drawing.Size(321, 23);
            this.btnOPEN.TabIndex = 0;
            this.btnOPEN.Text = "Open Image";
            this.btnOPEN.UseVisualStyleBackColor = true;
            this.btnOPEN.Click += new System.EventHandler(this.btnOPEN_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(12, 121);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(321, 257);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // btnCONVERT
            // 
            this.btnCONVERT.Enabled = false;
            this.btnCONVERT.Location = new System.Drawing.Point(12, 92);
            this.btnCONVERT.Name = "btnCONVERT";
            this.btnCONVERT.Size = new System.Drawing.Size(321, 23);
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
            this.textConverted.Location = new System.Drawing.Point(370, 12);
            this.textConverted.Multiline = true;
            this.textConverted.Name = "textConverted";
            this.textConverted.ReadOnly = true;
            this.textConverted.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textConverted.Size = new System.Drawing.Size(281, 365);
            this.textConverted.TabIndex = 3;
            // 
            // path
            // 
            this.path.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.path.Enabled = false;
            this.path.Location = new System.Drawing.Point(14, 39);
            this.path.Name = "path";
            this.path.ReadOnly = true;
            this.path.Size = new System.Drawing.Size(319, 13);
            this.path.TabIndex = 4;
            // 
            // btnCOPY
            // 
            this.btnCOPY.Enabled = false;
            this.btnCOPY.Location = new System.Drawing.Point(13, 385);
            this.btnCOPY.Name = "btnCOPY";
            this.btnCOPY.Size = new System.Drawing.Size(629, 23);
            this.btnCOPY.TabIndex = 5;
            this.btnCOPY.Text = "Copy Text";
            this.btnCOPY.UseVisualStyleBackColor = true;
            this.btnCOPY.Click += new System.EventHandler(this.btnCOPY_Click);
            // 
            // languagesBOX
            // 
            this.languagesBOX.Enabled = false;
            this.languagesBOX.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.languagesBOX.FormattingEnabled = true;
            this.languagesBOX.Items.AddRange(new object[] {
            "English",
            "Portuguese",
            "Spanish",
            "French",
            "Russian",
            "Japanese",
            "Japanese Vertical"});
            this.languagesBOX.Location = new System.Drawing.Point(14, 65);
            this.languagesBOX.Name = "languagesBOX";
            this.languagesBOX.Size = new System.Drawing.Size(319, 21);
            this.languagesBOX.TabIndex = 6;
            this.languagesBOX.Text = "English";
            // 
            // btnExportTXT
            // 
            this.btnExportTXT.Location = new System.Drawing.Point(13, 415);
            this.btnExportTXT.Name = "btnExportTXT";
            this.btnExportTXT.Size = new System.Drawing.Size(629, 23);
            this.btnExportTXT.TabIndex = 7;
            this.btnExportTXT.Text = "Export Text as TXT";
            this.btnExportTXT.UseVisualStyleBackColor = true;
            this.btnExportTXT.Click += new System.EventHandler(this.btnExportTXT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 454);
            this.Controls.Add(this.btnExportTXT);
            this.Controls.Add(this.languagesBOX);
            this.Controls.Add(this.btnCOPY);
            this.Controls.Add(this.path);
            this.Controls.Add(this.textConverted);
            this.Controls.Add(this.btnCONVERT);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.btnOPEN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Image to Text Converter - OCR Application";
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
        private System.Windows.Forms.Button btnCOPY;
        private System.Windows.Forms.ComboBox languagesBOX;
        private System.Windows.Forms.Button btnExportTXT;
    }
}

