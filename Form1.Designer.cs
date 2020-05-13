namespace kalori_hesaplama
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.adtxtbox = new System.Windows.Forms.TextBox();
            this.soyadtxtbox = new System.Windows.Forms.TextBox();
            this.yastxtbox = new System.Windows.Forms.TextBox();
            this.hesaplabtn = new System.Windows.Forms.Button();
            this.listbilgiler = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.kilotxtbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.boytxtbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.temizlebtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.proteintxtbox = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.adımtxtbox = new System.Windows.Forms.TextBox();
            this.oguntxtbox = new System.Windows.Forms.TextBox();
            this.sutxtbox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.vucutbilgi = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Yaş:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cinsiyet:";
            // 
            // adtxtbox
            // 
            this.adtxtbox.Location = new System.Drawing.Point(115, 30);
            this.adtxtbox.Name = "adtxtbox";
            this.adtxtbox.Size = new System.Drawing.Size(100, 22);
            this.adtxtbox.TabIndex = 1;
            // 
            // soyadtxtbox
            // 
            this.soyadtxtbox.Location = new System.Drawing.Point(115, 67);
            this.soyadtxtbox.Name = "soyadtxtbox";
            this.soyadtxtbox.Size = new System.Drawing.Size(100, 22);
            this.soyadtxtbox.TabIndex = 2;
            // 
            // yastxtbox
            // 
            this.yastxtbox.Location = new System.Drawing.Point(115, 110);
            this.yastxtbox.Name = "yastxtbox";
            this.yastxtbox.Size = new System.Drawing.Size(100, 22);
            this.yastxtbox.TabIndex = 3;
            // 
            // hesaplabtn
            // 
            this.hesaplabtn.Location = new System.Drawing.Point(21, 216);
            this.hesaplabtn.Name = "hesaplabtn";
            this.hesaplabtn.Size = new System.Drawing.Size(122, 35);
            this.hesaplabtn.TabIndex = 12;
            this.hesaplabtn.Text = "Hesapla";
            this.hesaplabtn.UseVisualStyleBackColor = true;
            this.hesaplabtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // listbilgiler
            // 
            this.listbilgiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listbilgiler.FormattingEnabled = true;
            this.listbilgiler.ItemHeight = 18;
            this.listbilgiler.Items.AddRange(new object[] {
            "Kullanıcı Bilgileri",
            resources.GetString("listbilgiler.Items")});
            this.listbilgiler.Location = new System.Drawing.Point(527, 127);
            this.listbilgiler.Name = "listbilgiler";
            this.listbilgiler.Size = new System.Drawing.Size(809, 202);
            this.listbilgiler.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.kilotxtbox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.boytxtbox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.yastxtbox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.soyadtxtbox);
            this.groupBox1.Controls.Add(this.adtxtbox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 271);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanıcı Bilgileri";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(231, 238);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Kg(Örnek:80 )";
            // 
            // kilotxtbox
            // 
            this.kilotxtbox.Location = new System.Drawing.Point(115, 233);
            this.kilotxtbox.Name = "kilotxtbox";
            this.kilotxtbox.Size = new System.Drawing.Size(100, 22);
            this.kilotxtbox.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(73, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Kilo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(231, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Cm(Örnek:182 )";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(222, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Örnek:35";
            // 
            // boytxtbox
            // 
            this.boytxtbox.Location = new System.Drawing.Point(115, 191);
            this.boytxtbox.Name = "boytxtbox";
            this.boytxtbox.Size = new System.Drawing.Size(100, 22);
            this.boytxtbox.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Boy:";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(177, 152);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(38, 21);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "K";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(116, 150);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(38, 21);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "E";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // temizlebtn
            // 
            this.temizlebtn.Location = new System.Drawing.Point(21, 254);
            this.temizlebtn.Name = "temizlebtn";
            this.temizlebtn.Size = new System.Drawing.Size(122, 35);
            this.temizlebtn.TabIndex = 13;
            this.temizlebtn.Text = "Temizle";
            this.temizlebtn.UseVisualStyleBackColor = true;
            this.temizlebtn.Click += new System.EventHandler(this.temizlebtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(576, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.ForeColor = System.Drawing.Color.Aquamarine;
            this.panel1.Location = new System.Drawing.Point(517, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(712, 100);
            this.panel1.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MV Boli", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(66, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(426, 63);
            this.label10.TabIndex = 12;
            this.label10.Text = "Kalori Hesaplayıcı";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.proteintxtbox);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.temizlebtn);
            this.groupBox2.Controls.Add(this.adımtxtbox);
            this.groupBox2.Controls.Add(this.oguntxtbox);
            this.groupBox2.Controls.Add(this.sutxtbox);
            this.groupBox2.Controls.Add(this.hesaplabtn);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Location = new System.Drawing.Point(12, 290);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(496, 295);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Günlük Faaliyetler";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(295, 216);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 63);
            this.button2.TabIndex = 31;
            this.button2.Text = "Diyet Listesi Ve Egzersizler";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(167, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 35);
            this.button1.TabIndex = 14;
            this.button1.Text = "Çıkış";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(283, 171);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(120, 17);
            this.label17.TabIndex = 30;
            this.label17.Text = "Gram (Örnek: 50)";
            // 
            // proteintxtbox
            // 
            this.proteintxtbox.Location = new System.Drawing.Point(177, 166);
            this.proteintxtbox.Name = "proteintxtbox";
            this.proteintxtbox.Size = new System.Drawing.Size(100, 22);
            this.proteintxtbox.TabIndex = 11;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(8, 169);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(163, 17);
            this.label18.TabIndex = 28;
            this.label18.Text = "Günlük Protein Tüketimi:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(283, 125);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(112, 17);
            this.label16.TabIndex = 27;
            this.label16.Text = "Öğün (Örnek: 3)";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(283, 78);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(128, 17);
            this.label15.TabIndex = 26;
            this.label15.Text = " Adım (Örnek: 200)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(283, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 17);
            this.label11.TabIndex = 25;
            this.label11.Text = "Litre (Örnek: 2 )";
            // 
            // adımtxtbox
            // 
            this.adımtxtbox.Location = new System.Drawing.Point(177, 75);
            this.adımtxtbox.Name = "adımtxtbox";
            this.adımtxtbox.Size = new System.Drawing.Size(100, 22);
            this.adımtxtbox.TabIndex = 9;
            // 
            // oguntxtbox
            // 
            this.oguntxtbox.Location = new System.Drawing.Point(177, 120);
            this.oguntxtbox.Name = "oguntxtbox";
            this.oguntxtbox.Size = new System.Drawing.Size(100, 22);
            this.oguntxtbox.TabIndex = 10;
            // 
            // sutxtbox
            // 
            this.sutxtbox.Location = new System.Drawing.Point(177, 38);
            this.sutxtbox.Name = "sutxtbox";
            this.sutxtbox.Size = new System.Drawing.Size(100, 22);
            this.sutxtbox.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(41, 38);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(130, 17);
            this.label12.TabIndex = 19;
            this.label12.Text = "Günlük Su tüketimi:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(34, 123);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(137, 17);
            this.label14.TabIndex = 21;
            this.label14.Text = "Günlük Öğün Sayısı:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(34, 80);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(133, 17);
            this.label13.TabIndex = 20;
            this.label13.Text = "Günlük Adım Sayısı:";
            // 
            // vucutbilgi
            // 
            this.vucutbilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.vucutbilgi.FormattingEnabled = true;
            this.vucutbilgi.ItemHeight = 18;
            this.vucutbilgi.Items.AddRange(new object[] {
            "Günlük Bilgiler",
            resources.GetString("vucutbilgi.Items")});
            this.vucutbilgi.Location = new System.Drawing.Point(527, 329);
            this.vucutbilgi.Name = "vucutbilgi";
            this.vucutbilgi.Size = new System.Drawing.Size(809, 256);
            this.vucutbilgi.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(1348, 597);
            this.Controls.Add(this.vucutbilgi);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listbilgiler);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Kalori Hesaplayıcı";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox adtxtbox;
        private System.Windows.Forms.TextBox soyadtxtbox;
        private System.Windows.Forms.TextBox yastxtbox;
        public System.Windows.Forms.Button hesaplabtn;
        private System.Windows.Forms.ListBox listbilgiler;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button temizlebtn;
        private System.Windows.Forms.TextBox boytxtbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox kilotxtbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox proteintxtbox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox adımtxtbox;
        private System.Windows.Forms.TextBox oguntxtbox;
        private System.Windows.Forms.TextBox sutxtbox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox vucutbilgi;
        private System.Windows.Forms.Button button2;
    }
}

