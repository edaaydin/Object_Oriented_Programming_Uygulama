namespace _02_Ornek
{
    public class Ogrenci
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Sinif { get; set; }
        public DateTime DogumTarihi { get; set; }
        public bool Cinsiyet { get; set; }

        public Ogrenci(string ad, string soyad)
        {
            Ad = ad;
            Soyad = soyad;
        }

        public int YasHesapla()
        {
            return DateTime.Now.Year - DogumTarihi.Year;
        }
        public void TumBilgiler()
        {
            Console.WriteLine($"{Ad} {Soyad} adli ogrencimiz {Sinif} sinifindaki ogrencinin dogum tarihi : {DogumTarihi}" +
                $" ve haliyle yasi : {YasHesapla()} ve Cinsiyet Bilgisi : {(Cinsiyet ? "Erkek" : "Kadin")}");
        }
    }
}
// ad, soyad, dogum tarihi, sinif, cinsiyet(bool) bilgilerini tutunuz. YAPILDI!

// Ogrencinin adı soyadı olmadan olusturmayınız. YAPILDI!

// aynı zamanda sınıf içine gelen dogum tarihi bilgisine göre yas hesaplayan metodu olusturunuz.  YAPILDI!

// Yine class icindeki bir metotla ogrencinin tum bilgilerini ekrana basan metodu olusturunuz.  YAPILDI!

// program.cs te nesne olusturup bilgilerini basan metotla tum bilgileri basınız.