namespace _01_Classes
{
    public class Firin
    {
        // class member - sınıf uyeleri
        // field,property,metot

        // property

        public string Marka { get; set; }

        public decimal Fiyat { get; set; }

        public int GarantiSuresi { get; set; }

        public bool GarantisiVarMi { get; set; }

        public DateTime CikisTarihi { get; set; }

        // Metot - aldıgı parametre kadar garanti suresini uzatsın.

        public void GarantiUzat(int uzatmaSuresi)
        {
            GarantiSuresi += uzatmaSuresi;
        }
        public Firin() //Constructor metot - yapıpcı / yapılandırıcı metot
        {
            Console.WriteLine("Yapicci metot calisti");
        }
        public Firin(string marka, bool uzamaVarMi, decimal fiyat)
        {
            Marka = marka;
            this.Fiyat = fiyat;
            GarantisiVarMi = uzamaVarMi;
        }
    }
}

