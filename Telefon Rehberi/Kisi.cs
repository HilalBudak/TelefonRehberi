using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneme_11
{
    class Kisi
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Tckn { get; set; }
        public string Aciklama { get; set; }
        public DateTime DogumTarihi { get; set; }
        public int EgitimDurumuID { get; set; }
        public string Cinsiyet { get; set; }
        public int sektorid { get; set; }

        public void KisiKaydet(Kisi kisi, out int kisi_id, out string sonuc)
        {
            HelinWBS.HelinService serv = new HelinWBS.HelinService();
            kisi_id = 0;
            sonuc = "";

            kisi_id = serv.KisiKaydet(kisi.Ad, kisi.Soyad, kisi.Tckn, kisi.Aciklama,kisi.DogumTarihi, kisi.EgitimDurumuID,kisi.
                                      Cinsiyet,kisi.sektorid, out sonuc);
        }
    }

    class Cinsiyet
    {
        public string cinsiyet { get; set; }
    }
}
