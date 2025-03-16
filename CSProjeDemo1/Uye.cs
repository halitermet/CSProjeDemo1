using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1
{
    public class Uye : IUye
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int UyeNumarasi { get; private set; }
        public List<Kitap> OduncAlinanKitaplar { get; private set; }

        public Uye(string ad, string soyad, int uyeNumarasi)
        {
            Ad = ad;
            Soyad = soyad;
            UyeNumarasi = uyeNumarasi;
            OduncAlinanKitaplar = new List<Kitap>();
        }

        public bool KitapOduncAl(Kitap kitap)
        {
            if (kitap.KitapDurumu == Durum.OduncAlabilir)
            {
                kitap.KitapDurumuGuncelle(Durum.OduncVerildi);
                OduncAlinanKitaplar.Add(kitap);
                Console.WriteLine($"{kitap.Baslik} ödünç alındı.");
                return true;
            }
            Console.WriteLine($"{kitap.Baslik} ödünç alınamaz.");
            return false;
        }

        public bool KitapIadeEt(Kitap kitap)
        {
            if (OduncAlinanKitaplar.Contains(kitap))
            {
                kitap.KitapDurumuGuncelle(Durum.OduncAlabilir);
                OduncAlinanKitaplar.Remove(kitap);
                Console.WriteLine($"{kitap.Baslik} iade edildi.");
                return true;
            }
            Console.WriteLine($"{kitap.Baslik} bu üye tarafından ödünç alınmamış.");
            return false;
        }

        public void OduncAlinanKitaplariGoster()
        {
            Console.WriteLine($"Üye: {Ad} {Soyad} - Ödünç Aldığı Kitaplar:");
            foreach (var kitap in OduncAlinanKitaplar)
            {
                Console.WriteLine($"- {kitap}");
            }
        }
    }
}
