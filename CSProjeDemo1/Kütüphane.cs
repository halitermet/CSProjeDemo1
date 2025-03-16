using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1
{
    public class Kutuphane
    {
        public List<Kitap> Kitaplar { get; private set; }
        public List<Uye> Uyeler { get; private set; }

        public Kutuphane()
        {
            Kitaplar = new List<Kitap>();
            Uyeler = new List<Uye>();
        }

        public void KitapEkle(Kitap kitap)
        {
            Kitaplar.Add(kitap);
            Console.WriteLine($"{kitap.Baslik} kütüphaneye eklendi.");
        }

        public void UyeEkle(Uye uye)
        {
            Uyeler.Add(uye);
            Console.WriteLine($"Üye eklendi: {uye.Ad} {uye.Soyad}");
        }

        public void KutuphaneDurumunuGoster()
        {
            Console.WriteLine("\n Kütüphane Durumu ");
            foreach (var kitap in Kitaplar)
            {
                Console.WriteLine(kitap);
            }
        }
    }
}
