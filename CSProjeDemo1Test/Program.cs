using System;
using CSProjeDemo1;  

class Program
{
    static void Main()
    {     
        Kutuphane kutuphane = new Kutuphane();

        Uye uye1 = new Uye("Ahmet", "Kaya", 1);
        kutuphane.UyeEkle(uye1);

        KitapBilim bilimKitabi = new KitapBilim("123456", "Bilim Dünyası", "Ali Veli", 2020);
        kutuphane.KitapEkle(bilimKitabi);

        uye1.KitapOduncAl(bilimKitabi);

        uye1.OduncAlinanKitaplariGoster();

        uye1.KitapIadeEt(bilimKitabi);

        kutuphane.KutuphaneDurumunuGoster();
    }
}
