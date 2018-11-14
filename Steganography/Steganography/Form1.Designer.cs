namespace Steganography
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.EncodeButton = new System.Windows.Forms.Button();
            this.DecodeButton = new System.Windows.Forms.Button();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.ImagePictureBox = new System.Windows.Forms.PictureBox();
            this.UploadTextButton = new System.Windows.Forms.Button();
            this.UploadImageButton = new System.Windows.Forms.Button();
            this.WordsTextBox = new System.Windows.Forms.TextBox();
            this.ImageGroupBox = new System.Windows.Forms.GroupBox();
            this.PasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.FileTabPage = new System.Windows.Forms.TabPage();
            this.FolderTabPage = new System.Windows.Forms.TabPage();
            this.ExtractAllButton = new System.Windows.Forms.Button();
            this.DecryptAllTextBox = new System.Windows.Forms.TextBox();
            this.UrlLabel = new System.Windows.Forms.Label();
            this.UrlTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePictureBox)).BeginInit();
            this.ImageGroupBox.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.FileTabPage.SuspendLayout();
            this.FolderTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // EncodeButton
            // 
            this.EncodeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EncodeButton.Location = new System.Drawing.Point(391, 394);
            this.EncodeButton.Margin = new System.Windows.Forms.Padding(2);
            this.EncodeButton.Name = "EncodeButton";
            this.EncodeButton.Size = new System.Drawing.Size(160, 28);
            this.EncodeButton.TabIndex = 0;
            this.EncodeButton.Text = "Encode";
            this.EncodeButton.UseVisualStyleBackColor = true;
            this.EncodeButton.Click += new System.EventHandler(this.EncodeButton_Click);
            // 
            // DecodeButton
            // 
            this.DecodeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecodeButton.Location = new System.Drawing.Point(562, 394);
            this.DecodeButton.Margin = new System.Windows.Forms.Padding(2);
            this.DecodeButton.Name = "DecodeButton";
            this.DecodeButton.Size = new System.Drawing.Size(150, 28);
            this.DecodeButton.TabIndex = 1;
            this.DecodeButton.Text = "Decode";
            this.DecodeButton.UseVisualStyleBackColor = true;
            this.DecodeButton.Click += new System.EventHandler(this.DecodeButton_Click);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextBox.Location = new System.Drawing.Point(95, 397);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '●';
            this.PasswordTextBox.Size = new System.Drawing.Size(266, 22);
            this.PasswordTextBox.TabIndex = 5;
            // 
            // ImagePictureBox
            // 
            this.ImagePictureBox.Location = new System.Drawing.Point(1, 7);
            this.ImagePictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.ImagePictureBox.Name = "ImagePictureBox";
            this.ImagePictureBox.Size = new System.Drawing.Size(320, 340);
            this.ImagePictureBox.TabIndex = 7;
            this.ImagePictureBox.TabStop = false;
            // 
            // UploadTextButton
            // 
            this.UploadTextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UploadTextButton.Location = new System.Drawing.Point(5, 5);
            this.UploadTextButton.Margin = new System.Windows.Forms.Padding(2);
            this.UploadTextButton.Name = "UploadTextButton";
            this.UploadTextButton.Size = new System.Drawing.Size(380, 28);
            this.UploadTextButton.TabIndex = 9;
            this.UploadTextButton.Text = "Upload Text File";
            this.UploadTextButton.UseVisualStyleBackColor = true;
            this.UploadTextButton.Click += new System.EventHandler(this.UploadTextButton_Click);
            // 
            // UploadImageButton
            // 
            this.UploadImageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UploadImageButton.Location = new System.Drawing.Point(391, 5);
            this.UploadImageButton.Margin = new System.Windows.Forms.Padding(2);
            this.UploadImageButton.Name = "UploadImageButton";
            this.UploadImageButton.Size = new System.Drawing.Size(324, 28);
            this.UploadImageButton.TabIndex = 17;
            this.UploadImageButton.Text = "Upload Image File";
            this.UploadImageButton.UseVisualStyleBackColor = true;
            this.UploadImageButton.Click += new System.EventHandler(this.UploadImageButton_Click);
            // 
            // WordsTextBox
            // 
            this.WordsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WordsTextBox.Location = new System.Drawing.Point(5, 37);
            this.WordsTextBox.Multiline = true;
            this.WordsTextBox.Name = "WordsTextBox";
            this.WordsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.WordsTextBox.Size = new System.Drawing.Size(380, 340);
            this.WordsTextBox.TabIndex = 18;
            // 
            // ImageGroupBox
            // 
            this.ImageGroupBox.Controls.Add(this.ImagePictureBox);
            this.ImageGroupBox.Location = new System.Drawing.Point(391, 30);
            this.ImageGroupBox.Name = "ImageGroupBox";
            this.ImageGroupBox.Size = new System.Drawing.Size(322, 347);
            this.ImageGroupBox.TabIndex = 19;
            this.ImageGroupBox.TabStop = false;
            // 
            // PasswordCheckBox
            // 
            this.PasswordCheckBox.AutoSize = true;
            this.PasswordCheckBox.Location = new System.Drawing.Point(14, 399);
            this.PasswordCheckBox.Name = "PasswordCheckBox";
            this.PasswordCheckBox.Size = new System.Drawing.Size(75, 17);
            this.PasswordCheckBox.TabIndex = 20;
            this.PasswordCheckBox.Text = "Password:";
            this.PasswordCheckBox.UseVisualStyleBackColor = true;
            this.PasswordCheckBox.CheckedChanged += new System.EventHandler(this.PasswordCheckBox_CheckedChanged);
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.FileTabPage);
            this.TabControl.Controls.Add(this.FolderTabPage);
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(725, 459);
            this.TabControl.TabIndex = 21;
            // 
            // FileTabPage
            // 
            this.FileTabPage.Controls.Add(this.UploadTextButton);
            this.FileTabPage.Controls.Add(this.PasswordCheckBox);
            this.FileTabPage.Controls.Add(this.EncodeButton);
            this.FileTabPage.Controls.Add(this.UploadImageButton);
            this.FileTabPage.Controls.Add(this.DecodeButton);
            this.FileTabPage.Controls.Add(this.ImageGroupBox);
            this.FileTabPage.Controls.Add(this.PasswordTextBox);
            this.FileTabPage.Controls.Add(this.WordsTextBox);
            this.FileTabPage.Location = new System.Drawing.Point(4, 22);
            this.FileTabPage.Name = "FileTabPage";
            this.FileTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.FileTabPage.Size = new System.Drawing.Size(717, 433);
            this.FileTabPage.TabIndex = 0;
            this.FileTabPage.Text = "File Steganography";
            this.FileTabPage.UseVisualStyleBackColor = true;
            // 
            // FolderTabPage
            // 
            this.FolderTabPage.Controls.Add(this.ExtractAllButton);
            this.FolderTabPage.Controls.Add(this.DecryptAllTextBox);
            this.FolderTabPage.Controls.Add(this.UrlLabel);
            this.FolderTabPage.Controls.Add(this.UrlTextBox);
            this.FolderTabPage.Location = new System.Drawing.Point(4, 22);
            this.FolderTabPage.Name = "FolderTabPage";
            this.FolderTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.FolderTabPage.Size = new System.Drawing.Size(717, 433);
            this.FolderTabPage.TabIndex = 1;
            this.FolderTabPage.Text = "Folder Steganography";
            this.FolderTabPage.UseVisualStyleBackColor = true;
            // 
            // ExtractAllButton
            // 
            this.ExtractAllButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExtractAllButton.Location = new System.Drawing.Point(46, 31);
            this.ExtractAllButton.Margin = new System.Windows.Forms.Padding(2);
            this.ExtractAllButton.Name = "ExtractAllButton";
            this.ExtractAllButton.Size = new System.Drawing.Size(666, 28);
            this.ExtractAllButton.TabIndex = 20;
            this.ExtractAllButton.Text = "Extract text from all images";
            this.ExtractAllButton.UseVisualStyleBackColor = true;
            this.ExtractAllButton.Click += new System.EventHandler(this.ExtractAllButton_Click);
            // 
            // DecryptAllTextBox
            // 
            this.DecryptAllTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecryptAllTextBox.Location = new System.Drawing.Point(6, 64);
            this.DecryptAllTextBox.Multiline = true;
            this.DecryptAllTextBox.Name = "DecryptAllTextBox";
            this.DecryptAllTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DecryptAllTextBox.Size = new System.Drawing.Size(706, 363);
            this.DecryptAllTextBox.TabIndex = 19;
            // 
            // UrlLabel
            // 
            this.UrlLabel.AutoSize = true;
            this.UrlLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UrlLabel.Location = new System.Drawing.Point(6, 8);
            this.UrlLabel.Name = "UrlLabel";
            this.UrlLabel.Size = new System.Drawing.Size(35, 16);
            this.UrlLabel.TabIndex = 7;
            this.UrlLabel.Text = "URL";
            // 
            // UrlTextBox
            // 
            this.UrlTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UrlTextBox.Location = new System.Drawing.Point(46, 5);
            this.UrlTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.UrlTextBox.Name = "UrlTextBox";
            this.UrlTextBox.Size = new System.Drawing.Size(666, 22);
            this.UrlTextBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 458);
            this.Controls.Add(this.TabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Steganography";
            this.Load += new System.EventHandler(this.Steganography_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImagePictureBox)).EndInit();
            this.ImageGroupBox.ResumeLayout(false);
            this.TabControl.ResumeLayout(false);
            this.FileTabPage.ResumeLayout(false);
            this.FileTabPage.PerformLayout();
            this.FolderTabPage.ResumeLayout(false);
            this.FolderTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EncodeButton;
        private System.Windows.Forms.Button DecodeButton;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.PictureBox ImagePictureBox;
        private System.Windows.Forms.Button UploadTextButton;
        private System.Windows.Forms.Button UploadImageButton;
        private System.Windows.Forms.TextBox WordsTextBox;
        private System.Windows.Forms.GroupBox ImageGroupBox;
        private System.Windows.Forms.CheckBox PasswordCheckBox;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage FileTabPage;
        private System.Windows.Forms.TabPage FolderTabPage;
        private System.Windows.Forms.Label UrlLabel;
        private System.Windows.Forms.TextBox UrlTextBox;
        private System.Windows.Forms.TextBox DecryptAllTextBox;
        private System.Windows.Forms.Button ExtractAllButton;
    }
}

