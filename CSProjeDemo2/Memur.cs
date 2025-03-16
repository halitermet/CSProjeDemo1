namespace CSProjeDemo2
{
    public class Memur : Personel
    {
        public Memur(string ad, int calismaSaati, double saatlikUcret = 500)
            : base(ad, "Memur", saatlikUcret, calismaSaati)
        {
        }

        public override double MaasHesapla()
        {
            int normalSaat = Math.Min(CalismaSaati, 180);
            int fazlaMesai = Math.Max(0, CalismaSaati - 180);
            return (normalSaat * SaatlikUcret) + (fazlaMesai * SaatlikUcret * 1.5);
        }
    }
}
