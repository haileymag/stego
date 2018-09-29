namespace steganography
{
    partial class Steganography
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
            this.encode = new System.Windows.Forms.Button();
            this.decode = new System.Windows.Forms.Button();
            this.checkencrypt = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordbox = new System.Windows.Forms.TextBox();
            this.Text = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imageretreival = new System.Windows.Forms.Label();
            this.uploadimage = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // encode
            // 
            this.encode.Location = new System.Drawing.Point(407, 270);
            this.encode.Name = "encode";
            this.encode.Size = new System.Drawing.Size(122, 40);
            this.encode.TabIndex = 0;
            this.encode.Text = "ENCODE";
            this.encode.UseVisualStyleBackColor = true;
            this.encode.Click += new System.EventHandler(this.button1_Click);
            // 
            // decode
            // 
            this.decode.Location = new System.Drawing.Point(591, 272);
            this.decode.Name = "decode";
            this.decode.Size = new System.Drawing.Size(122, 40);
            this.decode.TabIndex = 1;
            this.decode.Text = "DECODE";
            this.decode.UseVisualStyleBackColor = true;
            // 
            // checkencrypt
            // 
            this.checkencrypt.AutoSize = true;
            this.checkencrypt.Location = new System.Drawing.Point(12, 305);
            this.checkencrypt.Name = "checkencrypt";
            this.checkencrypt.Size = new System.Drawing.Size(54, 21);
            this.checkencrypt.TabIndex = 2;
            this.checkencrypt.Text = "Yes";
            this.checkencrypt.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Encrypt? (Click box if yes and create password)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // passwordbox
            // 
            this.passwordbox.Location = new System.Drawing.Point(224, 304);
            this.passwordbox.Name = "passwordbox";
            this.passwordbox.Size = new System.Drawing.Size(139, 22);
            this.passwordbox.TabIndex = 5;
            this.passwordbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // Text
            // 
            this.Text.FormattingEnabled = true;
            this.Text.ItemHeight = 16;
            this.Text.Location = new System.Drawing.Point(12, 144);
            this.Text.Name = "Text";
            this.Text.Size = new System.Drawing.Size(323, 132);
            this.Text.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(407, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(306, 221);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // imageretreival
            // 
            this.imageretreival.AutoSize = true;
            this.imageretreival.Location = new System.Drawing.Point(404, 23);
            this.imageretreival.Name = "imageretreival";
            this.imageretreival.Size = new System.Drawing.Size(50, 17);
            this.imageretreival.TabIndex = 8;
            this.imageretreival.Text = "Image:";
            this.imageretreival.Click += new System.EventHandler(this.imageretreival_Click);
            // 
            // uploadimage
            // 
            this.uploadimage.Location = new System.Drawing.Point(71, 96);
            this.uploadimage.Name = "uploadimage";
            this.uploadimage.Size = new System.Drawing.Size(209, 31);
            this.uploadimage.TabIndex = 9;
            this.uploadimage.Text = "Upload Image";
            this.uploadimage.UseVisualStyleBackColor = true;
            this.uploadimage.Click += new System.EventHandler(this.uploadimage_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-287, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(366, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Please upload image desired to be encoded or decoded.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(351, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "After uploading, if you choose to decode, hit \"decode\".";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(355, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "For encoding, please type in your desired text, encrypt ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(268, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "via password if desired, and hit \"encode\".";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(380, 326);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Save encoded image?";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(535, 323);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 16;
            this.save.Text = "YES";
            this.save.UseVisualStyleBackColor = true;
            // 
            // Steganography
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 358);
            this.Controls.Add(this.save);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uploadimage);
            this.Controls.Add(this.imageretreival);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Text);
            this.Controls.Add(this.passwordbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkencrypt);
            this.Controls.Add(this.decode);
            this.Controls.Add(this.encode);
            this.Name = "Steganography";
            this.Text = "Steganography Encoder/Decoder";
            this.Load += new System.EventHandler(this.Steganography_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button encode;
        private System.Windows.Forms.Button decode;
        private System.Windows.Forms.CheckBox checkencrypt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwordbox;
        private System.Windows.Forms.ListBox Text;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label imageretreival;
        private System.Windows.Forms.Button uploadimage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button save;
    }
}

