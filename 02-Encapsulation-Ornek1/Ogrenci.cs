namespace _02_Encapsulation_Ornek1
{
    public class Ogrenci
    {
        private int sayi;
        public Ogrenci()
        {
            Random random = new Random();
            sayi = random.Next(1000, 9999);
        }

        // ad okunurken ilk karakter buyuk digerleri kucuk olsun.
        private string _ad;

        public string Ad
        {
            get { return _ad; }
            set
            {
                _ad = value.Substring(0, 1).ToUpper() + value.Substring(1).ToLower();
            }
        }

        // Soyad degeri okunurken tum harfler buyuk olsun.
        private string _soyAd;

        public string Soyad
        {
            get { return _soyAd.ToUpper(); }
            set { _soyAd = value; }
        }

        public string Sinif { get; set; }
        public string Bolum { get; set; }

        private string _ogrNo;

        public string _ogrNoOgrNo
        {
            get
            {
                return _ogrNo = Bolum.Substring(0, 1).ToUpper() + Sinif + sayi;
            }
            private set { }
        }
    }
}


/*
- Bir ogrenci nesnesi olusturulacak ad, soyad, sınıf, ogrenci no propertyleri olacak. TAMAMLANDI!

- Girilen ad degeri set edilirken ilk harfi buyuk digerleri kucuk olacak sekilde set edilsin. TAMAMLANDI!

- Soyad degeri okunurken tum harfler buyuk olsun. TAMAMLANDI!

- Ogrenci no'ya deger ataması dısardan yapılmasın.

- Ogrenci no olarak bolumunun ilk harfi+sinif+rastgele bir sayi olarak oluşsun.
 */
