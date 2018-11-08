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
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.ImagePictureBox = new System.Windows.Forms.PictureBox();
            this.UploadImageButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.UploadTextButton = new System.Windows.Forms.Button();
            this.WordsTextBox = new System.Windows.Forms.TextBox();
            this.ImageGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePictureBox)).BeginInit();
            this.ImageGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // EncodeButton
            // 
            this.EncodeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EncodeButton.Location = new System.Drawing.Point(339, 387);
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
            this.DecodeButton.Location = new System.Drawing.Point(513, 387);
            this.DecodeButton.Margin = new System.Windows.Forms.Padding(2);
            this.DecodeButton.Name = "DecodeButton";
            this.DecodeButton.Size = new System.Drawing.Size(150, 28);
            this.DecodeButton.TabIndex = 1;
            this.DecodeButton.Text = "Decode";
            this.DecodeButton.UseVisualStyleBackColor = true;
            this.DecodeButton.Click += new System.EventHandler(this.DecodeButton_Click);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(11, 406);
            this.PasswordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(71, 16);
            this.PasswordLabel.TabIndex = 4;
            this.PasswordLabel.Text = "Password:";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextBox.Location = new System.Drawing.Point(86, 403);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '●';
            this.PasswordTextBox.Size = new System.Drawing.Size(162, 22);
            this.PasswordTextBox.TabIndex = 5;
            // 
            // ImagePictureBox
            // 
            this.ImagePictureBox.Location = new System.Drawing.Point(1, 7);
            this.ImagePictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.ImagePictureBox.Name = "ImagePictureBox";
            this.ImagePictureBox.Size = new System.Drawing.Size(320, 337);
            this.ImagePictureBox.TabIndex = 7;
            this.ImagePictureBox.TabStop = false;
            // 
            // UploadImageButton
            // 
            this.UploadImageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UploadImageButton.Location = new System.Drawing.Point(11, 11);
            this.UploadImageButton.Margin = new System.Windows.Forms.Padding(2);
            this.UploadImageButton.Name = "UploadImageButton";
            this.UploadImageButton.Size = new System.Drawing.Size(324, 28);
            this.UploadImageButton.TabIndex = 9;
            this.UploadImageButton.Text = "Upload Text File";
            this.UploadImageButton.UseVisualStyleBackColor = true;
            this.UploadImageButton.Click += new System.EventHandler(this.UploadButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(339, 419);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(2);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(324, 28);
            this.SaveButton.TabIndex = 16;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // UploadTextButton
            // 
            this.UploadTextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UploadTextButton.Location = new System.Drawing.Point(341, 11);
            this.UploadTextButton.Margin = new System.Windows.Forms.Padding(2);
            this.UploadTextButton.Name = "UploadTextButton";
            this.UploadTextButton.Size = new System.Drawing.Size(324, 28);
            this.UploadTextButton.TabIndex = 17;
            this.UploadTextButton.Text = "Upload Image File";
            this.UploadTextButton.UseVisualStyleBackColor = true;
            this.UploadTextButton.Click += new System.EventHandler(this.UploadTextButton_Click);
            // 
            // WordsTextBox
            // 
            this.WordsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WordsTextBox.Location = new System.Drawing.Point(11, 43);
            this.WordsTextBox.Multiline = true;
            this.WordsTextBox.Name = "WordsTextBox";
            this.WordsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.WordsTextBox.Size = new System.Drawing.Size(324, 340);
            this.WordsTextBox.TabIndex = 18;
            // 
            // ImageGroupBox
            // 
            this.ImageGroupBox.Controls.Add(this.ImagePictureBox);
            this.ImageGroupBox.Location = new System.Drawing.Point(341, 36);
            this.ImageGroupBox.Name = "ImageGroupBox";
            this.ImageGroupBox.Size = new System.Drawing.Size(322, 347);
            this.ImageGroupBox.TabIndex = 19;
            this.ImageGroupBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 460);
            this.Controls.Add(this.UploadTextButton);
            this.Controls.Add(this.ImageGroupBox);
            this.Controls.Add(this.WordsTextBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.UploadImageButton);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.DecodeButton);
            this.Controls.Add(this.EncodeButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Steganography";
            this.Load += new System.EventHandler(this.Steganography_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImagePictureBox)).EndInit();
            this.ImageGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EncodeButton;
        private System.Windows.Forms.Button DecodeButton;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.PictureBox ImagePictureBox;
        private System.Windows.Forms.Button UploadImageButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button UploadTextButton;
        private System.Windows.Forms.TextBox WordsTextBox;
        private System.Windows.Forms.GroupBox ImageGroupBox;
    }
}

