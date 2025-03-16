using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1
{
    public interface IUye
    {
        string Ad { get; set; }
        string Soyad { get; set; }
        int UyeNumarasi { get; }
        List<Kitap> OduncAlinanKitaplar { get; }

        bool KitapOduncAl(Kitap kitap);
        bool KitapIadeEt(Kitap kitap);
        void OduncAlinanKitaplariGoster();
    }
}
