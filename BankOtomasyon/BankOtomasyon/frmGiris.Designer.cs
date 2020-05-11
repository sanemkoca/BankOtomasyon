namespace BankOtomasyon
{
    partial class frmGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiris));
            this.lblKullanici = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.grpGiris = new System.Windows.Forms.GroupBox();
            this.sbtnMusteriGiris = new DevExpress.XtraEditors.SimpleButton();
            this.grpButtons = new System.Windows.Forms.GroupBox();
            this.sbtnYoneticiGiris = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnPersonelGiris = new DevExpress.XtraEditors.SimpleButton();
            this.grpGiris.SuspendLayout();
            this.grpButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblKullanici
            // 
            this.lblKullanici.AutoSize = true;
            this.lblKullanici.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullanici.Location = new System.Drawing.Point(31, 48);
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Size = new System.Drawing.Size(221, 22);
            this.lblKullanici.TabIndex = 0;
            this.lblKullanici.Text = "Kullanıcı Adı/Müşteri No:";
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifre.Location = new System.Drawing.Point(197, 95);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(55, 22);
            this.lblSifre.TabIndex = 1;
            this.lblSifre.Text = "Şifre:";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciAdi.Location = new System.Drawing.Point(258, 43);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(165, 27);
            this.txtKullaniciAdi.TabIndex = 2;
            // 
            // txtSifre
            // 
            this.txtSifre.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.Location = new System.Drawing.Point(258, 90);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(165, 27);
            this.txtSifre.TabIndex = 2;
            // 
            // grpGiris
            // 
            this.grpGiris.Controls.Add(this.lblKullanici);
            this.grpGiris.Controls.Add(this.txtSifre);
            this.grpGiris.Controls.Add(this.lblSifre);
            this.grpGiris.Controls.Add(this.txtKullaniciAdi);
            this.grpGiris.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpGiris.Location = new System.Drawing.Point(150, 68);
            this.grpGiris.Name = "grpGiris";
            this.grpGiris.Size = new System.Drawing.Size(483, 157);
            this.grpGiris.TabIndex = 3;
            this.grpGiris.TabStop = false;
            this.grpGiris.Text = "Giriş Bilgileri";
            // 
            // sbtnMusteriGiris
            // 
            this.sbtnMusteriGiris.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sbtnMusteriGiris.Appearance.Options.UseFont = true;
            this.sbtnMusteriGiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sbtnMusteriGiris.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbtnMusteriGiris.ImageOptions.Image")));
            this.sbtnMusteriGiris.Location = new System.Drawing.Point(39, 39);
            this.sbtnMusteriGiris.Name = "sbtnMusteriGiris";
            this.sbtnMusteriGiris.Size = new System.Drawing.Size(161, 58);
            this.sbtnMusteriGiris.TabIndex = 4;
            this.sbtnMusteriGiris.Text = "Müşteri Giriş";
            this.sbtnMusteriGiris.Click += new System.EventHandler(this.sbtnMusteriGiris_Click);
            // 
            // grpButtons
            // 
            this.grpButtons.Controls.Add(this.sbtnYoneticiGiris);
            this.grpButtons.Controls.Add(this.sbtnPersonelGiris);
            this.grpButtons.Controls.Add(this.sbtnMusteriGiris);
            this.grpButtons.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpButtons.Location = new System.Drawing.Point(41, 247);
            this.grpButtons.Name = "grpButtons";
            this.grpButtons.Size = new System.Drawing.Size(727, 126);
            this.grpButtons.TabIndex = 5;
            this.grpButtons.TabStop = false;
            this.grpButtons.Text = "Giriş";
            // 
            // sbtnYoneticiGiris
            // 
            this.sbtnYoneticiGiris.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sbtnYoneticiGiris.Appearance.Options.UseFont = true;
            this.sbtnYoneticiGiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sbtnYoneticiGiris.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbtnYoneticiGiris.ImageOptions.Image")));
            this.sbtnYoneticiGiris.Location = new System.Drawing.Point(554, 39);
            this.sbtnYoneticiGiris.Name = "sbtnYoneticiGiris";
            this.sbtnYoneticiGiris.Size = new System.Drawing.Size(156, 58);
            this.sbtnYoneticiGiris.TabIndex = 4;
            this.sbtnYoneticiGiris.Text = "Yönetici Giriş";
            this.sbtnYoneticiGiris.Click += new System.EventHandler(this.sbtnYoneticiGiris_Click);
            // 
            // sbtnPersonelGiris
            // 
            this.sbtnPersonelGiris.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sbtnPersonelGiris.Appearance.Options.UseFont = true;
            this.sbtnPersonelGiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sbtnPersonelGiris.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbtnPersonelGiris.ImageOptions.Image")));
            this.sbtnPersonelGiris.Location = new System.Drawing.Point(299, 39);
            this.sbtnPersonelGiris.Name = "sbtnPersonelGiris";
            this.sbtnPersonelGiris.Size = new System.Drawing.Size(168, 58);
            this.sbtnPersonelGiris.TabIndex = 4;
            this.sbtnPersonelGiris.Text = "Personel Giriş";
            this.sbtnPersonelGiris.Click += new System.EventHandler(this.sbtnPersonelGiris_Click);
            // 
            // frmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 437);
            this.Controls.Add(this.grpButtons);
            this.Controls.Add(this.grpGiris);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGiris";
            this.Text = "GİRİŞ";
            this.Load += new System.EventHandler(this.frmGiris_Load);
            this.grpGiris.ResumeLayout(false);
            this.grpGiris.PerformLayout();
            this.grpButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblKullanici;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.GroupBox grpGiris;
        private DevExpress.XtraEditors.SimpleButton sbtnMusteriGiris;
        private System.Windows.Forms.GroupBox grpButtons;
        private DevExpress.XtraEditors.SimpleButton sbtnYoneticiGiris;
        private DevExpress.XtraEditors.SimpleButton sbtnPersonelGiris;
    }
}