namespace BankOtomasyon
{
    partial class frmYonetici
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmYonetici));
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tpPersonelEkle = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.sbtnGeri = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sbtnPersonelEkle = new DevExpress.XtraEditors.SimpleButton();
            this.lblKullanici = new System.Windows.Forms.Label();
            this.txtPersonelSifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPersonelKulAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPersonelSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPersonelAdi = new System.Windows.Forms.TextBox();
            this.tpPersonelCikar = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.sbtnGeri1 = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sbtnPersonelCikar = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPersonelSilKulAdi = new System.Windows.Forms.TextBox();
            this.tpPersonelListele = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.sbtnGeri2 = new DevExpress.XtraEditors.SimpleButton();
            this.dtgPersonelListele = new System.Windows.Forms.DataGridView();
            this.tpBankaIslemListesi = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.sbtnGeri3 = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnBankaIslemListele = new DevExpress.XtraEditors.SimpleButton();
            this.lblToplamPara = new System.Windows.Forms.Label();
            this.dtgBankaIslemListele = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tpPersonelEkle.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tpPersonelCikar.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tpPersonelListele.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPersonelListele)).BeginInit();
            this.tpBankaIslemListesi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBankaIslemListele)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPane1
            // 
            this.tabPane1.Controls.Add(this.tpPersonelEkle);
            this.tabPane1.Controls.Add(this.tpPersonelCikar);
            this.tabPane1.Controls.Add(this.tpPersonelListele);
            this.tabPane1.Controls.Add(this.tpBankaIslemListesi);
            this.tabPane1.Location = new System.Drawing.Point(0, 0);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.PageProperties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tpPersonelEkle,
            this.tpPersonelCikar,
            this.tpPersonelListele,
            this.tpBankaIslemListesi});
            this.tabPane1.RegularSize = new System.Drawing.Size(837, 505);
            this.tabPane1.SelectedPage = this.tpPersonelCikar;
            this.tabPane1.Size = new System.Drawing.Size(837, 505);
            this.tabPane1.TabIndex = 0;
            this.tabPane1.Text = "tabPane1";
            // 
            // tpPersonelEkle
            // 
            this.tpPersonelEkle.Caption = "Personel Ekle";
            this.tpPersonelEkle.Controls.Add(this.sbtnGeri);
            this.tpPersonelEkle.Controls.Add(this.groupBox1);
            this.tpPersonelEkle.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tpPersonelEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tpPersonelEkle.ImageOptions.Image")));
            this.tpPersonelEkle.Name = "tpPersonelEkle";
            this.tpPersonelEkle.Size = new System.Drawing.Size(837, 465);
            // 
            // sbtnGeri
            // 
            this.sbtnGeri.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sbtnGeri.Appearance.Options.UseFont = true;
            this.sbtnGeri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sbtnGeri.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbtnGeri.ImageOptions.Image")));
            this.sbtnGeri.Location = new System.Drawing.Point(12, 3);
            this.sbtnGeri.Name = "sbtnGeri";
            this.sbtnGeri.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.sbtnGeri.Size = new System.Drawing.Size(41, 42);
            this.sbtnGeri.TabIndex = 5;
            this.sbtnGeri.Click += new System.EventHandler(this.sbtnGeri_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sbtnPersonelEkle);
            this.groupBox1.Controls.Add(this.lblKullanici);
            this.groupBox1.Controls.Add(this.txtPersonelSifre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPersonelKulAdi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPersonelSoyad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPersonelAdi);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(142, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(542, 346);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Bilgileri";
            // 
            // sbtnPersonelEkle
            // 
            this.sbtnPersonelEkle.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sbtnPersonelEkle.Appearance.Options.UseFont = true;
            this.sbtnPersonelEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sbtnPersonelEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbtnPersonelEkle.ImageOptions.Image")));
            this.sbtnPersonelEkle.Location = new System.Drawing.Point(249, 248);
            this.sbtnPersonelEkle.Name = "sbtnPersonelEkle";
            this.sbtnPersonelEkle.Size = new System.Drawing.Size(147, 58);
            this.sbtnPersonelEkle.TabIndex = 5;
            this.sbtnPersonelEkle.Text = "EKLE";
            this.sbtnPersonelEkle.Click += new System.EventHandler(this.sbtnPersonelEkle_Click);
            // 
            // lblKullanici
            // 
            this.lblKullanici.AutoSize = true;
            this.lblKullanici.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullanici.Location = new System.Drawing.Point(157, 67);
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Size = new System.Drawing.Size(43, 21);
            this.lblKullanici.TabIndex = 1;
            this.lblKullanici.Text = "Adı:";
            this.lblKullanici.Click += new System.EventHandler(this.lblKullanici_Click);
            // 
            // txtPersonelSifre
            // 
            this.txtPersonelSifre.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPersonelSifre.Location = new System.Drawing.Point(221, 188);
            this.txtPersonelSifre.Name = "txtPersonelSifre";
            this.txtPersonelSifre.Size = new System.Drawing.Size(202, 28);
            this.txtPersonelSifre.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(132, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Soyadı:";
            this.label1.Click += new System.EventHandler(this.lblKullanici_Click);
            // 
            // txtPersonelKulAdi
            // 
            this.txtPersonelKulAdi.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPersonelKulAdi.Location = new System.Drawing.Point(221, 147);
            this.txtPersonelKulAdi.Name = "txtPersonelKulAdi";
            this.txtPersonelKulAdi.Size = new System.Drawing.Size(202, 28);
            this.txtPersonelKulAdi.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(85, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kullanıcı Adı:";
            this.label2.Click += new System.EventHandler(this.lblKullanici_Click);
            // 
            // txtPersonelSoyad
            // 
            this.txtPersonelSoyad.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPersonelSoyad.Location = new System.Drawing.Point(221, 99);
            this.txtPersonelSoyad.Name = "txtPersonelSoyad";
            this.txtPersonelSoyad.Size = new System.Drawing.Size(202, 28);
            this.txtPersonelSoyad.TabIndex = 3;
            this.txtPersonelSoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPersonelSoyad_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(151, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Şifre:";
            this.label3.Click += new System.EventHandler(this.lblKullanici_Click);
            // 
            // txtPersonelAdi
            // 
            this.txtPersonelAdi.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPersonelAdi.Location = new System.Drawing.Point(221, 60);
            this.txtPersonelAdi.Name = "txtPersonelAdi";
            this.txtPersonelAdi.Size = new System.Drawing.Size(202, 28);
            this.txtPersonelAdi.TabIndex = 3;
            this.txtPersonelAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPersonelAdi_KeyPress);
            // 
            // tpPersonelCikar
            // 
            this.tpPersonelCikar.Caption = "Personel Çıkar";
            this.tpPersonelCikar.Controls.Add(this.sbtnGeri1);
            this.tpPersonelCikar.Controls.Add(this.groupBox2);
            this.tpPersonelCikar.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tpPersonelCikar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tpPersonelCikar.ImageOptions.Image")));
            this.tpPersonelCikar.Name = "tpPersonelCikar";
            this.tpPersonelCikar.Size = new System.Drawing.Size(837, 465);
            // 
            // sbtnGeri1
            // 
            this.sbtnGeri1.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sbtnGeri1.Appearance.Options.UseFont = true;
            this.sbtnGeri1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sbtnGeri1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbtnGeri1.ImageOptions.Image")));
            this.sbtnGeri1.Location = new System.Drawing.Point(12, 3);
            this.sbtnGeri1.Name = "sbtnGeri1";
            this.sbtnGeri1.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.sbtnGeri1.Size = new System.Drawing.Size(41, 42);
            this.sbtnGeri1.TabIndex = 6;
            this.sbtnGeri1.Click += new System.EventHandler(this.sbtnGeri1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.sbtnPersonelCikar);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtPersonelSilKulAdi);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(170, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(492, 253);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Personel Bilgileri";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // sbtnPersonelCikar
            // 
            this.sbtnPersonelCikar.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sbtnPersonelCikar.Appearance.Options.UseFont = true;
            this.sbtnPersonelCikar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sbtnPersonelCikar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbtnPersonelCikar.ImageOptions.Image")));
            this.sbtnPersonelCikar.Location = new System.Drawing.Point(276, 132);
            this.sbtnPersonelCikar.Name = "sbtnPersonelCikar";
            this.sbtnPersonelCikar.Size = new System.Drawing.Size(147, 58);
            this.sbtnPersonelCikar.TabIndex = 5;
            this.sbtnPersonelCikar.Text = "SİL";
            this.sbtnPersonelCikar.Click += new System.EventHandler(this.sbtnPersonelCikar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(90, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Kullanıcı Adı:";
            // 
            // txtPersonelSilKulAdi
            // 
            this.txtPersonelSilKulAdi.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPersonelSilKulAdi.Location = new System.Drawing.Point(221, 60);
            this.txtPersonelSilKulAdi.Name = "txtPersonelSilKulAdi";
            this.txtPersonelSilKulAdi.Size = new System.Drawing.Size(202, 28);
            this.txtPersonelSilKulAdi.TabIndex = 3;
            // 
            // tpPersonelListele
            // 
            this.tpPersonelListele.Caption = "Personel Listele";
            this.tpPersonelListele.Controls.Add(this.sbtnGeri2);
            this.tpPersonelListele.Controls.Add(this.dtgPersonelListele);
            this.tpPersonelListele.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.tpPersonelListele.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tpPersonelListele.ImageOptions.Image")));
            this.tpPersonelListele.Name = "tpPersonelListele";
            this.tpPersonelListele.Size = new System.Drawing.Size(837, 465);
            // 
            // sbtnGeri2
            // 
            this.sbtnGeri2.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sbtnGeri2.Appearance.Options.UseFont = true;
            this.sbtnGeri2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sbtnGeri2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbtnGeri2.ImageOptions.Image")));
            this.sbtnGeri2.Location = new System.Drawing.Point(12, 3);
            this.sbtnGeri2.Name = "sbtnGeri2";
            this.sbtnGeri2.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.sbtnGeri2.Size = new System.Drawing.Size(41, 42);
            this.sbtnGeri2.TabIndex = 6;
            this.sbtnGeri2.Click += new System.EventHandler(this.sbtnGeri2_Click);
            // 
            // dtgPersonelListele
            // 
            this.dtgPersonelListele.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgPersonelListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPersonelListele.Location = new System.Drawing.Point(3, 63);
            this.dtgPersonelListele.Name = "dtgPersonelListele";
            this.dtgPersonelListele.RowHeadersWidth = 51;
            this.dtgPersonelListele.RowTemplate.Height = 24;
            this.dtgPersonelListele.Size = new System.Drawing.Size(831, 394);
            this.dtgPersonelListele.TabIndex = 0;
            // 
            // tpBankaIslemListesi
            // 
            this.tpBankaIslemListesi.Caption = "Banka İşlem Listesi";
            this.tpBankaIslemListesi.Controls.Add(this.sbtnGeri3);
            this.tpBankaIslemListesi.Controls.Add(this.sbtnBankaIslemListele);
            this.tpBankaIslemListesi.Controls.Add(this.lblToplamPara);
            this.tpBankaIslemListesi.Controls.Add(this.dtgBankaIslemListele);
            this.tpBankaIslemListesi.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.tpBankaIslemListesi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tpBankaIslemListesi.ImageOptions.Image")));
            this.tpBankaIslemListesi.Name = "tpBankaIslemListesi";
            this.tpBankaIslemListesi.Size = new System.Drawing.Size(837, 465);
            // 
            // sbtnGeri3
            // 
            this.sbtnGeri3.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sbtnGeri3.Appearance.Options.UseFont = true;
            this.sbtnGeri3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sbtnGeri3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbtnGeri3.ImageOptions.Image")));
            this.sbtnGeri3.Location = new System.Drawing.Point(12, 3);
            this.sbtnGeri3.Name = "sbtnGeri3";
            this.sbtnGeri3.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.sbtnGeri3.Size = new System.Drawing.Size(41, 42);
            this.sbtnGeri3.TabIndex = 6;
            this.sbtnGeri3.Click += new System.EventHandler(this.sbtnGeri3_Click);
            // 
            // sbtnBankaIslemListele
            // 
            this.sbtnBankaIslemListele.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbtnBankaIslemListele.Appearance.Options.UseFont = true;
            this.sbtnBankaIslemListele.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbtnBankaIslemListele.ImageOptions.Image")));
            this.sbtnBankaIslemListele.Location = new System.Drawing.Point(71, 12);
            this.sbtnBankaIslemListele.Name = "sbtnBankaIslemListele";
            this.sbtnBankaIslemListele.Size = new System.Drawing.Size(193, 42);
            this.sbtnBankaIslemListele.TabIndex = 3;
            this.sbtnBankaIslemListele.Text = "Listele\r\n";
            this.sbtnBankaIslemListele.Click += new System.EventHandler(this.sbtnBankaIslemListele_Click);
            // 
            // lblToplamPara
            // 
            this.lblToplamPara.AutoSize = true;
            this.lblToplamPara.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamPara.Location = new System.Drawing.Point(297, 22);
            this.lblToplamPara.Name = "lblToplamPara";
            this.lblToplamPara.Size = new System.Drawing.Size(216, 22);
            this.lblToplamPara.TabIndex = 2;
            this.lblToplamPara.Text = "Banka Toplam Para : - TL\r\n";
            // 
            // dtgBankaIslemListele
            // 
            this.dtgBankaIslemListele.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgBankaIslemListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgBankaIslemListele.Location = new System.Drawing.Point(0, 61);
            this.dtgBankaIslemListele.Name = "dtgBankaIslemListele";
            this.dtgBankaIslemListele.RowHeadersWidth = 51;
            this.dtgBankaIslemListele.RowTemplate.Height = 24;
            this.dtgBankaIslemListele.Size = new System.Drawing.Size(837, 404);
            this.dtgBankaIslemListele.TabIndex = 1;
            // 
            // frmYonetici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 505);
            this.Controls.Add(this.tabPane1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmYonetici";
            this.Text = "frmYonetici";
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tpPersonelEkle.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tpPersonelCikar.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tpPersonelListele.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPersonelListele)).EndInit();
            this.tpBankaIslemListesi.ResumeLayout(false);
            this.tpBankaIslemListesi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBankaIslemListele)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tpPersonelEkle;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tpPersonelCikar;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tpPersonelListele;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tpBankaIslemListesi;
        private System.Windows.Forms.Label lblKullanici;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPersonelSifre;
        private System.Windows.Forms.TextBox txtPersonelKulAdi;
        private System.Windows.Forms.TextBox txtPersonelSoyad;
        private System.Windows.Forms.TextBox txtPersonelAdi;
        private DevExpress.XtraEditors.SimpleButton sbtnPersonelEkle;
        private DevExpress.XtraEditors.SimpleButton sbtnGeri;
        private DevExpress.XtraEditors.SimpleButton sbtnGeri1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.SimpleButton sbtnPersonelCikar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPersonelSilKulAdi;
        private DevExpress.XtraEditors.SimpleButton sbtnGeri2;
        private System.Windows.Forms.DataGridView dtgPersonelListele;
        private DevExpress.XtraEditors.SimpleButton sbtnGeri3;
        private DevExpress.XtraEditors.SimpleButton sbtnBankaIslemListele;
        private System.Windows.Forms.Label lblToplamPara;
        private System.Windows.Forms.DataGridView dtgBankaIslemListele;
    }
}