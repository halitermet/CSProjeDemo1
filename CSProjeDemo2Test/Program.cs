using System;
using System.Collections.Generic;
using System.IO;
using CSProjeDemo2;

class Program
{
    static void Main()
    {
        string jsonDosyaYolu = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "personeller.json");

        if (!File.Exists(jsonDosyaYolu))
        {
            Console.WriteLine($" Hata: {jsonDosyaYolu} bulunamadı.");
            return;
        }

        List<Personel> personeller = DosyaOku.PersonelListesiOku(jsonDosyaYolu);

        Console.WriteLine("\n Maaş Bordro Sistemi \n");

        foreach (var personel in personeller)
        {
            MaasBordro.BordroKaydet(personel);
            Console.WriteLine(personel);
        }

        Console.WriteLine("\n 150 Saatten Az Çalışan Personeller ");
        foreach (var personel in personeller)
        {
            if (personel.CalismaSaati < 150)
            {
                Console.WriteLine($"- {personel.Ad} ({personel.CalismaSaati} saat çalıştı)");
            }
        }

        Console.WriteLine("\n Tüm işlemler tamamlandı. Çıkış yapmak için bir tuşa basın...");
        Console.ReadKey();
    }
}
