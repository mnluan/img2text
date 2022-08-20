using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pictureBox.Image = new Bitmap(open.FileName);
                
                // enable button 'convert image to text'
                btnCONVERT.Enabled = true;

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
                    }
                    catch
                    { 
                    }
                    break;

                case "Portuguese":
                    try
                    {
                    }
                    catch
                    {
                    }
                    break;

                case "Japanese":
                    try
                    {
                    }
                    catch
                    {
                    }
                    break;

                case "Russian":
                    try
                    {
                    }
                    catch
                    {
                    }
                    break;
            }

        }

        private void btnCOPY_Click(object sender, EventArgs e)
        {
            //Copy the text from textbox 'TextConverted' to clipboard
            Clipboard.SetText(textConverted.Text);
        }
    }
}
