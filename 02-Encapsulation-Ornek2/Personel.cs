namespace _02_Encapsulation_Ornek2
{
    public class Personel
    {
        /*
         Personel Class icin
        - Adý set ederken ilk harfi buyuk olsun.
         - Soyadýn ilk iki hanesi buyuk olsun hem de soyadýn buyuk harflerinden sonra geri kalanını * yapsýn ve listwiev da öyle gozuksun.
         - TC icin 11 karakter ve rakan kontrolunun yani sira listwievda son 2 karakter gozuksun ve oncesi * gozuksun yani listwiev da bu sekilde gozukmeli.
         */

        private string _ad;

        public string Ad
        {
            get { return _ad; }
            set { _ad = value.Substring(0, 1).ToUpper() + value.Substring(1).ToLower(); }
        }

        private string _soyad;

        public string Soyad
        {
            get { return _soyad; }
            set { _soyad = value.Substring(0, 2).ToUpper().PadRight(value.Length, '*'); }
        }
        private string _tc;

        public string Tc
        {
            get { return _tc; }
            set
            {
                if (value.Length != 11) throw new Exception("11 karakter yazmak zorundasin.");

                if (value.Any(char.IsLetter)) throw new Exception("Harf yazamazsiniz !");

                _tc = value.Substring(value.Length - 2).PadLeft(value.Length, '*');
            }
        }
    }
}
