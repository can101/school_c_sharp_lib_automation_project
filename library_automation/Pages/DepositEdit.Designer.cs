namespace library_automation.Pages
{
    partial class DepositEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepositEdit));
            this.tbxUserNo = new System.Windows.Forms.NumericUpDown();
            this.dtpbxBackDate = new System.Windows.Forms.DateTimePicker();
            this.tbxBookNo = new System.Windows.Forms.NumericUpDown();
            this.pictureBtnBack = new System.Windows.Forms.PictureBox();
            this.btnGiveDepositBookBtn = new System.Windows.Forms.Button();
            this.rchtbxDepositNote = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.chkbxIsDepositDelivered = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbxUserNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxBookNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBtnBack)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxUserNo
            // 
            this.tbxUserNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbxUserNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(99)))), ((int)(((byte)(255)))));
            this.tbxUserNo.Location = new System.Drawing.Point(76, 56);
            this.tbxUserNo.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.tbxUserNo.Name = "tbxUserNo";
            this.tbxUserNo.Size = new System.Drawing.Size(364, 24);
            this.tbxUserNo.TabIndex = 49;
            // 
            // dtpbxBackDate
            // 
            this.dtpbxBackDate.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(99)))), ((int)(((byte)(255)))));
            this.dtpbxBackDate.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(99)))), ((int)(((byte)(255)))));
            this.dtpbxBackDate.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(99)))), ((int)(((byte)(255)))));
            this.dtpbxBackDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dtpbxBackDate.Location = new System.Drawing.Point(76, 119);
            this.dtpbxBackDate.Name = "dtpbxBackDate";
            this.dtpbxBackDate.Size = new System.Drawing.Size(600, 24);
            this.dtpbxBackDate.TabIndex = 48;
            // 
            // tbxBookNo
            // 
            this.tbxBookNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbxBookNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(99)))), ((int)(((byte)(255)))));
            this.tbxBookNo.Location = new System.Drawing.Point(477, 56);
            this.tbxBookNo.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.tbxBookNo.Name = "tbxBookNo";
            this.tbxBookNo.Size = new System.Drawing.Size(379, 24);
            this.tbxBookNo.TabIndex = 47;
            // 
            // pictureBtnBack
            // 
            this.pictureBtnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBtnBack.Image = ((System.Drawing.Image)(resources.GetObject("pictureBtnBack.Image")));
            this.pictureBtnBack.Location = new System.Drawing.Point(-7, 114);
            this.pictureBtnBack.Name = "pictureBtnBack";
            this.pictureBtnBack.Size = new System.Drawing.Size(63, 103);
            this.pictureBtnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBtnBack.TabIndex = 46;
            this.pictureBtnBack.TabStop = false;
            this.pictureBtnBack.Click += new System.EventHandler(this.pictureBtnBack_Click);
            // 
            // btnGiveDepositBookBtn
            // 
            this.btnGiveDepositBookBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(99)))), ((int)(((byte)(255)))));
            this.btnGiveDepositBookBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGiveDepositBookBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGiveDepositBookBtn.FlatAppearance.BorderSize = 0;
            this.btnGiveDepositBookBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnGiveDepositBookBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnGiveDepositBookBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiveDepositBookBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiveDepositBookBtn.ForeColor = System.Drawing.Color.Transparent;
            this.btnGiveDepositBookBtn.Location = new System.Drawing.Point(76, 271);
            this.btnGiveDepositBookBtn.Name = "btnGiveDepositBookBtn";
            this.btnGiveDepositBookBtn.Size = new System.Drawing.Size(785, 31);
            this.btnGiveDepositBookBtn.TabIndex = 45;
            this.btnGiveDepositBookBtn.TabStop = false;
            this.btnGiveDepositBookBtn.Text = "Emanet Kitabı Güncelle";
            this.btnGiveDepositBookBtn.UseVisualStyleBackColor = false;
            this.btnGiveDepositBookBtn.Click += new System.EventHandler(this.btnGiveDepositBookBtn_Click);
            // 
            // rchtbxDepositNote
            // 
            this.rchtbxDepositNote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rchtbxDepositNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.rchtbxDepositNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(99)))), ((int)(((byte)(255)))));
            this.rchtbxDepositNote.Location = new System.Drawing.Point(76, 182);
            this.rchtbxDepositNote.Name = "rchtbxDepositNote";
            this.rchtbxDepositNote.Size = new System.Drawing.Size(785, 77);
            this.rchtbxDepositNote.TabIndex = 44;
            this.rchtbxDepositNote.TabStop = false;
            this.rchtbxDepositNote.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(86)))));
            this.label10.Location = new System.Drawing.Point(72, 150);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 23);
            this.label10.TabIndex = 43;
            this.label10.Text = "Emanet Not";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(86)))));
            this.label15.Location = new System.Drawing.Point(72, 88);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(164, 23);
            this.label15.TabIndex = 42;
            this.label15.Text = "Emanet Teslim Tarihi";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(86)))));
            this.label16.Location = new System.Drawing.Point(473, 24);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 23);
            this.label16.TabIndex = 41;
            this.label16.Text = "Kitap No";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(86)))));
            this.label17.Location = new System.Drawing.Point(72, 24);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(67, 23);
            this.label17.TabIndex = 40;
            this.label17.Text = "Üye No";
            // 
            // chkbxIsDepositDelivered
            // 
            this.chkbxIsDepositDelivered.AutoSize = true;
            this.chkbxIsDepositDelivered.Location = new System.Drawing.Point(710, 123);
            this.chkbxIsDepositDelivered.Name = "chkbxIsDepositDelivered";
            this.chkbxIsDepositDelivered.Size = new System.Drawing.Size(151, 20);
            this.chkbxIsDepositDelivered.TabIndex = 50;
            this.chkbxIsDepositDelivered.Text = "Is Deposit Delivered";
            this.chkbxIsDepositDelivered.UseVisualStyleBackColor = true;
            // 
            // DepositEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 336);
            this.Controls.Add(this.chkbxIsDepositDelivered);
            this.Controls.Add(this.tbxUserNo);
            this.Controls.Add(this.dtpbxBackDate);
            this.Controls.Add(this.tbxBookNo);
            this.Controls.Add(this.pictureBtnBack);
            this.Controls.Add(this.btnGiveDepositBookBtn);
            this.Controls.Add(this.rchtbxDepositNote);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Name = "DepositEdit";
            this.Text = "DepositEdit";
            this.Load += new System.EventHandler(this.DepositEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbxUserNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxBookNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBtnBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown tbxUserNo;
        private System.Windows.Forms.DateTimePicker dtpbxBackDate;
        private System.Windows.Forms.NumericUpDown tbxBookNo;
        private System.Windows.Forms.PictureBox pictureBtnBack;
        private System.Windows.Forms.Button btnGiveDepositBookBtn;
        private System.Windows.Forms.RichTextBox rchtbxDepositNote;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.CheckBox chkbxIsDepositDelivered;
    }
}