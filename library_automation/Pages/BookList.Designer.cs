namespace library_automation
{
    partial class BookList
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookList));
            this.dataGridViewBookList = new System.Windows.Forms.DataGridView();
            this.pictureBtnBack = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.pbxEditBtn = new System.Windows.Forms.PictureBox();
            this.pbxDelBtn = new System.Windows.Forms.PictureBox();
            this.pbxCancelBtn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBtnBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEditBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDelBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCancelBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBookList
            // 
            this.dataGridViewBookList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBookList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridViewBookList.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewBookList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewBookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBookList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dataGridViewBookList.Location = new System.Drawing.Point(62, 1);
            this.dataGridViewBookList.MultiSelect = false;
            this.dataGridViewBookList.Name = "dataGridViewBookList";
            this.dataGridViewBookList.ReadOnly = true;
            this.dataGridViewBookList.RowHeadersWidth = 51;
            this.dataGridViewBookList.RowTemplate.Height = 24;
            this.dataGridViewBookList.Size = new System.Drawing.Size(841, 337);
            this.dataGridViewBookList.TabIndex = 1;
            this.dataGridViewBookList.TabStop = false;
            this.dataGridViewBookList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBookList_CellDoubleClick);
            // 
            // pictureBtnBack
            // 
            this.pictureBtnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBtnBack.Image = ((System.Drawing.Image)(resources.GetObject("pictureBtnBack.Image")));
            this.pictureBtnBack.Location = new System.Drawing.Point(-7, 127);
            this.pictureBtnBack.Name = "pictureBtnBack";
            this.pictureBtnBack.Size = new System.Drawing.Size(63, 103);
            this.pictureBtnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBtnBack.TabIndex = 35;
            this.pictureBtnBack.TabStop = false;
            this.pictureBtnBack.Click += new System.EventHandler(this.pictureBtnBack_Click_1);
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(211, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(493, 343);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Controls.Add(this.pbxEditBtn);
            this.flowLayoutPanel.Controls.Add(this.pbxDelBtn);
            this.flowLayoutPanel.Controls.Add(this.pbxCancelBtn);
            this.flowLayoutPanel.Location = new System.Drawing.Point(-1, 0);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(34, 119);
            this.flowLayoutPanel.TabIndex = 46;
            this.flowLayoutPanel.Visible = false;
            // 
            // pbxEditBtn
            // 
            this.pbxEditBtn.Image = ((System.Drawing.Image)(resources.GetObject("pbxEditBtn.Image")));
            this.pbxEditBtn.Location = new System.Drawing.Point(3, 3);
            this.pbxEditBtn.Name = "pbxEditBtn";
            this.pbxEditBtn.Size = new System.Drawing.Size(26, 38);
            this.pbxEditBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxEditBtn.TabIndex = 42;
            this.pbxEditBtn.TabStop = false;
            this.pbxEditBtn.Click += new System.EventHandler(this.pbxEditBtn_Click);
            // 
            // pbxDelBtn
            // 
            this.pbxDelBtn.Image = ((System.Drawing.Image)(resources.GetObject("pbxDelBtn.Image")));
            this.pbxDelBtn.Location = new System.Drawing.Point(3, 47);
            this.pbxDelBtn.Name = "pbxDelBtn";
            this.pbxDelBtn.Size = new System.Drawing.Size(26, 38);
            this.pbxDelBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxDelBtn.TabIndex = 41;
            this.pbxDelBtn.TabStop = false;
            this.pbxDelBtn.Click += new System.EventHandler(this.pbxDelBtn_Click);
            // 
            // pbxCancelBtn
            // 
            this.pbxCancelBtn.Image = ((System.Drawing.Image)(resources.GetObject("pbxCancelBtn.Image")));
            this.pbxCancelBtn.Location = new System.Drawing.Point(3, 91);
            this.pbxCancelBtn.Name = "pbxCancelBtn";
            this.pbxCancelBtn.Size = new System.Drawing.Size(26, 23);
            this.pbxCancelBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxCancelBtn.TabIndex = 43;
            this.pbxCancelBtn.TabStop = false;
            this.pbxCancelBtn.Click += new System.EventHandler(this.pbxCancelBtn_Click);
            // 
            // BookList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 336);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBtnBack);
            this.Controls.Add(this.dataGridViewBookList);
            this.Name = "BookList";
            this.Text = "BookList";
            this.Load += new System.EventHandler(this.BookList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBtnBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxEditBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDelBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCancelBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBookList;
        private System.Windows.Forms.PictureBox pictureBtnBack;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.PictureBox pbxEditBtn;
        private System.Windows.Forms.PictureBox pbxDelBtn;
        private System.Windows.Forms.PictureBox pbxCancelBtn;
    }
}