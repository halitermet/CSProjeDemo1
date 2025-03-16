using System;
using System.Globalization;
using System.IO;
using Newtonsoft.Json;

namespace CSProjeDemo2
{
    public static class MaasBordro
    {
        public static void BordroKaydet(Personel personel)
        {
            string ayYili = DateTime.Now.ToString("MMMM yyyy", new CultureInfo("tr-TR")).ToUpper();
            string klasorYolu = $"C:\\MaasBordro\\{personel.Ad}";
            string dosyaYolu = $"{klasorYolu}\\{ayYili}.json";

            if (!Directory.Exists(klasorYolu))
                Directory.CreateDirectory(klasorYolu);

            double anaOdeme = personel.SaatlikUcret * Math.Min(180, personel.CalismaSaati);
            double mesai = personel.CalismaSaati > 180 ? (personel.CalismaSaati - 180) * personel.SaatlikUcret * 1.5 : 0;
            double toplamOdeme = personel.MaasHesapla();

            CultureInfo culture = new CultureInfo("tr-TR");

            var bordro = new
            {
                MaasBordro = ayYili,
                PersonelIsmi = personel.Ad,
                CalismaSaati = personel.CalismaSaati,
                AnaOdeme = anaOdeme.ToString("C2", culture),
                Mesai = mesai.ToString("C2", culture),
                ToplamOdeme = toplamOdeme.ToString("C2", culture)
            };

            string json = JsonConvert.SerializeObject(bordro, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(dosyaYolu, json);

            Console.WriteLine($" Maaş bordrosu kaydedildi: {dosyaYolu}");
        }
    }
}
