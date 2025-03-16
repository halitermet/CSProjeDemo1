namespace CSProjeDemo2
{
    public class Yonetici : Personel
    {
        public double Bonus { get; set; }

        public Yonetici(string ad, int calismaSaati, double bonus)
            : base(ad, "Yönetici", 500, calismaSaati)
        {
            Bonus = bonus;
        }

        public override double MaasHesapla()
        {
            return (SaatlikUcret * CalismaSaati) + Bonus;
        }
    }
}
