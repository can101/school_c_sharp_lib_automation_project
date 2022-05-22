namespace library_automation
{
    partial class AddBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBook));
            this.btnBookAdd = new System.Windows.Forms.Button();
            this.tbxBookAbstract = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxPrintHouse = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxBookAuthor = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxBookName = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBtnBack = new System.Windows.Forms.PictureBox();
            this.cbxBookLangugae = new System.Windows.Forms.ComboBox();
            this.tbxBookSheetCount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.pbxUploadImage = new System.Windows.Forms.PictureBox();
            this.tbxPrintYear = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBtnBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxBookSheetCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUploadImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxPrintYear)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBookAdd
            // 
            this.btnBookAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(99)))), ((int)(((byte)(255)))));
            this.btnBookAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBookAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBookAdd.FlatAppearance.BorderSize = 0;
            this.btnBookAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnBookAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnBookAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookAdd.ForeColor = System.Drawing.Color.Transparent;
            this.btnBookAdd.Location = new System.Drawing.Point(108, 304);
            this.btnBookAdd.Name = "btnBookAdd";
            this.btnBookAdd.Size = new System.Drawing.Size(787, 31);
            this.btnBookAdd.TabIndex = 31;
            this.btnBookAdd.TabStop = false;
            this.btnBookAdd.Text = "Kitap Ekle";
            this.btnBookAdd.UseVisualStyleBackColor = false;
            this.btnBookAdd.Click += new System.EventHandler(this.addBookBtn_Click);
            // 
            // tbxBookAbstract
            // 
            this.tbxBookAbstract.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxBookAbstract.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxBookAbstract.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(99)))), ((int)(((byte)(255)))));
            this.tbxBookAbstract.Location = new System.Drawing.Point(108, 219);
            this.tbxBookAbstract.Name = "tbxBookAbstract";
            this.tbxBookAbstract.Size = new System.Drawing.Size(787, 71);
            this.tbxBookAbstract.TabIndex = 30;
            this.tbxBookAbstract.TabStop = false;
            this.tbxBookAbstract.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(86)))));
            this.label7.Location = new System.Drawing.Point(104, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 23);
            this.label7.TabIndex = 29;
            this.label7.Text = "Açıklama";
            // 
            // tbxPrintHouse
            // 
            this.tbxPrintHouse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxPrintHouse.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPrintHouse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(99)))), ((int)(((byte)(255)))));
            this.tbxPrintHouse.Location = new System.Drawing.Point(107, 96);
            this.tbxPrintHouse.Multiline = false;
            this.tbxPrintHouse.Name = "tbxPrintHouse";
            this.tbxPrintHouse.Size = new System.Drawing.Size(300, 25);
            this.tbxPrintHouse.TabIndex = 28;
            this.tbxPrintHouse.TabStop = false;
            this.tbxPrintHouse.Text = "";
            this.tbxPrintHouse.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPrintHouse_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(86)))));
            this.label4.Location = new System.Drawing.Point(103, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 23);
            this.label4.TabIndex = 27;
            this.label4.Text = "Yayın Evi Adı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(86)))));
            this.label5.Location = new System.Drawing.Point(104, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 23);
            this.label5.TabIndex = 25;
            this.label5.Text = "Kitabın Dili";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(86)))));
            this.label6.Location = new System.Drawing.Point(429, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 23);
            this.label6.TabIndex = 23;
            this.label6.Text = "Sayfa Sayısı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(86)))));
            this.label3.Location = new System.Drawing.Point(429, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 23);
            this.label3.TabIndex = 21;
            this.label3.Text = "Baskı Yılı";
            // 
            // tbxBookAuthor
            // 
            this.tbxBookAuthor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxBookAuthor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxBookAuthor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(99)))), ((int)(((byte)(255)))));
            this.tbxBookAuthor.Location = new System.Drawing.Point(433, 32);
            this.tbxBookAuthor.Multiline = false;
            this.tbxBookAuthor.Name = "tbxBookAuthor";
            this.tbxBookAuthor.Size = new System.Drawing.Size(300, 25);
            this.tbxBookAuthor.TabIndex = 20;
            this.tbxBookAuthor.TabStop = false;
            this.tbxBookAuthor.Text = "";
            this.tbxBookAuthor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxBookAuthor_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(86)))));
            this.label2.Location = new System.Drawing.Point(429, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 23);
            this.label2.TabIndex = 19;
            this.label2.Text = "Kitabın Yazarı";
            // 
            // tbxBookName
            // 
            this.tbxBookName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxBookName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tbxBookName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(99)))), ((int)(((byte)(255)))));
            this.tbxBookName.Location = new System.Drawing.Point(107, 32);
            this.tbxBookName.Margin = new System.Windows.Forms.Padding(0);
            this.tbxBookName.Multiline = false;
            this.tbxBookName.Name = "tbxBookName";
            this.tbxBookName.Size = new System.Drawing.Size(300, 25);
            this.tbxBookName.TabIndex = 18;
            this.tbxBookName.TabStop = false;
            this.tbxBookName.Text = "";
            this.tbxBookName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxBookName_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(86)))));
            this.label8.Location = new System.Drawing.Point(103, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 23);
            this.label8.TabIndex = 17;
            this.label8.Text = "Kitabın Adı";
            // 
            // pictureBtnBack
            // 
            this.pictureBtnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBtnBack.Image = ((System.Drawing.Image)(resources.GetObject("pictureBtnBack.Image")));
            this.pictureBtnBack.Location = new System.Drawing.Point(-9, 123);
            this.pictureBtnBack.Name = "pictureBtnBack";
            this.pictureBtnBack.Size = new System.Drawing.Size(63, 103);
            this.pictureBtnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBtnBack.TabIndex = 34;
            this.pictureBtnBack.TabStop = false;
            this.pictureBtnBack.Click += new System.EventHandler(this.pictureBtnBack_Click_1);
            // 
            // cbxBookLangugae
            // 
            this.cbxBookLangugae.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cbxBookLangugae.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(99)))), ((int)(((byte)(255)))));
            this.cbxBookLangugae.FormattingEnabled = true;
            this.cbxBookLangugae.IntegralHeight = false;
            this.cbxBookLangugae.Items.AddRange(new object[] {
            "af\\Afrikaans",
            "sq\\Albanian-shqip",
            "am\\Amharic-አማርኛ",
            "ar\\Arabic-العربية",
            "an\\Aragonese-aragonés",
            "hy\\Armenian-հայերեն",
            "ast\\Asturian-asturianu",
            "az\\Azerbaijani-azərbaycan dili",
            "eu\\Basque-euskara",
            "be\\Belarusian-беларуская",
            "bn\\Bengali-বাংলা",
            "bs\\Bosnian-bosanski",
            "br\\Breton-brezhoneg",
            "bg\\Bulgarian-български",
            "ca\\Catalan-català",
            "ckb\\Central Kurdish-کوردی (دەستنوسی عەرەبی)",
            "zh\\Chinese-中文",
            "zh-HK\\Chinese (Hong Kong)-中文（香港）",
            "zh-CN\\Chinese (Simplified)-中文（简体）",
            "zh-TW\\Chinese (Traditional)-中文（繁體）",
            "co\\Corsican",
            "hr\\Croatian-hrvatski",
            "cs\\Czech-čeština",
            "da\\Danish-dansk",
            "nl\\Dutch-Nederlands",
            "en\\English",
            "en-AU\\English (Australia)",
            "en-CA\\English (Canada)",
            "en-IN\\English (India)",
            "en-NZ\\English (New Zealand)",
            "en-ZA\\English (South Africa)",
            "en-GB\\English (United Kingdom)",
            "en-US\\English (United States)",
            "eo\\Esperanto-esperanto",
            "et\\Estonian-eesti",
            "fo\\Faroese-føroyskt",
            "fil\\Filipino",
            "fi\\Finnish-suomi",
            "fr\\French-français",
            "fr-CA\\French (Canada)-français (Canada)",
            "fr-FR\\French (France)-français (France)",
            "fr-CH\\French (Switzerland)-français (Suisse)",
            "gl\\Galician-galego",
            "ka\\Georgian-ქართული",
            "de\\German-Deutsch",
            "de-AT\\German (Austria)-Deutsch (Österreich)",
            "de-DE\\German (Germany)-Deutsch (Deutschland)",
            "de-LI\\German (Liechtenstein)-Deutsch (Liechtenstein)",
            "de-CH\\German (Switzerland)-Deutsch (Schweiz)",
            "el\\Greek-Ελληνικά",
            "gn\\Guarani",
            "gu\\Gujarati-ગુજરાતી",
            "ha\\Hausa",
            "haw\\Hawaiian-ʻŌlelo Hawaiʻi",
            "he\\Hebrew-עברית",
            "hi\\Hindi-हिन्दी",
            "hu\\Hungarian-magyar",
            "is\\Icelandic-íslenska",
            "id\\Indonesian-Indonesia",
            "ia\\Interlingua",
            "ga\\Irish-Gaeilge",
            "it\\Italian-italiano",
            "it-IT\\Italian (Italy)-italiano (Italia)",
            "it-CH\\Italian (Switzerland)-italiano (Svizzera)",
            "ja\\Japanese-日本語",
            "kn\\Kannada-ಕನ್ನಡ",
            "kk\\Kazakh-қазақ тілі",
            "km\\Khmer-ខ្មែរ",
            "ko\\Korean-한국어",
            "ku\\Kurdish-Kurdî",
            "ky\\Kyrgyz-кыргызча",
            "lo\\Lao-ລາວ",
            "la\\Latin",
            "lv\\Latvian-latviešu",
            "ln\\Lingala-lingála",
            "lt\\Lithuanian-lietuvių",
            "mk\\Macedonian-македонски",
            "ms\\Malay-Bahasa Melayu",
            "ml\\Malayalam-മലയാളം",
            "mt\\Maltese-Malti",
            "mr\\Marathi-मराठी",
            "mn\\Mongolian-монгол",
            "ne\\Nepali-नेपाली",
            "no\\Norwegian-norsk",
            "nb\\Norwegian Bokmål-norsk bokmål",
            "nn\\Norwegian Nynorsk-nynorsk",
            "oc\\Occitan",
            "or\\Oriya-ଓଡ଼ିଆ",
            "om\\Oromo-Oromoo",
            "ps\\Pashto-پښتو",
            "fa\\Persian-فارسی",
            "pl\\Polish-polski",
            "pt\\Portuguese-português",
            "pt-BR\\Portuguese (Brazil)-português (Brasil)",
            "pt-PT\\Portuguese (Portugal)-português (Portugal)",
            "pa\\Punjabi-ਪੰਜਾਬੀ",
            "qu\\Quechua",
            "ro\\Romanian-română",
            "mo\\Romanian (Moldova)-română (Moldova)",
            "rm\\Romansh-rumantsch",
            "ru\\Russian-русский",
            "gd\\Scottish Gaelic",
            "sr\\Serbian-српски",
            "sh\\Serbo-Croatian",
            "sn\\Shona-chiShona",
            "sd\\Sindhi",
            "si\\Sinhala-සිංහල",
            "sk\\Slovak-slovenčina",
            "sl\\Slovenian-slovenščina",
            "so\\Somali-Soomaali",
            "st\\Southern Sotho",
            "es\\Spanish-español",
            "es-AR\\Spanish (Argentina)-español (Argentina)",
            "es-419\\Spanish (Latin America)-español (Latinoamérica)",
            "es-MX\\Spanish (Mexico)-español (México)",
            "es-ES\\Spanish (Spain)-español (España)",
            "es-US\\Spanish (United States)-español (Estados Unidos)",
            "su\\Sundanese",
            "sw\\Swahili-Kiswahili",
            "sv\\Swedish-svenska",
            "tg\\Tajik-тоҷикӣ",
            "ta\\Tamil-தமிழ்",
            "tt\\Tatar",
            "te\\Telugu-తెలుగు",
            " th\\Thai-ไทย",
            " ti\\Tigrinya-ትግርኛ",
            " to\\Tongan-lea fakatonga",
            " tr\\Turkish-Türkçe",
            " tk\\Turkmen",
            " tw\\Twi",
            " uk\\Ukrainian-українська",
            " ur\\Urdu-اردو",
            " ug\\Uyghur",
            " uz\\Uzbek-o‘zbek",
            " vi\\Vietnamese-Tiếng Việt",
            " wa\\Walloon-wa",
            " cy\\Welsh-Cymraeg",
            " fy\\Western Frisian",
            " xh\\Xhosa",
            " yi\\Yiddish",
            " yo\\Yoruba-Èdè Yorùbá",
            " zu\\Zulu-isiZulu"});
            this.cbxBookLangugae.Location = new System.Drawing.Point(107, 161);
            this.cbxBookLangugae.Name = "cbxBookLangugae";
            this.cbxBookLangugae.Size = new System.Drawing.Size(300, 24);
            this.cbxBookLangugae.TabIndex = 35;
            // 
            // tbxBookSheetCount
            // 
            this.tbxBookSheetCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(99)))), ((int)(((byte)(255)))));
            this.tbxBookSheetCount.Location = new System.Drawing.Point(433, 99);
            this.tbxBookSheetCount.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.tbxBookSheetCount.Name = "tbxBookSheetCount";
            this.tbxBookSheetCount.Size = new System.Drawing.Size(300, 22);
            this.tbxBookSheetCount.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(86)))));
            this.label1.Location = new System.Drawing.Point(755, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 23);
            this.label1.TabIndex = 38;
            this.label1.Text = "Kitap Fotoğraf";
            // 
            // pbxUploadImage
            // 
            this.pbxUploadImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxUploadImage.Image = ((System.Drawing.Image)(resources.GetObject("pbxUploadImage.Image")));
            this.pbxUploadImage.Location = new System.Drawing.Point(759, 35);
            this.pbxUploadImage.Name = "pbxUploadImage";
            this.pbxUploadImage.Size = new System.Drawing.Size(136, 153);
            this.pbxUploadImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxUploadImage.TabIndex = 39;
            this.pbxUploadImage.TabStop = false;
            this.pbxUploadImage.Click += new System.EventHandler(this.pbxUploadImage_Click);
            // 
            // tbxPrintYear
            // 
            this.tbxPrintYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(99)))), ((int)(((byte)(255)))));
            this.tbxPrintYear.Location = new System.Drawing.Point(433, 161);
            this.tbxPrintYear.Maximum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.tbxPrintYear.Name = "tbxPrintYear";
            this.tbxPrintYear.Size = new System.Drawing.Size(300, 22);
            this.tbxPrintYear.TabIndex = 55;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(86)))));
            this.label9.Location = new System.Drawing.Point(771, 186);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 19);
            this.label9.TabIndex = 60;
            this.label9.Text = "{ png , jpeg , gif }";
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 336);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbxPrintYear);
            this.Controls.Add(this.pbxUploadImage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxBookSheetCount);
            this.Controls.Add(this.cbxBookLangugae);
            this.Controls.Add(this.pictureBtnBack);
            this.Controls.Add(this.btnBookAdd);
            this.Controls.Add(this.tbxBookAbstract);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbxPrintHouse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxBookAuthor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxBookName);
            this.Controls.Add(this.label8);
            this.Name = "AddBook";
            this.Text = "AddBook";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBtnBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxBookSheetCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUploadImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxPrintYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBookAdd;
        private System.Windows.Forms.RichTextBox tbxBookAbstract;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox tbxPrintHouse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox tbxBookAuthor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox tbxBookName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBtnBack;
        private System.Windows.Forms.ComboBox cbxBookLangugae;
        private System.Windows.Forms.NumericUpDown tbxBookSheetCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbxUploadImage;
        private System.Windows.Forms.NumericUpDown tbxPrintYear;
        private System.Windows.Forms.Label label9;
    }
}