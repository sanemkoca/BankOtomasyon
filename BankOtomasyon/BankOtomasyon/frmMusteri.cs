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
    partial class frmMusteri : Form
    {
        public frmMusteri()
        {
            InitializeComponent();
        }

        public frmMusteri(Banka banka, BireyselMusteri BireyselM)//Bu form açıldığında giriş yapan müşteri bireysel ise bu constructor çalışır.
        {
            InitializeComponent();
            this.banka = banka;
            this.BireyselM = BireyselM;
            musteri = true;
        }

        public frmMusteri(Banka banka, TicariMusteri TicariM)//Bu form açıldığında giriş yapan müşteri ticari ise bu constructor çalışır.
        {
            InitializeComponent();
            this.banka = banka;
            this.TicariM = TicariM;
            musteri = false;
        }

        Banka banka;
        BireyselMusteri BireyselM;
        TicariMusteri TicariM;
        bool musteri;

        private void sbtnCek_Click(object sender, EventArgs e)//Para çekme butonu
        {
            int hesapNo = Convert.ToInt32(txtCekmeHesapNo.Text);
            decimal miktar = Convert.ToDecimal(txtCekmeMiktar.Text);

            txtCekmeHesapNo.Clear();//textboxlar butona tıklandıktan sonra temizleniyor.
            txtCekmeMiktar.Clear();

            foreach (BireyselMusteri m in banka.BireyselMusteriler)
            {
                foreach (Hesap h in m.hesaplar)
                {
                    if (hesapNo == h.No)
                        m.HesapParaCek(h, miktar);
                }
            }

            foreach (TicariMusteri m in banka.TicariMusteriler)
            {
                foreach (Hesap h in m.hesaplar)
                {
                    if (hesapNo == h.No)
                        m.HesapParaCek(h, miktar);
                }
            }
        }

        private void sbtnYatir_Click(object sender, EventArgs e)//Para yatırma butonu
        {
            int hesapNo = Convert.ToInt32(txtYatirHesapNo.Text);
            decimal miktar = Convert.ToDecimal(txtYatirMiktar.Text);

            txtYatirHesapNo.Clear();
            txtYatirMiktar.Clear();

            foreach (BireyselMusteri m in banka.BireyselMusteriler)
            {
                foreach (Hesap h in m.hesaplar)
                {
                    if (hesapNo == h.No)
                        m.HesapParaYatir(h, miktar);
                }
            }
            foreach (TicariMusteri m in banka.TicariMusteriler)
            {
                foreach (Hesap h in m.hesaplar)
                {
                    if (hesapNo == h.No)
                        m.HesapParaYatir(h, miktar);
                }
            }
        }

        private void sbtnGonder_Click(object sender, EventArgs e)//Havale gönderme butonu
        {
            int kaynakNo = Convert.ToInt32(txtKaynakHesap.Text);
            int hedefNo = Convert.ToInt32(txtHavaleHesap.Text);
            int miktar = Convert.ToInt32(txtHavaleMiktar.Text);

            txtKaynakHesap.Clear();
            txtHavaleHesap.Clear();
            txtHavaleMiktar.Clear();

            decimal bankaPayi = 0.0m, hedefPayi = 0.0m;
            decimal islemOrani = 0.0m;

            Hesap kaynakHesap = null, hedefHesap = null;
            Musteri kaynakMusteri = null;
            bool kaynakDurum = false, hedefDurum = false, kaynakHesapTuru = false;

            foreach (BireyselMusteri m in banka.BireyselMusteriler) //kaynak hesap bireysel müşteri iste
            {
                foreach (Hesap h in m.hesaplar)
                {
                    if (kaynakNo == h.No)
                    {
                        kaynakHesap = h;//Kaynak hesabı buluyoruz
                        kaynakMusteri = m;//Kaynak müşteriyi buluyoruz
                        kaynakDurum = true;
                        kaynakHesapTuru = true;
                    }
                    if (hedefNo == h.No)
                    {
                        hedefHesap = h;//hedef hesabı buluyoruz
                        kaynakMusteri = m;//Kaynak müşteriyi buluyoruz
                        hedefDurum = true;
                    }
                }
            }
            foreach (TicariMusteri m in banka.TicariMusteriler)//kaynak hesap ticari müşteri ise
            {
                foreach (Hesap h in m.hesaplar)
                {
                    if (kaynakNo == h.No)
                    {
                        kaynakHesap = h;
                        kaynakMusteri = m;
                        kaynakDurum = true;

                    }
                    if (hedefNo == h.No)
                    {
                        hedefHesap = h;
                        kaynakMusteri = m;
                        hedefDurum = true;
                    }
                }
            }

            if (kaynakDurum == true && hedefDurum == true)//Kaynak ve Hedef hesap numaraları bulunduysa
            {
                if (kaynakHesap.bakiye >= miktar)
                {
                    if (kaynakHesapTuru == true)
                        islemOrani = 2.0m;

                    kaynakHesap.bakiye -= miktar;
                    bankaPayi = (miktar * islemOrani) / 100;
                    hedefPayi = miktar - bankaPayi;
                    banka.toplamPara += bankaPayi;
                    MessageBox.Show("Hedef hesaba " + hedefPayi + " TL aktarılmıştır. \n Banka işlem ücreti: " + bankaPayi + " TL");

                    string rapor = kaynakNo + " numaralı hesaptan " + hedefNo + " numaralı hesaba " + hedefPayi + " TL aktarılmıştır. \n Banka işlem ücreti: " + bankaPayi + " TL";
                    DateTime tarih = DateTime.Today;
                    banka.RaporEkle(rapor, tarih);

                    rapor = kaynakNo + " numaralı hesabınızdan " + hedefNo + " numaralı hesaba " + hedefPayi + " TL aktarılmıştır. \n Banka işlem ücreti: " + bankaPayi + " TL";
                    kaynakHesap.RaporEkle(rapor, tarih);

                    rapor = kaynakNo + " numaralı hesaptan " + hedefNo + " numaralı hesabınıza " + hedefPayi + " TL aktarılmıştır.";
                    hedefHesap.RaporEkle(rapor, tarih);
                }

            }
            else
                MessageBox.Show("Lütfen Hedef ve Kaynak hesap numaralarını kontrol ediniz.");
        }

        private void sbtnOzetListele_Click(object sender, EventArgs e)//hesap özetini göstermek için
        {
            int hesapNo = 0;

            txtOzetHesapNo.Clear();

            if (txtOzetHesapNo.Text != "")//Hesap Özeti Listeleme TextViewi boş bırakılırsa hata vermemesi için
            {
                hesapNo = Convert.ToInt32(txtOzetHesapNo.Text);

                DateTime timeBaslangic = dtpBaslangic.Value;
                DateTime timeBitis = dtpBitis.Value;

                int BaslangicGun = timeBaslangic.Day;
                int BitisGun = timeBitis.Day;

                List<Rapor> GosterilecekRapor = new List<Rapor>();

                foreach (BireyselMusteri m in banka.BireyselMusteriler)
                {
                    foreach (Hesap h in m.hesaplar)
                    {
                        if (hesapNo == h.No)
                        {
                            foreach (Rapor r in h.RaporListesi)
                            {
                                TimeSpan t = timeBitis - r.tarih;//Seçilen bitiş tarihi ile işlem tarihi arasındaki farkı alıyoruz.
                                int baslangicDegeri = t.Days; //Farkı güne çeviriyoruz.

                                TimeSpan t2 = r.tarih - timeBaslangic;
                                int bitisDegeri = t2.Days;

                                if (baslangicDegeri >= 0 && bitisDegeri >= 0)//Eğer ki farklar - değer değilse yani belirtilen aralık arasındaysa 
                                {
                                    GosterilecekRapor.Add(r);
                                }
                            }
                        }
                    }
                }

                foreach (TicariMusteri m in banka.TicariMusteriler)
                {
                    foreach (Hesap h in m.hesaplar)
                    {
                        if (hesapNo == h.No)
                        {
                            foreach (Rapor r in h.RaporListesi)
                            {
                                TimeSpan t = timeBitis - r.tarih;
                                int baslangicDegeri = t.Days;

                                TimeSpan t2 = r.tarih - timeBaslangic;
                                int bitisDegeri = t2.Days;

                                if (baslangicDegeri >= 0 && bitisDegeri >= 0)
                                {
                                    GosterilecekRapor.Add(r);
                                }
                            }
                        }
                    }

                }
                dtgHesapOzet.DataSource = GosterilecekRapor;
            }
            else
                MessageBox.Show("Lütfen hesap numarası giriniz.");
        }

        private void sbtnHesapListele_Click(object sender, EventArgs e)//Hesapları listeleyen buton
        {
            if (musteri == true) //Giriş yapan bireysel müşteri ise
                dtgHesaplarim.DataSource = BireyselM.hesaplar;
            else
                dtgHesaplarim.DataSource = TicariM.hesaplar;
        }

        //Geri butonlarının kodları
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

        private void sbtnGeri4_Click(object sender, EventArgs e)
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

        private void sbtnGeri5_Click(object sender, EventArgs e)
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

        private void txtCekmeHesapNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtCekmeMiktar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtYatirHesapNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtYatirMiktar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtHavaleHesap_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtKaynakHesap_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtHavaleMiktar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtOzetHesapNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
