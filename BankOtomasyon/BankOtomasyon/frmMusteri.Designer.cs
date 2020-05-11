namespace BankOtomasyon
{
    partial class frmMusteri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMusteri));
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tpParaCekme = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.sbtnGeri1 = new DevExpress.XtraEditors.SimpleButton();
            this.grpHesapBilgileri = new System.Windows.Forms.GroupBox();
            this.sbtnCek = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCekmeMiktar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCekmeHesapNo = new System.Windows.Forms.TextBox();
            this.tpParaYatırma = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.sbtnGeri2 = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sbtnYatir = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtYatirMiktar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtYatirHesapNo = new System.Windows.Forms.TextBox();
            this.tpHesabaHavale = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.grpHesabaHavale = new System.Windows.Forms.GroupBox();
            this.sbtnGonder = new DevExpress.XtraEditors.SimpleButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHavaleMiktar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtHavaleHesap = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtKaynakHesap = new System.Windows.Forms.TextBox();
            this.sbtnGeri3 = new DevExpress.XtraEditors.SimpleButton();
            this.tpHesapOzeti = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.sbtnOzetListele = new DevExpress.XtraEditors.SimpleButton();
            this.dtpBaslangic = new System.Windows.Forms.DateTimePicker();
            this.dtpBitis = new System.Windows.Forms.DateTimePicker();
            this.dtgHesapOzet = new System.Windows.Forms.DataGridView();
            this.txtOzetHesapNo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.sbtnGeri4 = new DevExpress.XtraEditors.SimpleButton();
            this.tpHesaplarım = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.dtgHesaplarim = new System.Windows.Forms.DataGridView();
            this.sbtnHesapListele = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnGeri5 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tpParaCekme.SuspendLayout();
            this.grpHesapBilgileri.SuspendLayout();
            this.tpParaYatırma.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tpHesabaHavale.SuspendLayout();
            this.grpHesabaHavale.SuspendLayout();
            this.tpHesapOzeti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHesapOzet)).BeginInit();
            this.tpHesaplarım.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHesaplarim)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPane1
            // 
            this.tabPane1.Controls.Add(this.tpParaCekme);
            this.tabPane1.Controls.Add(this.tpParaYatırma);
            this.tabPane1.Controls.Add(this.tpHesabaHavale);
            this.tabPane1.Controls.Add(this.tpHesapOzeti);
            this.tabPane1.Controls.Add(this.tpHesaplarım);
            this.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPane1.Location = new System.Drawing.Point(0, 0);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.PageProperties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tpParaCekme,
            this.tpParaYatırma,
            this.tpHesabaHavale,
            this.tpHesapOzeti,
            this.tpHesaplarım});
            this.tabPane1.RegularSize = new System.Drawing.Size(1018, 568);
            this.tabPane1.SelectedPage = this.tpHesabaHavale;
            this.tabPane1.Size = new System.Drawing.Size(1018, 568);
            this.tabPane1.TabIndex = 0;
            this.tabPane1.Text = "tabPane1";
            // 
            // tpParaCekme
            // 
            this.tpParaCekme.Caption = "Para Çekme";
            this.tpParaCekme.Controls.Add(this.sbtnGeri1);
            this.tpParaCekme.Controls.Add(this.grpHesapBilgileri);
            this.tpParaCekme.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tpParaCekme.ImageOptions.Image")));
            this.tpParaCekme.Name = "tpParaCekme";
            this.tpParaCekme.Size = new System.Drawing.Size(1018, 528);
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
            this.sbtnGeri1.TabIndex = 7;
            this.sbtnGeri1.Click += new System.EventHandler(this.sbtnGeri1_Click);
            // 
            // grpHesapBilgileri
            // 
            this.grpHesapBilgileri.Controls.Add(this.sbtnCek);
            this.grpHesapBilgileri.Controls.Add(this.label1);
            this.grpHesapBilgileri.Controls.Add(this.txtCekmeMiktar);
            this.grpHesapBilgileri.Controls.Add(this.label2);
            this.grpHesapBilgileri.Controls.Add(this.label4);
            this.grpHesapBilgileri.Controls.Add(this.txtCekmeHesapNo);
            this.grpHesapBilgileri.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpHesapBilgileri.Location = new System.Drawing.Point(223, 82);
            this.grpHesapBilgileri.Name = "grpHesapBilgileri";
            this.grpHesapBilgileri.Size = new System.Drawing.Size(533, 306);
            this.grpHesapBilgileri.TabIndex = 6;
            this.grpHesapBilgileri.TabStop = false;
            this.grpHesapBilgileri.Text = "Hesap Bilgileri";
            // 
            // sbtnCek
            // 
            this.sbtnCek.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sbtnCek.Appearance.Options.UseFont = true;
            this.sbtnCek.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sbtnCek.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbtnCek.ImageOptions.Image")));
            this.sbtnCek.Location = new System.Drawing.Point(288, 199);
            this.sbtnCek.Name = "sbtnCek";
            this.sbtnCek.Size = new System.Drawing.Size(147, 44);
            this.sbtnCek.TabIndex = 5;
            this.sbtnCek.Text = "ÇEK";
            this.sbtnCek.Click += new System.EventHandler(this.sbtnCek_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(149, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Miktar:";
            // 
            // txtCekmeMiktar
            // 
            this.txtCekmeMiktar.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCekmeMiktar.Location = new System.Drawing.Point(233, 149);
            this.txtCekmeMiktar.Name = "txtCekmeMiktar";
            this.txtCekmeMiktar.Size = new System.Drawing.Size(202, 28);
            this.txtCekmeMiktar.TabIndex = 3;
            this.txtCekmeMiktar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCekmeMiktar_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(73, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(382, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "\"GÜNLÜK PARA ÇEKME LİMİTİ 750 TL\'DİR\"";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(73, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Hesap Numarası:";
            // 
            // txtCekmeHesapNo
            // 
            this.txtCekmeHesapNo.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCekmeHesapNo.Location = new System.Drawing.Point(233, 104);
            this.txtCekmeHesapNo.Name = "txtCekmeHesapNo";
            this.txtCekmeHesapNo.Size = new System.Drawing.Size(202, 28);
            this.txtCekmeHesapNo.TabIndex = 3;
            this.txtCekmeHesapNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCekmeHesapNo_KeyPress);
            // 
            // tpParaYatırma
            // 
            this.tpParaYatırma.Caption = "Para Yatırma";
            this.tpParaYatırma.Controls.Add(this.sbtnGeri2);
            this.tpParaYatırma.Controls.Add(this.groupBox1);
            this.tpParaYatırma.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tpParaYatırma.ImageOptions.Image")));
            this.tpParaYatırma.Name = "tpParaYatırma";
            this.tpParaYatırma.Size = new System.Drawing.Size(1018, 528);
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
            this.sbtnGeri2.TabIndex = 8;
            this.sbtnGeri2.Click += new System.EventHandler(this.sbtnGeri2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sbtnYatir);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtYatirMiktar);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtYatirHesapNo);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(209, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(533, 306);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hesap Bilgileri";
            // 
            // sbtnYatir
            // 
            this.sbtnYatir.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sbtnYatir.Appearance.Options.UseFont = true;
            this.sbtnYatir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sbtnYatir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbtnYatir.ImageOptions.Image")));
            this.sbtnYatir.Location = new System.Drawing.Point(291, 181);
            this.sbtnYatir.Name = "sbtnYatir";
            this.sbtnYatir.Size = new System.Drawing.Size(147, 42);
            this.sbtnYatir.TabIndex = 5;
            this.sbtnYatir.Text = "YATIR";
            this.sbtnYatir.Click += new System.EventHandler(this.sbtnYatir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(156, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Miktar:";
            // 
            // txtYatirMiktar
            // 
            this.txtYatirMiktar.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYatirMiktar.Location = new System.Drawing.Point(236, 127);
            this.txtYatirMiktar.Name = "txtYatirMiktar";
            this.txtYatirMiktar.Size = new System.Drawing.Size(202, 28);
            this.txtYatirMiktar.TabIndex = 3;
            this.txtYatirMiktar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYatirMiktar_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(80, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "Hesap Numarası:";
            // 
            // txtYatirHesapNo
            // 
            this.txtYatirHesapNo.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYatirHesapNo.Location = new System.Drawing.Point(236, 82);
            this.txtYatirHesapNo.Name = "txtYatirHesapNo";
            this.txtYatirHesapNo.Size = new System.Drawing.Size(202, 28);
            this.txtYatirHesapNo.TabIndex = 3;
            this.txtYatirHesapNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYatirHesapNo_KeyPress);
            // 
            // tpHesabaHavale
            // 
            this.tpHesabaHavale.Caption = "Hesaba Havale";
            this.tpHesabaHavale.Controls.Add(this.grpHesabaHavale);
            this.tpHesabaHavale.Controls.Add(this.sbtnGeri3);
            this.tpHesabaHavale.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tpHesabaHavale.ImageOptions.Image")));
            this.tpHesabaHavale.Name = "tpHesabaHavale";
            this.tpHesabaHavale.Size = new System.Drawing.Size(1018, 528);
            // 
            // grpHesabaHavale
            // 
            this.grpHesabaHavale.Controls.Add(this.sbtnGonder);
            this.grpHesabaHavale.Controls.Add(this.label5);
            this.grpHesabaHavale.Controls.Add(this.txtHavaleMiktar);
            this.grpHesabaHavale.Controls.Add(this.label8);
            this.grpHesabaHavale.Controls.Add(this.txtHavaleHesap);
            this.grpHesabaHavale.Controls.Add(this.label7);
            this.grpHesabaHavale.Controls.Add(this.txtKaynakHesap);
            this.grpHesabaHavale.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpHesabaHavale.Location = new System.Drawing.Point(173, 76);
            this.grpHesabaHavale.Name = "grpHesabaHavale";
            this.grpHesabaHavale.Size = new System.Drawing.Size(624, 322);
            this.grpHesabaHavale.TabIndex = 10;
            this.grpHesabaHavale.TabStop = false;
            this.grpHesabaHavale.Text = "Hesaba Havale";
            // 
            // sbtnGonder
            // 
            this.sbtnGonder.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sbtnGonder.Appearance.Options.UseFont = true;
            this.sbtnGonder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sbtnGonder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbtnGonder.ImageOptions.Image")));
            this.sbtnGonder.Location = new System.Drawing.Point(405, 198);
            this.sbtnGonder.Name = "sbtnGonder";
            this.sbtnGonder.Size = new System.Drawing.Size(147, 42);
            this.sbtnGonder.TabIndex = 5;
            this.sbtnGonder.Text = "GÖNDER";
            this.sbtnGonder.Click += new System.EventHandler(this.sbtnGonder_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(247, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "Miktar:";
            // 
            // txtHavaleMiktar
            // 
            this.txtHavaleMiktar.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtHavaleMiktar.Location = new System.Drawing.Point(330, 138);
            this.txtHavaleMiktar.Name = "txtHavaleMiktar";
            this.txtHavaleMiktar.Size = new System.Drawing.Size(222, 28);
            this.txtHavaleMiktar.TabIndex = 3;
            this.txtHavaleMiktar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHavaleMiktar_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(39, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(270, 21);
            this.label8.TabIndex = 1;
            this.label8.Text = "Havale Yapılacak Hesap Numarası:";
            // 
            // txtHavaleHesap
            // 
            this.txtHavaleHesap.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtHavaleHesap.Location = new System.Drawing.Point(330, 49);
            this.txtHavaleHesap.Name = "txtHavaleHesap";
            this.txtHavaleHesap.Size = new System.Drawing.Size(222, 28);
            this.txtHavaleHesap.TabIndex = 3;
            this.txtHavaleHesap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHavaleHesap_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(110, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(199, 21);
            this.label7.TabIndex = 1;
            this.label7.Text = "Kaynak Hesap Numarası:";
            // 
            // txtKaynakHesap
            // 
            this.txtKaynakHesap.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKaynakHesap.Location = new System.Drawing.Point(330, 91);
            this.txtKaynakHesap.Name = "txtKaynakHesap";
            this.txtKaynakHesap.Size = new System.Drawing.Size(222, 28);
            this.txtKaynakHesap.TabIndex = 3;
            this.txtKaynakHesap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKaynakHesap_KeyPress);
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
            this.sbtnGeri3.Size = new System.Drawing.Size(40, 41);
            this.sbtnGeri3.TabIndex = 9;
            this.sbtnGeri3.Click += new System.EventHandler(this.sbtnGeri3_Click);
            // 
            // tpHesapOzeti
            // 
            this.tpHesapOzeti.Caption = "Hesap Özeti";
            this.tpHesapOzeti.Controls.Add(this.sbtnOzetListele);
            this.tpHesapOzeti.Controls.Add(this.dtpBaslangic);
            this.tpHesapOzeti.Controls.Add(this.dtpBitis);
            this.tpHesapOzeti.Controls.Add(this.dtgHesapOzet);
            this.tpHesapOzeti.Controls.Add(this.txtOzetHesapNo);
            this.tpHesapOzeti.Controls.Add(this.label9);
            this.tpHesapOzeti.Controls.Add(this.sbtnGeri4);
            this.tpHesapOzeti.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tpHesapOzeti.ImageOptions.Image")));
            this.tpHesapOzeti.Name = "tpHesapOzeti";
            this.tpHesapOzeti.Size = new System.Drawing.Size(1018, 528);
            // 
            // sbtnOzetListele
            // 
            this.sbtnOzetListele.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sbtnOzetListele.Appearance.Options.UseFont = true;
            this.sbtnOzetListele.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sbtnOzetListele.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbtnOzetListele.ImageOptions.Image")));
            this.sbtnOzetListele.Location = new System.Drawing.Point(736, 24);
            this.sbtnOzetListele.Name = "sbtnOzetListele";
            this.sbtnOzetListele.Size = new System.Drawing.Size(190, 42);
            this.sbtnOzetListele.TabIndex = 14;
            this.sbtnOzetListele.Text = "LİSTELE";
            this.sbtnOzetListele.Click += new System.EventHandler(this.sbtnOzetListele_Click);
            // 
            // dtpBaslangic
            // 
            this.dtpBaslangic.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpBaslangic.Location = new System.Drawing.Point(451, 18);
            this.dtpBaslangic.Name = "dtpBaslangic";
            this.dtpBaslangic.Size = new System.Drawing.Size(241, 27);
            this.dtpBaslangic.TabIndex = 13;
            // 
            // dtpBitis
            // 
            this.dtpBitis.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpBitis.Location = new System.Drawing.Point(451, 51);
            this.dtpBitis.Name = "dtpBitis";
            this.dtpBitis.Size = new System.Drawing.Size(241, 27);
            this.dtpBitis.TabIndex = 13;
            // 
            // dtgHesapOzet
            // 
            this.dtgHesapOzet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgHesapOzet.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgHesapOzet.Location = new System.Drawing.Point(0, 91);
            this.dtgHesapOzet.Name = "dtgHesapOzet";
            this.dtgHesapOzet.RowHeadersWidth = 51;
            this.dtgHesapOzet.RowTemplate.Height = 24;
            this.dtgHesapOzet.Size = new System.Drawing.Size(1018, 437);
            this.dtgHesapOzet.TabIndex = 12;
            // 
            // txtOzetHesapNo
            // 
            this.txtOzetHesapNo.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOzetHesapNo.Location = new System.Drawing.Point(214, 28);
            this.txtOzetHesapNo.Name = "txtOzetHesapNo";
            this.txtOzetHesapNo.Size = new System.Drawing.Size(202, 28);
            this.txtOzetHesapNo.TabIndex = 11;
            this.txtOzetHesapNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOzetHesapNo_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(70, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 21);
            this.label9.TabIndex = 10;
            this.label9.Text = "Hesap Numarası:";
            // 
            // sbtnGeri4
            // 
            this.sbtnGeri4.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sbtnGeri4.Appearance.Options.UseFont = true;
            this.sbtnGeri4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sbtnGeri4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbtnGeri4.ImageOptions.Image")));
            this.sbtnGeri4.Location = new System.Drawing.Point(12, 3);
            this.sbtnGeri4.Name = "sbtnGeri4";
            this.sbtnGeri4.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.sbtnGeri4.Size = new System.Drawing.Size(41, 42);
            this.sbtnGeri4.TabIndex = 9;
            this.sbtnGeri4.Click += new System.EventHandler(this.sbtnGeri4_Click);
            // 
            // tpHesaplarım
            // 
            this.tpHesaplarım.Caption = "Hesaplarım";
            this.tpHesaplarım.Controls.Add(this.dtgHesaplarim);
            this.tpHesaplarım.Controls.Add(this.sbtnHesapListele);
            this.tpHesaplarım.Controls.Add(this.sbtnGeri5);
            this.tpHesaplarım.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tpHesaplarım.ImageOptions.Image")));
            this.tpHesaplarım.Name = "tpHesaplarım";
            this.tpHesaplarım.Size = new System.Drawing.Size(1018, 528);
            // 
            // dtgHesaplarim
            // 
            this.dtgHesaplarim.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgHesaplarim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgHesaplarim.Location = new System.Drawing.Point(0, 73);
            this.dtgHesaplarim.Name = "dtgHesaplarim";
            this.dtgHesaplarim.RowHeadersWidth = 51;
            this.dtgHesaplarim.RowTemplate.Height = 24;
            this.dtgHesaplarim.Size = new System.Drawing.Size(1018, 450);
            this.dtgHesaplarim.TabIndex = 16;
            // 
            // sbtnHesapListele
            // 
            this.sbtnHesapListele.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sbtnHesapListele.Appearance.Options.UseFont = true;
            this.sbtnHesapListele.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sbtnHesapListele.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbtnHesapListele.ImageOptions.Image")));
            this.sbtnHesapListele.Location = new System.Drawing.Point(97, 13);
            this.sbtnHesapListele.Name = "sbtnHesapListele";
            this.sbtnHesapListele.Size = new System.Drawing.Size(206, 42);
            this.sbtnHesapListele.TabIndex = 15;
            this.sbtnHesapListele.Text = "LİSTELE";
            this.sbtnHesapListele.Click += new System.EventHandler(this.sbtnHesapListele_Click);
            // 
            // sbtnGeri5
            // 
            this.sbtnGeri5.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sbtnGeri5.Appearance.Options.UseFont = true;
            this.sbtnGeri5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sbtnGeri5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbtnGeri5.ImageOptions.Image")));
            this.sbtnGeri5.Location = new System.Drawing.Point(12, 3);
            this.sbtnGeri5.Name = "sbtnGeri5";
            this.sbtnGeri5.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.sbtnGeri5.Size = new System.Drawing.Size(41, 42);
            this.sbtnGeri5.TabIndex = 9;
            this.sbtnGeri5.Click += new System.EventHandler(this.sbtnGeri5_Click);
            // 
            // frmMusteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 568);
            this.Controls.Add(this.tabPane1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMusteri";
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tpParaCekme.ResumeLayout(false);
            this.grpHesapBilgileri.ResumeLayout(false);
            this.grpHesapBilgileri.PerformLayout();
            this.tpParaYatırma.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tpHesabaHavale.ResumeLayout(false);
            this.grpHesabaHavale.ResumeLayout(false);
            this.grpHesabaHavale.PerformLayout();
            this.tpHesapOzeti.ResumeLayout(false);
            this.tpHesapOzeti.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHesapOzet)).EndInit();
            this.tpHesaplarım.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgHesaplarim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tpParaCekme;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tpParaYatırma;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tpHesabaHavale;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tpHesapOzeti;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tpHesaplarım;
        private System.Windows.Forms.GroupBox grpHesapBilgileri;
        private DevExpress.XtraEditors.SimpleButton sbtnCek;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCekmeHesapNo;
        private DevExpress.XtraEditors.SimpleButton sbtnGeri1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCekmeMiktar;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton sbtnGeri2;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton sbtnYatir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtYatirMiktar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtYatirHesapNo;
        private DevExpress.XtraEditors.SimpleButton sbtnGeri3;
        private DevExpress.XtraEditors.SimpleButton sbtnGeri4;
        private DevExpress.XtraEditors.SimpleButton sbtnGeri5;
        private System.Windows.Forms.GroupBox grpHesabaHavale;
        private DevExpress.XtraEditors.SimpleButton sbtnGonder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHavaleMiktar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtHavaleHesap;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtKaynakHesap;
        private DevExpress.XtraEditors.SimpleButton sbtnOzetListele;
        private System.Windows.Forms.DateTimePicker dtpBaslangic;
        private System.Windows.Forms.DateTimePicker dtpBitis;
        private System.Windows.Forms.DataGridView dtgHesapOzet;
        private System.Windows.Forms.TextBox txtOzetHesapNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dtgHesaplarim;
        private DevExpress.XtraEditors.SimpleButton sbtnHesapListele;
    }
}