using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IronOcr;

namespace img2text
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void btnOPEN_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *png)|*.jpg; *.jpeg; *.gif; *.bmp; *png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pictureBox.Image = new Bitmap(open.FileName);
                
                // enable button 'convert image to text'
                btnCONVERT.Enabled = true;

                // enable options to select languages
                languagesBOX.Enabled = true;

                //pick the path from image
                string sSelectedPath = open.FileName;

                //Enable and show path from image
                path.Enabled = true;
                path.Text = sSelectedPath;
            }
        }

        public void btnCONVERT_Click(object sender, EventArgs e)
        {
            //Enable textbox with converted text and the button to copy
            textConverted.Enabled = true;
            btnCOPY.Enabled = true;

            String language = languagesBOX.Text;
            switch (language)
            {
                case "English":
                    try 
                    {
                        IronTesseract IronOcr = new IronTesseract();
                        var Result = IronOcr.Read(path.Text);
                        textConverted.Text = Result.Text;
                    }
                    catch
                    {
                        textConverted.Text = "ERROR! Unable to convert Image to Text";
                    }
                    break;

                case "Portuguese":
                    try
                    {
                        IronTesseract IronOcr = new IronTesseract();
                        IronOcr.Language = OcrLanguage.PortugueseBest;
                        var Result = IronOcr.Read(path.Text);
                        textConverted.Text = Result.Text;
                    }
                    catch
                    {
                        textConverted.Text = "ERROR! Unable to convert Image to Text";
                    }
                    break;

                case "Spanish":
                    try
                    {
                        IronTesseract IronOcr = new IronTesseract();
                        IronOcr.Language = OcrLanguage.SpanishBest;
                        var Result = IronOcr.Read(path.Text);
                        textConverted.Text = Result.Text;
                    }
                    catch
                    {
                        textConverted.Text = "ERROR! Unable to convert Image to Text";
                    }
                    break;

                case "French":
                    try
                    {
                        IronTesseract IronOcr = new IronTesseract();
                        var Result = IronOcr.Read(path.Text);
                        textConverted.Text = Result.Text;
                    }
                    catch
                    {
                        textConverted.Text = "ERROR! Unable to convert Image to Text";
                    }
                    break;

                case "Japanese":
                    try
                    {
                        IronTesseract IronOcr = new IronTesseract();
                        IronOcr.Language = OcrLanguage.JapaneseBest;
                        var Result = IronOcr.Read(path.Text);
                        textConverted.Text = Result.Text;
                    }
                    catch
                    {
                        textConverted.Text = "ERROR! Unable to convert Image to Text";
                    }
                    break;

                case "Japanese Vertical":
                    try
                    {
                        IronTesseract IronOcr = new IronTesseract();
                        IronOcr.Language = OcrLanguage.JapaneseVerticalBest;
                        var Result = IronOcr.Read(path.Text);
                        textConverted.Text = Result.Text;
                    }
                    catch
                    {
                        textConverted.Text = "ERROR! Unable to convert Image to Text";
                    }
                    break;

                case "Russian":
                    try
                    {
                        IronTesseract IronOcr = new IronTesseract();
                        IronOcr.Language = OcrLanguage.RussianBest;
                        var Result = IronOcr.Read(path.Text);
                        textConverted.Text = Result.Text;
                    }
                    catch
                    {
                        textConverted.Text = "ERROR! Unable to convert Image to Text";
                    }
                    break;
            }

        }

        private void btnCOPY_Click(object sender, EventArgs e)
        {
            //Copy the text from textbox 'TextConverted' to clipboard
            Clipboard.SetText(textConverted.Text);
        }

        private void btnExportTXT_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt";
            saveFileDialog1.FilterIndex = 1;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open(saveFileDialog1.FileName, FileMode.CreateNew))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.WriteLine(textConverted.Text);
                }
            }   
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Same command from open button
            btnOPEN_Click(sender, e);
        }
    }

}
