/**************************************************************************** 
** 	 	 	 	 	      SAKARYA ÜNİVERSİTESİ 
** 	 	 	     BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ 
** 	 	 	 	   BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ 
** 	 	 	 	      NESNEYE DAYALI PROGRAMLAMA DERSİ 
** 	 	 	 	 	     2019-2020 BAHAR DÖNEMİ 
** 	 
** 	 	 	 	PROJE NUMARASI.........: ISE102 	 	
**              ÖĞRENCİ ADI............: SANEM KOCA
** 	 	 	 	ÖĞRENCİ NUMARASI.......: B191200302
** 	 	 	 	DERSİN ALINDIĞI GRUP...: A 
****************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankOtomasyon
{
    partial class frmYonetici : Form
    {
        public frmYonetici(Banka banka)
        {
            InitializeComponent();
            this.banka = banka;
            this.dtgPersonelListele.DataSource = banka.personeller;
        }

        Banka banka;

        private void lblKullanici_Click(object sender, EventArgs e)
        {

        }

        private void sbtnPersonelEkle_Click(object sender, EventArgs e)//Personel ekleme butonu
        {
            string Ad = txtPersonelAdi.Text; //Personel Bilgilerini textBox'dan okuyup yeni nesneye ekliyoruz.
            string Soyad = txtPersonelSoyad.Text;
            string ID = txtPersonelKulAdi.Text;
            string Sifre = txtPersonelSifre.Text;

            txtPersonelAdi.Clear(); //Personel eklendikten sonra textBoxları temizliyoruz.
            txtPersonelSoyad.Clear();
            txtPersonelKulAdi.Clear();
            txtPersonelSifre.Clear();

            banka.PersonelEkle(Ad, Soyad, ID, Sifre); //Personel bilgilerini Banka sınıfındaki PersonelEkle metoduna gönderiyoruz.        

            string rapor = ID + " kullanıcı adına sahip kişi bankaya personel olarak eklendi.";
            DateTime tarih = DateTime.Today;
            banka.RaporEkle(rapor, tarih);

            this.dtgPersonelListele.DataSource = banka.personeller; //gridView öğesine personeller listesini yazdırıyoruz.
        }

        private void sbtnPersonelCikar_Click(object sender, EventArgs e)//Personel silme butonu
        {
            string kullaniciAdi = txtPersonelSilKulAdi.Text;

            txtPersonelSilKulAdi.Clear();

            banka.PersonelSil(kullaniciAdi);

            this.dtgPersonelListele.DataSource = null;
            this.dtgPersonelListele.Rows.Clear();
            this.dtgPersonelListele.DataSource = banka.personeller;

            string rapor = kullaniciAdi + " kullanici adına sahip banka personeli silindi.";
            DateTime tarih = DateTime.Today;
            banka.RaporEkle(rapor, tarih);
        }

        private void sbtnBankaIslemListele_Click(object sender, EventArgs e)
        {
            dtgPersonelListele.DataSource = null;
            dtgPersonelListele.DataSource = banka.BankaRaporListesi;
            lblToplamPara.Text = "Banka toplam para:" + banka.toplamPara + " TL";
        }

        //Geri butonlarının kodlanması
        private void sbtnGeri_Click(object sender, EventArgs e)
        {
            Form1 f1 = Application.OpenForms["Form1"] as Form1;
            Panel panel1 = f1.Controls["panel1"] as Panel;
            panel1.Controls.Clear();

            frmGiris f3 = new frmGiris(banka);
            f3.TopLevel = false;

            panel1.Controls.Add(f3);

            f3.Show();
            f3.Dock = DockStyle.Fill;
        }

        private void sbtnGeri1_Click(object sender, EventArgs e)
        {
            Form1 f1 = Application.OpenForms["Form1"] as Form1;
            Panel panel1 = f1.Controls["panel1"] as Panel;
            panel1.Controls.Clear();

            frmGiris f3 = new frmGiris(banka);
            f3.TopLevel = false;

            panel1.Controls.Add(f3);

            f3.Show();
            f3.Dock = DockStyle.Fill;
        }

        private void sbtnGeri2_Click(object sender, EventArgs e)
        {
            Form1 f1 = Application.OpenForms["Form1"] as Form1;
            Panel panel1 = f1.Controls["panel1"] as Panel;
            panel1.Controls.Clear();

            frmGiris f3 = new frmGiris(banka);
            f3.TopLevel = false;

            panel1.Controls.Add(f3);

            f3.Show();
            f3.Dock = DockStyle.Fill;
        }

        private void sbtnGeri3_Click(object sender, EventArgs e)
        {
            Form1 f1 = Application.OpenForms["Form1"] as Form1;
            Panel panel1 = f1.Controls["panel1"] as Panel;
            panel1.Controls.Clear();

            frmGiris f3 = new frmGiris(banka);
            f3.TopLevel = false;

            panel1.Controls.Add(f3);

            f3.Show();
            f3.Dock = DockStyle.Fill;
        }

        private void txtPersonelAdi_KeyPress(object sender, KeyPressEventArgs e)//sadece harf girilmesini istediğimiz için bu kod yazıldı.
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void txtPersonelSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
