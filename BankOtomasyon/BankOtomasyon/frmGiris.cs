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
    partial class frmGiris : Form
    {
        public frmGiris(Banka banka)
        {
            InitializeComponent();
            this.banka = banka;
        }

        Banka banka;


        private void frmGiris_Load(object sender, EventArgs e)
        {

        }

        private void sbtnYoneticiGiris_Click(object sender, EventArgs e)
        {
            Form1 f1 = Application.OpenForms["Form1"] as Form1;
            Panel panel1 = f1.Controls["panel1"] as Panel;
            panel1.Controls.Clear();

            frmYonetici formYonetici = new frmYonetici(banka);
            formYonetici.TopLevel = false;

            panel1.Controls.Add(formYonetici);

            formYonetici.Show();
            formYonetici.Dock = DockStyle.Fill;
        }

        private void sbtnPersonelGiris_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;

            foreach (Personel p in banka.personeller)
            {
                if (kullaniciAdi == p.ID && sifre == p.Sifre)
                {
                    Form1 f1 = Application.OpenForms["Form1"] as Form1;
                    Panel panel1 = f1.Controls["panel1"] as Panel;
                    panel1.Controls.Clear();

                    frmPersonel formPersonel = new frmPersonel(banka);
                    formPersonel.TopLevel = false;

                    panel1.Controls.Add(formPersonel);

                    formPersonel.Show();
                    formPersonel.Dock = DockStyle.Fill;

                    MessageBox.Show("Hoşgeldiniz. Sayın " + p.Ad + " " + p.Soyad);
                }
            }
        }

        private void sbtnMusteriGiris_Click(object sender, EventArgs e)
        {
            string musteriNo = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;

            foreach (BireyselMusteri m in banka.BireyselMusteriler)
            {
                if (musteriNo == m.ID && sifre == m.Sifre)
                {
                    Form1 f1 = Application.OpenForms["Form1"] as Form1;
                    Panel panel1 = f1.Controls["panel1"] as Panel;
                    panel1.Controls.Clear();

                    frmMusteri formMusteri = new frmMusteri(banka, m);
                    formMusteri.TopLevel = false;

                    panel1.Controls.Add(formMusteri);

                    formMusteri.Show();
                    formMusteri.Dock = DockStyle.Fill;

                    MessageBox.Show("Hoşgeldiniz Sayın " + m.Ad + " " + m.Soyad);
                }
            }
            foreach (TicariMusteri m in banka.TicariMusteriler)
            {
                if (musteriNo == m.ID && sifre == m.Sifre)
                {
                    Form1 f1 = Application.OpenForms["Form1"] as Form1;
                    Panel panel1 = f1.Controls["panel1"] as Panel;
                    panel1.Controls.Clear();

                    frmMusteri formMusteri = new frmMusteri(banka, m);
                    formMusteri.TopLevel = false;

                    panel1.Controls.Add(formMusteri);

                    formMusteri.Show();
                    formMusteri.Dock = DockStyle.Fill;

                    MessageBox.Show("Hoşgeldiniz Sayın " + m.Ad + " " + m.Soyad);
                }
            }
        }
    }
}
