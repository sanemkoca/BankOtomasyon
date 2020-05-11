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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOtomasyon
{
    class Hesap : IRaporOzellikleri
    {
        public int No { get; set; }
        public decimal bakiye { get; set; }
        public decimal gunlukLimit { get; set; }
        public decimal limit { get; set; }
        public decimal ekBakiye { get; set; }

        public List<Rapor> RaporListesi; //Hesaba ait işlemleri(Havale işlemleri gibi) tutabilmemiz için oluşturuldu.

        Rapor r;

        public Hesap()
        {
            RaporListesi = new List<Rapor>();
        }

        public void RaporEkle(string rapor, DateTime tarih)
        {
            r = new Rapor();

            this.r.rapor = rapor;
            this.r.tarih = tarih;
            RaporListesi.Add(r);
        }
    }
}
