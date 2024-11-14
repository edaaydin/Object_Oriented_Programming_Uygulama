namespace _07_Interface
{
    public interface INotHesapla
    {
        public double GecmeNotu { get; set; } // static nasıl kullanılıyor ? kullanma amacı nedir?

        public double OgrenciOrtalama { get; set; }

        public void OgrenciDurumu(double puan);
    }

    public interface IDeneme
    {
        void Goster(); // Neden govdelerini acikliyoruz, nasıl kullanıyoruz.
    }
    // Abstarct bir kere kullanılırken interface ise farklı turden çok kez kullanılır.(multıİnheritance)
    public class Insan : INotHesapla, IDeneme
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public double GecmeNotu { get; set; }
        public double OgrenciOrtalama { get; set; }

        public void Goster()
        {
            throw new NotImplementedException();
        }

        public void OgrenciDurumu(double puan)
        {
            throw new NotImplementedException();
        }
    }
    public class Ogrenci : Insan // to do : ıdeneme tipinden biri istendiginde ogrenci gidebilir mi ?
    {

    }
}
