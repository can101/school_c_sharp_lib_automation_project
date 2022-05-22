namespace library_automation.Pages
{
    partial class UserEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserEdit));
            this.pictureBtnBack = new System.Windows.Forms.PictureBox();
            this.userUpdateBtn = new System.Windows.Forms.Button();
            this.tbxUserAdress = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxUserMail = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbxUserSurname = new System.Windows.Forms.RichTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbxUserName = new System.Windows.Forms.RichTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.pbxUploadImage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxUserPhoneNo = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBtnBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUploadImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBtnBack
            // 
            this.pictureBtnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBtnBack.Image = ((System.Drawing.Image)(resources.GetObject("pictureBtnBack.Image")));
            this.pictureBtnBack.Location = new System.Drawing.Point(-9, 113);
            this.pictureBtnBack.Name = "pictureBtnBack";
            this.pictureBtnBack.Size = new System.Drawing.Size(63, 103);
            this.pictureBtnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBtnBack.TabIndex = 60;
            this.pictureBtnBack.TabStop = false;
            this.pictureBtnBack.Click += new System.EventHandler(this.pictureBtnBack_Click);
            // 
            // userUpdateBtn
            // 
            this.userUpdateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(99)))), ((int)(((byte)(255)))));
            this.userUpdateBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.userUpdateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userUpdateBtn.FlatAppearance.BorderSize = 0;
            this.userUpdateBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.userUpdateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.userUpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userUpdateBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userUpdateBtn.ForeColor = System.Drawing.Color.Transparent;
            this.userUpdateBtn.Location = new System.Drawing.Point(79, 290);
            this.userUpdateBtn.Name = "userUpdateBtn";
            this.userUpdateBtn.Size = new System.Drawing.Size(812, 31);
            this.userUpdateBtn.TabIndex = 59;
            this.userUpdateBtn.TabStop = false;
            this.userUpdateBtn.Text = "Üye Güncelle";
            this.userUpdateBtn.UseVisualStyleBackColor = false;
            this.userUpdateBtn.Click += new System.EventHandler(this.userUpdateBtn_Click);
            // 
            // tbxUserAdress
            // 
            this.tbxUserAdress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxUserAdress.Location = new System.Drawing.Point(79, 206);
            this.tbxUserAdress.Name = "tbxUserAdress";
            this.tbxUserAdress.Size = new System.Drawing.Size(636, 50);
            this.tbxUserAdress.TabIndex = 58;
            this.tbxUserAdress.TabStop = false;
            this.tbxUserAdress.Text = "";
            this.tbxUserAdress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxUserAdress_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(86)))));
            this.label9.Location = new System.Drawing.Point(75, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 23);
            this.label9.TabIndex = 57;
            this.label9.Text = "Açık Adres";
            // 
            // tbxUserMail
            // 
            this.tbxUserMail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxUserMail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUserMail.Location = new System.Drawing.Point(415, 138);
            this.tbxUserMail.Multiline = false;
            this.tbxUserMail.Name = "tbxUserMail";
            this.tbxUserMail.Size = new System.Drawing.Size(300, 25);
            this.tbxUserMail.TabIndex = 56;
            this.tbxUserMail.TabStop = false;
            this.tbxUserMail.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(86)))));
            this.label11.Location = new System.Drawing.Point(411, 107);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 23);
            this.label11.TabIndex = 55;
            this.label11.Text = "E-Posta Adresi";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(86)))));
            this.label12.Location = new System.Drawing.Point(75, 107);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(142, 23);
            this.label12.TabIndex = 53;
            this.label12.Text = "Telefon Numarası";
            // 
            // tbxUserSurname
            // 
            this.tbxUserSurname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxUserSurname.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUserSurname.Location = new System.Drawing.Point(415, 66);
            this.tbxUserSurname.Multiline = false;
            this.tbxUserSurname.Name = "tbxUserSurname";
            this.tbxUserSurname.Size = new System.Drawing.Size(300, 25);
            this.tbxUserSurname.TabIndex = 52;
            this.tbxUserSurname.TabStop = false;
            this.tbxUserSurname.Text = "";
            this.tbxUserSurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxUserSurname_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(86)))));
            this.label13.Location = new System.Drawing.Point(411, 35);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 23);
            this.label13.TabIndex = 51;
            this.label13.Text = "Soyadı";
            // 
            // tbxUserName
            // 
            this.tbxUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxUserName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUserName.Location = new System.Drawing.Point(79, 66);
            this.tbxUserName.Multiline = false;
            this.tbxUserName.Name = "tbxUserName";
            this.tbxUserName.Size = new System.Drawing.Size(300, 25);
            this.tbxUserName.TabIndex = 50;
            this.tbxUserName.TabStop = false;
            this.tbxUserName.Text = "";
            this.tbxUserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxUserName_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(86)))));
            this.label14.Location = new System.Drawing.Point(75, 35);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 23);
            this.label14.TabIndex = 49;
            this.label14.Text = "Adı";
            // 
            // pbxUploadImage
            // 
            this.pbxUploadImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxUploadImage.Enabled = false;
            this.pbxUploadImage.Image = ((System.Drawing.Image)(resources.GetObject("pbxUploadImage.Image")));
            this.pbxUploadImage.Location = new System.Drawing.Point(730, 66);
            this.pbxUploadImage.Name = "pbxUploadImage";
            this.pbxUploadImage.Size = new System.Drawing.Size(164, 190);
            this.pbxUploadImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxUploadImage.TabIndex = 62;
            this.pbxUploadImage.TabStop = false;
            this.pbxUploadImage.Click += new System.EventHandler(this.pbxUploadImage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(86)))));
            this.label1.Location = new System.Drawing.Point(726, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 23);
            this.label1.TabIndex = 61;
            this.label1.Text = "Kullanıcı Fotoğraf";
            // 
            // tbxUserPhoneNo
            // 
            this.tbxUserPhoneNo.Location = new System.Drawing.Point(79, 141);
            this.tbxUserPhoneNo.Mask = "(999) 000-0000";
            this.tbxUserPhoneNo.Name = "tbxUserPhoneNo";
            this.tbxUserPhoneNo.Size = new System.Drawing.Size(300, 22);
            this.tbxUserPhoneNo.TabIndex = 63;
            // 
            // UserEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 336);
            this.Controls.Add(this.tbxUserPhoneNo);
            this.Controls.Add(this.pbxUploadImage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBtnBack);
            this.Controls.Add(this.userUpdateBtn);
            this.Controls.Add(this.tbxUserAdress);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbxUserMail);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbxUserSurname);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tbxUserName);
            this.Controls.Add(this.label14);
            this.Name = "UserEdit";
            this.Text = "UserEdit";
            this.Load += new System.EventHandler(this.UserEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBtnBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUploadImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBtnBack;
        private System.Windows.Forms.Button userUpdateBtn;
        private System.Windows.Forms.RichTextBox tbxUserAdress;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox tbxUserMail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox tbxUserSurname;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RichTextBox tbxUserName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pbxUploadImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox tbxUserPhoneNo;
    }
}