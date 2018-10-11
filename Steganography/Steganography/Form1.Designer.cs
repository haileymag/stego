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
            this.EncryptCheckBox = new System.Windows.Forms.CheckBox();
            this.EncryptLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.TextListBox = new System.Windows.Forms.ListBox();
            this.ImagePictureBox = new System.Windows.Forms.PictureBox();
            this.ImageLabel = new System.Windows.Forms.Label();
            this.UploadButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.DirectionLabel1 = new System.Windows.Forms.Label();
            this.DirectionLabel2 = new System.Windows.Forms.Label();
            this.DirectionLabel3 = new System.Windows.Forms.Label();
            this.DirectionLabel4 = new System.Windows.Forms.Label();
            this.SaveLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // EncodeButton
            // 
            this.EncodeButton.Location = new System.Drawing.Point(305, 219);
            this.EncodeButton.Margin = new System.Windows.Forms.Padding(2);
            this.EncodeButton.Name = "EncodeButton";
            this.EncodeButton.Size = new System.Drawing.Size(92, 32);
            this.EncodeButton.TabIndex = 0;
            this.EncodeButton.Text = "ENCODE";
            this.EncodeButton.UseVisualStyleBackColor = true;
            this.EncodeButton.Click += new System.EventHandler(this.EncodeButton_Click);
            // 
            // DecodeButton
            // 
            this.DecodeButton.Location = new System.Drawing.Point(443, 221);
            this.DecodeButton.Margin = new System.Windows.Forms.Padding(2);
            this.DecodeButton.Name = "DecodeButton";
            this.DecodeButton.Size = new System.Drawing.Size(92, 32);
            this.DecodeButton.TabIndex = 1;
            this.DecodeButton.Text = "DECODE";
            this.DecodeButton.UseVisualStyleBackColor = true;
            this.DecodeButton.Click += new System.EventHandler(this.DecodeButton_Click);
            // 
            // EncryptCheckBox
            // 
            this.EncryptCheckBox.AutoSize = true;
            this.EncryptCheckBox.Location = new System.Drawing.Point(9, 248);
            this.EncryptCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.EncryptCheckBox.Name = "EncryptCheckBox";
            this.EncryptCheckBox.Size = new System.Drawing.Size(44, 17);
            this.EncryptCheckBox.TabIndex = 2;
            this.EncryptCheckBox.Text = "Yes";
            this.EncryptCheckBox.UseVisualStyleBackColor = true;
            // 
            // EncryptLabel
            // 
            this.EncryptLabel.AutoSize = true;
            this.EncryptLabel.Location = new System.Drawing.Point(9, 231);
            this.EncryptLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EncryptLabel.Name = "EncryptLabel";
            this.EncryptLabel.Size = new System.Drawing.Size(230, 13);
            this.EncryptLabel.TabIndex = 3;
            this.EncryptLabel.Text = "Encrypt? (Click box if yes and create password)";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(109, 249);
            this.PasswordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(56, 13);
            this.PasswordLabel.TabIndex = 4;
            this.PasswordLabel.Text = "Password:";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(168, 247);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(105, 20);
            this.PasswordTextBox.TabIndex = 5;
            // 
            // TextListBox
            // 
            this.TextListBox.FormattingEnabled = true;
            this.TextListBox.Location = new System.Drawing.Point(9, 117);
            this.TextListBox.Margin = new System.Windows.Forms.Padding(2);
            this.TextListBox.Name = "TextListBox";
            this.TextListBox.Size = new System.Drawing.Size(243, 108);
            this.TextListBox.TabIndex = 6;
            // 
            // ImagePictureBox
            // 
            this.ImagePictureBox.Location = new System.Drawing.Point(305, 35);
            this.ImagePictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.ImagePictureBox.Name = "ImagePictureBox";
            this.ImagePictureBox.Size = new System.Drawing.Size(230, 180);
            this.ImagePictureBox.TabIndex = 7;
            this.ImagePictureBox.TabStop = false;
            // 
            // ImageLabel
            // 
            this.ImageLabel.AutoSize = true;
            this.ImageLabel.Location = new System.Drawing.Point(303, 19);
            this.ImageLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ImageLabel.Name = "ImageLabel";
            this.ImageLabel.Size = new System.Drawing.Size(39, 13);
            this.ImageLabel.TabIndex = 8;
            this.ImageLabel.Text = "Image:";
            // 
            // UploadButton
            // 
            this.UploadButton.Location = new System.Drawing.Point(53, 78);
            this.UploadButton.Margin = new System.Windows.Forms.Padding(2);
            this.UploadButton.Name = "UploadButton";
            this.UploadButton.Size = new System.Drawing.Size(157, 25);
            this.UploadButton.TabIndex = 9;
            this.UploadButton.Text = "Upload Image";
            this.UploadButton.UseVisualStyleBackColor = true;
            this.UploadButton.Click += new System.EventHandler(this.UploadButton_Click);
            // 
            // DirectionLabel1
            // 
            this.DirectionLabel1.AutoSize = true;
            this.DirectionLabel1.Location = new System.Drawing.Point(9, 7);
            this.DirectionLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DirectionLabel1.Name = "DirectionLabel1";
            this.DirectionLabel1.Size = new System.Drawing.Size(274, 13);
            this.DirectionLabel1.TabIndex = 11;
            this.DirectionLabel1.Text = "Please upload image desired to be encoded or decoded.";
            // 
            // DirectionLabel2
            // 
            this.DirectionLabel2.AutoSize = true;
            this.DirectionLabel2.Location = new System.Drawing.Point(9, 21);
            this.DirectionLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DirectionLabel2.Name = "DirectionLabel2";
            this.DirectionLabel2.Size = new System.Drawing.Size(267, 13);
            this.DirectionLabel2.TabIndex = 12;
            this.DirectionLabel2.Text = "After uploading, if you choose to decode, hit \"decode\".";
            // 
            // DirectionLabel3
            // 
            this.DirectionLabel3.AutoSize = true;
            this.DirectionLabel3.Location = new System.Drawing.Point(9, 35);
            this.DirectionLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DirectionLabel3.Name = "DirectionLabel3";
            this.DirectionLabel3.Size = new System.Drawing.Size(264, 13);
            this.DirectionLabel3.TabIndex = 13;
            this.DirectionLabel3.Text = "For encoding, please type in your desired text, encrypt ";
            // 
            // DirectionLabel4
            // 
            this.DirectionLabel4.AutoSize = true;
            this.DirectionLabel4.Location = new System.Drawing.Point(9, 49);
            this.DirectionLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DirectionLabel4.Name = "DirectionLabel4";
            this.DirectionLabel4.Size = new System.Drawing.Size(204, 13);
            this.DirectionLabel4.TabIndex = 14;
            this.DirectionLabel4.Text = "via password if desired, and hit \"encode\".";
            // 
            // SaveLabel
            // 
            this.SaveLabel.AutoSize = true;
            this.SaveLabel.Location = new System.Drawing.Point(285, 265);
            this.SaveLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SaveLabel.Name = "SaveLabel";
            this.SaveLabel.Size = new System.Drawing.Size(114, 13);
            this.SaveLabel.TabIndex = 15;
            this.SaveLabel.Text = "Save encoded image?";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(401, 262);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(2);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(56, 19);
            this.SaveButton.TabIndex = 16;
            this.SaveButton.Text = "YES";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 291);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.SaveLabel);
            this.Controls.Add(this.DirectionLabel4);
            this.Controls.Add(this.DirectionLabel3);
            this.Controls.Add(this.DirectionLabel2);
            this.Controls.Add(this.DirectionLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UploadButton);
            this.Controls.Add(this.ImageLabel);
            this.Controls.Add(this.ImagePictureBox);
            this.Controls.Add(this.TextListBox);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.EncryptLabel);
            this.Controls.Add(this.EncryptCheckBox);
            this.Controls.Add(this.DecodeButton);
            this.Controls.Add(this.EncodeButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Steganography";
            this.Load += new System.EventHandler(this.Steganography_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImagePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EncodeButton;
        private System.Windows.Forms.Button DecodeButton;
        private System.Windows.Forms.CheckBox EncryptCheckBox;
        private System.Windows.Forms.Label EncryptLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.ListBox TextListBox;
        private System.Windows.Forms.PictureBox ImagePictureBox;
        private System.Windows.Forms.Label ImageLabel;
        private System.Windows.Forms.Button UploadButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label DirectionLabel1;
        private System.Windows.Forms.Label DirectionLabel2;
        private System.Windows.Forms.Label DirectionLabel3;
        private System.Windows.Forms.Label DirectionLabel4;
        private System.Windows.Forms.Label SaveLabel;
        private System.Windows.Forms.Button SaveButton;
    }
}

