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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnOPEN = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btnCONVERT = new System.Windows.Forms.Button();
            this.textConverted = new System.Windows.Forms.TextBox();
            this.path = new System.Windows.Forms.TextBox();
            this.btnCOPY = new System.Windows.Forms.Button();
            this.languagesBOX = new System.Windows.Forms.ComboBox();
            this.btnExportTXT = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOPEN
            // 
            this.btnOPEN.Location = new System.Drawing.Point(3, 3);
            this.btnOPEN.Name = "btnOPEN";
            this.btnOPEN.Size = new System.Drawing.Size(356, 23);
            this.btnOPEN.TabIndex = 0;
            this.btnOPEN.Text = "Open Image";
            this.btnOPEN.UseVisualStyleBackColor = true;
            this.btnOPEN.Click += new System.EventHandler(this.btnOPEN_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(3, 88);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(356, 311);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // btnCONVERT
            // 
            this.btnCONVERT.Enabled = false;
            this.btnCONVERT.Location = new System.Drawing.Point(3, 59);
            this.btnCONVERT.Name = "btnCONVERT";
            this.btnCONVERT.Size = new System.Drawing.Size(356, 23);
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
            this.textConverted.Location = new System.Drawing.Point(381, 27);
            this.textConverted.Multiline = true;
            this.textConverted.Name = "textConverted";
            this.textConverted.ReadOnly = true;
            this.textConverted.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textConverted.Size = new System.Drawing.Size(355, 484);
            this.textConverted.TabIndex = 3;
            // 
            // path
            // 
            this.path.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.path.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.path.Enabled = false;
            this.path.Location = new System.Drawing.Point(3, 463);
            this.path.Name = "path";
            this.path.ReadOnly = true;
            this.path.Size = new System.Drawing.Size(323, 13);
            this.path.TabIndex = 4;
            // 
            // btnCOPY
            // 
            this.btnCOPY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCOPY.Enabled = false;
            this.btnCOPY.Location = new System.Drawing.Point(3, 405);
            this.btnCOPY.Name = "btnCOPY";
            this.btnCOPY.Size = new System.Drawing.Size(356, 23);
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
            this.languagesBOX.Location = new System.Drawing.Point(3, 32);
            this.languagesBOX.Name = "languagesBOX";
            this.languagesBOX.Size = new System.Drawing.Size(356, 21);
            this.languagesBOX.TabIndex = 6;
            this.languagesBOX.Text = "English";
            // 
            // btnExportTXT
            // 
            this.btnExportTXT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportTXT.Enabled = false;
            this.btnExportTXT.Location = new System.Drawing.Point(3, 434);
            this.btnExportTXT.Name = "btnExportTXT";
            this.btnExportTXT.Size = new System.Drawing.Size(356, 23);
            this.btnExportTXT.TabIndex = 7;
            this.btnExportTXT.Text = "Export Text as TXT";
            this.btnExportTXT.UseVisualStyleBackColor = true;
            this.btnExportTXT.Click += new System.EventHandler(this.btnExportTXT_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(748, 24);
            this.menuStrip.TabIndex = 8;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel1.Controls.Add(this.btnOPEN);
            this.flowLayoutPanel1.Controls.Add(this.languagesBOX);
            this.flowLayoutPanel1.Controls.Add(this.btnCONVERT);
            this.flowLayoutPanel1.Controls.Add(this.pictureBox);
            this.flowLayoutPanel1.Controls.Add(this.btnCOPY);
            this.flowLayoutPanel1.Controls.Add(this.btnExportTXT);
            this.flowLayoutPanel1.Controls.Add(this.path);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(16, 27);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(359, 484);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 523);
            this.Controls.Add(this.textConverted);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Image to Text Converter - OCR Application";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
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
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
    }
}

