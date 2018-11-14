using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
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
        private Bitmap bmp { get; set; }

        // read from files with these extensions
        public static readonly List<string> ImageExtensions = new List<string> { ".JPG", ".JPE", ".BMP", ".GIF", ".PNG" };

        bool urlFocused;

        public Form1(string[] args)
        {
            InitializeComponent();
            
            // initialize variables, allow for command prompt args
            try
            {
                // no args passed, dont open anything
                if (args.Length < 1)
                {
                    text = string.Empty;
                }
                else
                {
                    text = File.ReadAllText(args[0]);
                    WordsTextBox.Text = text;
                }

                // an image is a parameter
                if (args.Length <= 2)
                {
                    // create a new Bitmap object 
                    bmp = ImageToBMP(args[1]);
                    ImagePictureBox.Image = bmp;
                    ImagePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    // build the error string by putting the invalid args together
                    string err_str = string.Empty;
                    for (int i = 1; i < args.Length; i++)
                        err_str += args[i] + " ";
                        
                    throw new Exception(err_str);
                }
            }
            catch (IndexOutOfRangeException)
            {
                return;
            }
            catch (Exception e)
            {
                MessageBox.Show(
                    "Error opening file(s):\n" + e.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);
                Close();
            }
        }
        
        // code to run on program startup
        private void Steganography_Load(object sender, EventArgs e)
        {
            PasswordTextBox.Enabled = false;

            UrlTextBox.Text = Environment.CurrentDirectory;
            UrlTextBox.GotFocus += UrlTextBox_GotFocus;
            UrlTextBox.MouseUp += UrlTextBox_MouseUp;
            UrlTextBox.Leave += UrlTextBox_Leave;

        }

        // user encodes the data
        private void EncodeButton_Click(object sender, EventArgs e)
        {
            text = WordsTextBox.Text;

            // if the user wants to encrypt the text
            if (PasswordCheckBox.Checked == true)
            {
                text = StringCipher.Encrypt(WordsTextBox.Text, PasswordTextBox.Text);
            }

            // exit if there is no bmp file or it is too small
            if (ValidDetails() == false)
                return;

            bmp = Steg.Embed(text, bmp);

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Save Image";
            sfd.DefaultExt = "png";
            sfd.Filter = "Png files (*.png)|*.png";
            sfd.FilterIndex = 2;
            sfd.RestoreDirectory = true;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                bmp.Save(sfd.FileName, ImageFormat.Png);
            }
        }

        // user decodes data
        private void DecodeButton_Click(object sender, EventArgs e)
        {
            // exit if there is no bmp file
            if (ValidDetails() == false)
                return;

            string decoded = Steg.Extract(bmp);

            // decrypt for the user
            if (PasswordCheckBox.Checked == true)
            {
                try
                {
                    decoded = StringCipher.Decrypt(decoded, PasswordTextBox.Text);
                }
                catch (System.Security.Cryptography.CryptographicException)
                {
                    MessageBox.Show(
                    "Image or password is incorrect.",
                    "Invalid Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                    return;
                }
                catch (System.FormatException)
                {
                    MessageBox.Show(
                    "Image was not large enough to hide all text, and therefore the text cannot be extracted.",
                    "Image Size Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                    return;
                }
            }
                

            decoded = "Decoded text:" + Environment.NewLine + decoded;

            WordsTextBox.Text = decoded;
        }

        // upload an image to the program
        private void UploadTextButton_Click(object sender, EventArgs e)
        {
            string fileName = null;

            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    fileName = dlg.FileName;
                }
            }

            if (fileName != null)
            {
                //Do something with the file, for example read text from it
                text = File.ReadAllText(fileName);
                WordsTextBox.Text = text;
            }
        }
        

        // the user wants to open an image file
        private void UploadImageButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    // create a new Bitmap object 
                    bmp = ImageToBMP(dlg.FileName);
                    ImagePictureBox.Image = bmp;
                    ImagePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        private void PasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            PasswordTextBox.Enabled = PasswordCheckBox.Checked;
        }

        private Bitmap ImageToBMP(string path)
        {
            Image temp = Image.FromFile(path);

            return new Bitmap(temp);
        }

        // make sure that the user has entered all necessary details
        private bool ValidDetails()
        {
            // check if an image was uploaded at all
            if(bmp == null)
            {
                MessageBox.Show(
                    "No image uploaded.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return false;
            }

            // check if the image is large enough to fit all of the text
            long size = bmp.Height * bmp.Width;
            
            if (text.Length * 8 / 3 > size)
            {
                // find the height x width of the minimum size needed for the image to fit the text
                size = (long)Math.Ceiling(Math.Sqrt(text.Length * 8 / 3));

                DialogResult result = MessageBox.Show(
                    $"The image file is not large enough to hold the given text. Minimum size to fit the given text is {size} x {size}, embed anyway?",
                    "Image Size Error",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if(result == DialogResult.No)
                    return false;
            }

            return true;
        }

        private void ExtractAllButton_Click(object sender, EventArgs e)
        {
            string decoded;
            string folder = UrlTextBox.Text;
            Bitmap temp;

            // directory does not exist
            if (Directory.Exists(folder) == false)
                return;

            DecryptAllTextBox.Text = string.Empty;

            // get the files in the folder
            var files = Directory.GetFiles(folder);
            foreach(var f in files)
            {
                // if it is an image file
                if (ImageExtensions.Contains(Path.GetExtension(f).ToUpperInvariant()))
                {
                    // get the image file and extract the data
                    temp = ImageToBMP(f);
                    decoded = Steg.Extract(temp);
                    
                    // hidden text was found, so display
                    if (decoded != string.Empty)
                        DecryptAllTextBox.Text += f.Substring(f.LastIndexOf("\\") + 1)
                            + Environment.NewLine + decoded + Environment.NewLine + Environment.NewLine;
                }
            }
        }

        // make the urltextbox behave like a regular url bar
        void UrlTextBox_Leave(object sender, EventArgs e)
        {
            urlFocused = false;
        }


        void UrlTextBox_GotFocus(object sender, EventArgs e)
        {
            if (MouseButtons == MouseButtons.None)
            {
                UrlTextBox.SelectAll();
                urlFocused = true;
            }
        }

        void UrlTextBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (!urlFocused && this.UrlTextBox.SelectionLength == 0)
            {
                urlFocused = true;
                UrlTextBox.SelectAll();
            }
        }

    }
}

