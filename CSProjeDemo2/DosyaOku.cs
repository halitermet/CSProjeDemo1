using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace CSProjeDemo2
{
    public static class DosyaOku
    {
        public static List<Personel> PersonelListesiOku(string dosyaYolu)
        {
            List<Personel> personeller = new List<Personel>();

            try
            {
                string json = File.ReadAllText(dosyaYolu);
                var personelListesi = JsonConvert.DeserializeObject<List<dynamic>>(json);

                foreach (var p in personelListesi)
                {
                    string ad = p.name;
                    string title = p.title;
                    int calismaSaati = new Random().Next(140, 200);

                    if (title == "Yonetici")
                    {
                        personeller.Add(new Yonetici(ad, calismaSaati, 2000.0));
                    }
                    else if (title == "Memur")
                    {
                        personeller.Add(new Memur(ad, calismaSaati));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($" Dosya okunurken hata oluştu: {ex.Message}");
            }

            return personeller;
        }
    }
}
