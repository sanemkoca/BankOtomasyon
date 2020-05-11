namespace BankOtomasyon
{
    partial class frmPersonel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPersonel));
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tpMusteriEkle = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.sbtnGeri = new DevExpress.XtraEditors.SimpleButton();
            this.grpMusteriBilgileri = new System.Windows.Forms.GroupBox();
            this.rbTicariMusteri = new System.Windows.Forms.RadioButton();
            this.rbBireyselMusteri = new System.Windows.Forms.RadioButton();
            this.dtKayitTarihi = new System.Windows.Forms.DateTimePicker();
            this.sbtnMusteriEkle = new DevExpress.XtraEditors.SimpleButton();
            this.lblKullanici = new System.Windows.Forms.Label();
            this.txtMusteriSifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMusteriNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMusteriSoyad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMusteriAdi = new System.Windows.Forms.TextBox();
            this.tpHesapAc = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sbtnHesapAc = new DevExpress.XtraEditors.SimpleButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEkBakiye = new System.Windows.Forms.TextBox();
            this.txtMusteriHesapAcNo = new System.Windows.Forms.TextBox();
            this.sbtnGeri2 = new DevExpress.XtraEditors.SimpleButton();
            this.tpHesapSil = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.grpHesapSil = new System.Windows.Forms.GroupBox();
            this.txtMusteriHesapSil = new System.Windows.Forms.TextBox();
            this.stbnHesapSil = new DevExpress.XtraEditors.SimpleButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.sbtnGeri3 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tpMusteriEkle.SuspendLayout();
            this.grpMusteriBilgileri.SuspendLayout();
            this.tpHesapAc.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tpHesapSil.SuspendLayout();
            this.grpHesapSil.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPane1
            // 
            this.tabPane1.Controls.Add(this.tpMusteriEkle);
            this.tabPane1.Controls.Add(this.tpHesapAc);
            this.tabPane1.Controls.Add(this.tpHesapSil);
            this.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPane1.Location = new System.Drawing.Point(0, 0);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.PageProperties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tpMusteriEkle,
            this.tpHesapAc,
            this.tpHesapSil});
            this.tabPane1.RegularSize = new System.Drawing.Size(800, 450);
            this.tabPane1.SelectedPage = this.tpHesapAc;
            this.tabPane1.Size = new System.Drawing.Size(800, 450);
            this.tabPane1.TabIndex = 0;
            this.tabPane1.Text = "tabPane1";
            // 
            // tpMusteriEkle
            // 
            this.tpMusteriEkle.Caption = "Müşteri Ekle";
            this.tpMusteriEkle.Controls.Add(this.sbtnGeri);
            this.tpMusteriEkle.Controls.Add(this.grpMusteriBilgileri);
            this.tpMusteriEkle.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tpMusteriEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tpMusteriEkle.ImageOptions.Image")));
            this.tpMusteriEkle.Name = "tpMusteriEkle";
            this.tpMusteriEkle.Size = new System.Drawing.Size(800, 410);
            // 
            // sbtnGeri
            // 
            this.sbtnGeri.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sbtnGeri.Appearance.Options.UseFont = true;
            this.sbtnGeri.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbtnGeri.ImageOptions.Image")));
            this.sbtnGeri.Location = new System.Drawing.Point(12, 3);
            this.sbtnGeri.Name = "sbtnGeri";
            this.sbtnGeri.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.sbtnGeri.Size = new System.Drawing.Size(41, 42);
            this.sbtnGeri.TabIndex = 6;
            this.sbtnGeri.Click += new System.EventHandler(this.sbtnGeri_Click);
            // 
            // grpMusteriBilgileri
            // 
            this.grpMusteriBilgileri.Controls.Add(this.rbTicariMusteri);
            this.grpMusteriBilgileri.Controls.Add(this.rbBireyselMusteri);
            this.grpMusteriBilgileri.Controls.Add(this.dtKayitTarihi);
            this.grpMusteriBilgileri.Controls.Add(this.sbtnMusteriEkle);
            this.grpMusteriBilgileri.Controls.Add(this.lblKullanici);
            this.grpMusteriBilgileri.Controls.Add(this.txtMusteriSifre);
            this.grpMusteriBilgileri.Controls.Add(this.label1);
            this.grpMusteriBilgileri.Controls.Add(this.txtMusteriNo);
            this.grpMusteriBilgileri.Controls.Add(this.label4);
            this.grpMusteriBilgileri.Controls.Add(this.label2);
            this.grpMusteriBilgileri.Controls.Add(this.txtMusteriSoyad);
            this.grpMusteriBilgileri.Controls.Add(this.label5);
            this.grpMusteriBilgileri.Controls.Add(this.label3);
            this.grpMusteriBilgileri.Controls.Add(this.txtMusteriAdi);
            this.grpMusteriBilgileri.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpMusteriBilgileri.Location = new System.Drawing.Point(105, 14);
            this.grpMusteriBilgileri.Name = "grpMusteriBilgileri";
            this.grpMusteriBilgileri.Size = new System.Drawing.Size(645, 368);
            this.grpMusteriBilgileri.TabIndex = 5;
            this.grpMusteriBilgileri.TabStop = false;
            this.grpMusteriBilgileri.Text = "Müşteri Bilgileri";
            // 
            // rbTicariMusteri
            // 
            this.rbTicariMusteri.AutoSize = true;
            this.rbTicariMusteri.Location = new System.Drawing.Point(388, 253);
            this.rbTicariMusteri.Name = "rbTicariMusteri";
            this.rbTicariMusteri.Size = new System.Drawing.Size(127, 23);
            this.rbTicariMusteri.TabIndex = 8;
            this.rbTicariMusteri.TabStop = true;
            this.rbTicariMusteri.Text = "Ticari Müşteri";
            this.rbTicariMusteri.UseVisualStyleBackColor = true;
            // 
            // rbBireyselMusteri
            // 
            this.rbBireyselMusteri.AutoSize = true;
            this.rbBireyselMusteri.Location = new System.Drawing.Point(225, 253);
            this.rbBireyselMusteri.Name = "rbBireyselMusteri";
            this.rbBireyselMusteri.Size = new System.Drawing.Size(146, 23);
            this.rbBireyselMusteri.TabIndex = 7;
            this.rbBireyselMusteri.TabStop = true;
            this.rbBireyselMusteri.Text = "Bireysel Müşteri";
            this.rbBireyselMusteri.UseVisualStyleBackColor = true;
            // 
            // dtKayitTarihi
            // 
            this.dtKayitTarihi.CalendarFont = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtKayitTarihi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtKayitTarihi.Location = new System.Drawing.Point(225, 111);
            this.dtKayitTarihi.Name = "dtKayitTarihi";
            this.dtKayitTarihi.Size = new System.Drawing.Size(241, 27);
            this.dtKayitTarihi.TabIndex = 6;
            // 
            // sbtnMusteriEkle
            // 
            this.sbtnMusteriEkle.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sbtnMusteriEkle.Appearance.Options.UseFont = true;
            this.sbtnMusteriEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sbtnMusteriEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbtnMusteriEkle.ImageOptions.Image")));
            this.sbtnMusteriEkle.Location = new System.Drawing.Point(273, 293);
            this.sbtnMusteriEkle.Name = "sbtnMusteriEkle";
            this.sbtnMusteriEkle.Size = new System.Drawing.Size(168, 58);
            this.sbtnMusteriEkle.TabIndex = 5;
            this.sbtnMusteriEkle.Text = "KAYDET";
            this.sbtnMusteriEkle.Click += new System.EventHandler(this.sbtnMusteriEkle_Click);
            // 
            // lblKullanici
            // 
            this.lblKullanici.AutoSize = true;
            this.lblKullanici.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullanici.Location = new System.Drawing.Point(167, 34);
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Size = new System.Drawing.Size(43, 21);
            this.lblKullanici.TabIndex = 1;
            this.lblKullanici.Text = "Adı:";
            // 
            // txtMusteriSifre
            // 
            this.txtMusteriSifre.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMusteriSifre.Location = new System.Drawing.Point(225, 194);
            this.txtMusteriSifre.Name = "txtMusteriSifre";
            this.txtMusteriSifre.Size = new System.Drawing.Size(241, 28);
            this.txtMusteriSifre.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(142, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Soyadı:";
            // 
            // txtMusteriNo
            // 
            this.txtMusteriNo.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMusteriNo.Location = new System.Drawing.Point(225, 154);
            this.txtMusteriNo.Name = "txtMusteriNo";
            this.txtMusteriNo.Size = new System.Drawing.Size(241, 28);
            this.txtMusteriNo.TabIndex = 3;
            this.txtMusteriNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMusteriNo_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(158, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tarih:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(112, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Müşteri No:";
            // 
            // txtMusteriSoyad
            // 
            this.txtMusteriSoyad.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMusteriSoyad.Location = new System.Drawing.Point(225, 70);
            this.txtMusteriSoyad.Name = "txtMusteriSoyad";
            this.txtMusteriSoyad.Size = new System.Drawing.Size(241, 28);
            this.txtMusteriSoyad.TabIndex = 3;
            this.txtMusteriSoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMusteriSoyad_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(106, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "Müşteri Tipi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(161, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Şifre:";
            // 
            // txtMusteriAdi
            // 
            this.txtMusteriAdi.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMusteriAdi.Location = new System.Drawing.Point(225, 27);
            this.txtMusteriAdi.Name = "txtMusteriAdi";
            this.txtMusteriAdi.Size = new System.Drawing.Size(241, 28);
            this.txtMusteriAdi.TabIndex = 3;
            this.txtMusteriAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMusteriAdi_KeyPress);
            // 
            // tpHesapAc
            // 
            this.tpHesapAc.Caption = "Hesap Aç";
            this.tpHesapAc.Controls.Add(this.groupBox1);
            this.tpHesapAc.Controls.Add(this.sbtnGeri2);
            this.tpHesapAc.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tpHesapAc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tpHesapAc.ImageOptions.Image")));
            this.tpHesapAc.Name = "tpHesapAc";
            this.tpHesapAc.Size = new System.Drawing.Size(800, 410);
            this.tpHesapAc.Paint += new System.Windows.Forms.PaintEventHandler(this.tp_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sbtnHesapAc);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtEkBakiye);
            this.groupBox1.Controls.Add(this.txtMusteriHesapAcNo);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(122, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(572, 298);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Bilgileri";
            // 
            // sbtnHesapAc
            // 
            this.sbtnHesapAc.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sbtnHesapAc.Appearance.Options.UseFont = true;
            this.sbtnHesapAc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sbtnHesapAc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbtnHesapAc.ImageOptions.Image")));
            this.sbtnHesapAc.Location = new System.Drawing.Point(290, 169);
            this.sbtnHesapAc.Name = "sbtnHesapAc";
            this.sbtnHesapAc.Size = new System.Drawing.Size(168, 58);
            this.sbtnHesapAc.TabIndex = 5;
            this.sbtnHesapAc.Text = "HESAP AÇ";
            this.sbtnHesapAc.Click += new System.EventHandler(this.sbtnHesapAc_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(83, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "Müşteri Numarası:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(81, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 21);
            this.label7.TabIndex = 1;
            this.label7.Text = "Ek Bakiye Miktarı:";
            // 
            // txtEkBakiye
            // 
            this.txtEkBakiye.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEkBakiye.Location = new System.Drawing.Point(246, 101);
            this.txtEkBakiye.Name = "txtEkBakiye";
            this.txtEkBakiye.Size = new System.Drawing.Size(241, 28);
            this.txtEkBakiye.TabIndex = 3;
            this.txtEkBakiye.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEkBakiye_KeyPress);
            // 
            // txtMusteriHesapAcNo
            // 
            this.txtMusteriHesapAcNo.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMusteriHesapAcNo.Location = new System.Drawing.Point(246, 58);
            this.txtMusteriHesapAcNo.Name = "txtMusteriHesapAcNo";
            this.txtMusteriHesapAcNo.Size = new System.Drawing.Size(241, 28);
            this.txtMusteriHesapAcNo.TabIndex = 3;
            this.txtMusteriHesapAcNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMusteriHesapAcNo_KeyPress);
            // 
            // sbtnGeri2
            // 
            this.sbtnGeri2.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sbtnGeri2.Appearance.Options.UseFont = true;
            this.sbtnGeri2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbtnGeri2.ImageOptions.Image")));
            this.sbtnGeri2.Location = new System.Drawing.Point(12, 3);
            this.sbtnGeri2.Name = "sbtnGeri2";
            this.sbtnGeri2.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.sbtnGeri2.Size = new System.Drawing.Size(41, 42);
            this.sbtnGeri2.TabIndex = 7;
            this.sbtnGeri2.Click += new System.EventHandler(this.sbtnGeri2_Click);
            // 
            // tpHesapSil
            // 
            this.tpHesapSil.Caption = "Hesap Sil";
            this.tpHesapSil.Controls.Add(this.grpHesapSil);
            this.tpHesapSil.Controls.Add(this.sbtnGeri3);
            this.tpHesapSil.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tpHesapSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tpHesapSil.ImageOptions.Image")));
            this.tpHesapSil.Name = "tpHesapSil";
            this.tpHesapSil.Size = new System.Drawing.Size(800, 410);
            // 
            // grpHesapSil
            // 
            this.grpHesapSil.Controls.Add(this.txtMusteriHesapSil);
            this.grpHesapSil.Controls.Add(this.stbnHesapSil);
            this.grpHesapSil.Controls.Add(this.label9);
            this.grpHesapSil.Controls.Add(this.label8);
            this.grpHesapSil.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpHesapSil.Location = new System.Drawing.Point(130, 58);
            this.grpHesapSil.Name = "grpHesapSil";
            this.grpHesapSil.Size = new System.Drawing.Size(567, 274);
            this.grpHesapSil.TabIndex = 12;
            this.grpHesapSil.TabStop = false;
            this.grpHesapSil.Text = "Hesap Sil";
            // 
            // txtMusteriHesapSil
            // 
            this.txtMusteriHesapSil.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMusteriHesapSil.Location = new System.Drawing.Point(265, 132);
            this.txtMusteriHesapSil.Name = "txtMusteriHesapSil";
            this.txtMusteriHesapSil.Size = new System.Drawing.Size(162, 28);
            this.txtMusteriHesapSil.TabIndex = 10;
            this.txtMusteriHesapSil.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMusteriHesapSil_KeyPress);
            // 
            // stbnHesapSil
            // 
            this.stbnHesapSil.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stbnHesapSil.Appearance.Options.UseFont = true;
            this.stbnHesapSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stbnHesapSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("stbnHesapSil.ImageOptions.Image")));
            this.stbnHesapSil.Location = new System.Drawing.Point(278, 192);
            this.stbnHesapSil.Name = "stbnHesapSil";
            this.stbnHesapSil.Size = new System.Drawing.Size(141, 50);
            this.stbnHesapSil.TabIndex = 11;
            this.stbnHesapSil.Text = "HESAP SİL";
            this.stbnHesapSil.Click += new System.EventHandler(this.stbnHesapSil_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(110, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 21);
            this.label9.TabIndex = 9;
            this.label9.Text = "Hesap Numarası:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(30, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(508, 42);
            this.label8.TabIndex = 9;
            this.label8.Text = "\"HERHANGİ BİR HESABIN SİLİNEBİLMESİ İÇİN BAKİYESİ \r\n                    VE EK BAK" +
    "İYESİ 0 OLMALIDIR.\"";
            // 
            // sbtnGeri3
            // 
            this.sbtnGeri3.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sbtnGeri3.Appearance.Options.UseFont = true;
            this.sbtnGeri3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbtnGeri3.ImageOptions.Image")));
            this.sbtnGeri3.Location = new System.Drawing.Point(12, 3);
            this.sbtnGeri3.Name = "sbtnGeri3";
            this.sbtnGeri3.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.sbtnGeri3.Size = new System.Drawing.Size(41, 42);
            this.sbtnGeri3.TabIndex = 8;
            this.sbtnGeri3.Click += new System.EventHandler(this.sbtnGeri3_Click);
            // 
            // frmPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabPane1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPersonel";
            this.Load += new System.EventHandler(this.frmPersonel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tpMusteriEkle.ResumeLayout(false);
            this.grpMusteriBilgileri.ResumeLayout(false);
            this.grpMusteriBilgileri.PerformLayout();
            this.tpHesapAc.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tpHesapSil.ResumeLayout(false);
            this.grpHesapSil.ResumeLayout(false);
            this.grpHesapSil.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tpMusteriEkle;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tpHesapAc;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tpHesapSil;
        private System.Windows.Forms.GroupBox grpMusteriBilgileri;
        private System.Windows.Forms.DateTimePicker dtKayitTarihi;
        private DevExpress.XtraEditors.SimpleButton sbtnMusteriEkle;
        private System.Windows.Forms.Label lblKullanici;
        private System.Windows.Forms.TextBox txtMusteriSifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMusteriNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMusteriSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMusteriAdi;
        private DevExpress.XtraEditors.SimpleButton sbtnGeri;
        private System.Windows.Forms.RadioButton rbTicariMusteri;
        private System.Windows.Forms.RadioButton rbBireyselMusteri;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton sbtnHesapAc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEkBakiye;
        private System.Windows.Forms.TextBox txtMusteriHesapAcNo;
        private DevExpress.XtraEditors.SimpleButton sbtnGeri2;
        private DevExpress.XtraEditors.SimpleButton stbnHesapSil;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMusteriHesapSil;
        private DevExpress.XtraEditors.SimpleButton sbtnGeri3;
        private System.Windows.Forms.GroupBox grpHesapSil;
        private System.Windows.Forms.Label label9;
    }
}