using System;
using System.Globalization;

namespace CSProjeDemo2
{
    public abstract class Personel
    {
        public string Ad { get; set; }
        public string Unvan { get; set; }
        public double SaatlikUcret { get; set; }
        public int CalismaSaati { get; set; }

        public Personel(string ad, string unvan, double saatlikUcret, int calismaSaati)
        {
            Ad = ad;
            Unvan = unvan;
            SaatlikUcret = saatlikUcret;
            CalismaSaati = calismaSaati;
        }

        public abstract double MaasHesapla();

        public override string ToString()
        {
            CultureInfo culture = new CultureInfo("tr-TR");
            return $"{Ad} - {Unvan} - Çalışma Saati: {CalismaSaati} - Maaş: {MaasHesapla().ToString("C2", culture)}";
        }
    }
}
