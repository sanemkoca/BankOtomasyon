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
using MetroFramework.Forms;

namespace BankOtomasyon
{
    partial class frmPersonel : Form
    {
        public frmPersonel(Banka banka)
        {
            InitializeComponent();
            this.banka = banka;
        }

        Banka banka;

        private void frmPersonel_Load(object sender, EventArgs e)
        {

        }

        private void tp_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sbtnMusteriEkle_Click(object sender, EventArgs e)
        {
            if (rbBireyselMusteri.Checked == true) //Bireysel Müşteri ekleniyorsa
            { 
                bool musteriTipi = true;
                string ad = txtMusteriAdi.Text;
                string soyad = txtMusteriSoyad.Text;
                string kullaniciAdi = txtMusteriNo.Text;
                string sifre = txtMusteriSifre.Text;
                DateTime tarih = dtKayitTarihi.Value;

                //butona basıldıktan sonra textboxlar temizleniyor.
                txtMusteriAdi.Clear();
                txtMusteriSoyad.Clear();
                txtMusteriNo.Clear();
                txtMusteriSifre.Clear();
                
                banka.MusteriEkle(musteriTipi, ad, soyad, kullaniciAdi, sifre, tarih);

                string rapor = kullaniciAdi + " kullanıcı adına sahip " + ad + " " + soyad + " kişisi Bireysel Müşteri olarak bankaya eklendi.";
                banka.RaporEkle(rapor, tarih);
            }

            else if (rbTicariMusteri.Checked == true) //Ticari Müşteri Ekleniyorsa
            {
                bool musteriTipi = false;
                string ad = txtMusteriAdi.Text;
                string soyad = txtMusteriSoyad.Text;
                string kullaniciAdi = txtMusteriNo.Text;
                string sifre = txtMusteriSifre.Text;
                DateTime tarih = dtKayitTarihi.Value;

                banka.MusteriEkle(musteriTipi, ad, soyad, kullaniciAdi, sifre, tarih);

                string rapor = kullaniciAdi + " kullanıcı adına sahip " + ad + " " + soyad + " kişisi Ticari Müşteri olarak bankaya eklendi.";
                banka.RaporEkle(rapor, tarih);
            }

            else //Müşteri tipi girilmemişse
            {
                MessageBox.Show("Lütfen müşteri tipini seçiniz.");
            }
        }

        private void sbtnHesapAc_Click(object sender, EventArgs e)
        {
            string musteriNo = txtMusteriHesapAcNo.Text;
            int ekBakiye = Convert.ToInt32(txtEkBakiye.Text);

            //Butona basıldıktan sonra textboxlar temzileniyor.
            txtMusteriHesapAcNo.Clear();
            txtEkBakiye.Clear();

            foreach (BireyselMusteri m in banka.BireyselMusteriler)//Müşteri bireysel müşteri mi kontrol ediyoruz
            {
                if (musteriNo == m.ID)
                {
                    m.HesapAc(ekBakiye);

                    string rapor = m.ID + " kullanıcı adına sahip Bireysel Müşteri için yeni hesap açıldı";
                    DateTime tarih = DateTime.Today;
                    banka.RaporEkle(rapor, tarih);
                }
            }
            foreach (TicariMusteri m in banka.TicariMusteriler)//Müşteri ticari müşteri mi kontrol ediyoruz
            {
                if (musteriNo == m.ID)
                {
                    m.HesapAc(ekBakiye);

                    string rapor = m.ID + " kullanıcı adına sahip Ticari Müşteri için yeni hesap açıldı";
                    DateTime tarih = DateTime.Today;
                    banka.RaporEkle(rapor, tarih);
                }
            }
        }

        private void stbnHesapSil_Click(object sender, EventArgs e)
        {
            int hesapNo = Convert.ToInt32(txtMusteriHesapSil.Text);

            txtMusteriHesapSil.Clear();

            foreach (BireyselMusteri m in banka.BireyselMusteriler)//Müşteri bireysel müşteri mi kontrol ediyoruz
            {
                foreach (Hesap h in m.hesaplar.ToList())//Her bir müşterinin hesaplar listesini tarayarak girilen hesap numarasına ait müşteriyi buluyoruz.
                {
                    if (hesapNo == h.No)
                    {
                        m.HesapSil(hesapNo);//Müşterinin HesapSil metodunu çalıştırıyoruz.

                        string rapor = m.ID + " kullanıcı adına sahip Bireysel Müşterinin " + hesapNo + " numaralı hesabı silindi.";
                        DateTime tarih = DateTime.Today;
                        banka.RaporEkle(rapor, tarih);
                    }
                }
            }

            foreach (TicariMusteri m in banka.TicariMusteriler)//Müşteri bireysel müşteri mi kontrol ediyoruz
            {
                foreach (Hesap h in m.hesaplar.ToList())
                {
                    if (hesapNo == h.No)
                    {
                        m.HesapSil(hesapNo);

                        string rapor = m.ID + " kullanıcı adına sahip Ticari Müşterinin " + hesapNo + " numaralı hesabı silindi.";
                        DateTime tarih = DateTime.Today;
                        banka.RaporEkle(rapor, tarih);
                    }
                }
            }
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

        private void txtMusteriAdi_KeyPress(object sender, KeyPressEventArgs e)//rakam girilmesini istemiyoruz
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void txtMusteriSoyad_KeyPress(object sender, KeyPressEventArgs e)//rakam girilmesini istemiyoruz
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void txtMusteriNo_KeyPress(object sender, KeyPressEventArgs e)//sadece rakam girilmesini istiyoruz
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtMusteriHesapAcNo_KeyPress(object sender, KeyPressEventArgs e)//sadece rakam girilmesini istiyoruz
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtEkBakiye_KeyPress(object sender, KeyPressEventArgs e)//sadece rakam girilmesini istiyoruz
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtMusteriHesapSil_KeyPress(object sender, KeyPressEventArgs e)//sadece rakam girilmesini istiyoruz
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
