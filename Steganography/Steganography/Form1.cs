using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steganography
{
    public partial class Form1 : Form
    {

        private string text { get; set; }

        public Form1()
        {
            InitializeComponent();

            InitializeVariables();
        }

        private void InitializeVariables()
        {
            text = "";
        }

        // code to run on program startup
        private void Steganography_Load(object sender, EventArgs e)
        {

        }

        private void EncodeButton_Click(object sender, EventArgs e)
        {

        }

        private void DecodeButton_Click(object sender, EventArgs e)
        {

        }


        // upload an image to the program
        private void UploadButton_Click(object sender, EventArgs e)
        {
            string fileName = null;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    fileName = openFileDialog.FileName;
                }
            }

            if (fileName != null)
            {
                //Do something with the file, for example read text from it
                text = File.ReadAllText(fileName);
                WordsTextBox.Text = text;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

        }
    }
}

