namespace _06_Enums_Ornek3
{
    public abstract class BaseClass
    {
        public DateTime OlusturulmaTarihi { get; set; }

        // barkod - metot kontrol sonra atama

        private string _barkod;
        public string Barkod
        {
            get { return _barkod; }
            set
            { // kontrol
                bool sonuc = SanalDataBase.DbBarkodKontrol(value);

                if (sonuc)
                    throw new Exception("Icerde boyle bir barkod mevcut");
                else
                    _barkod = value;
            }
        }
        // id otomatik atamasını sagla

        static int sayac = 1; // sabit

        private int _id;

        public BaseClass()
        {
            _id = sayac;
            sayac++;

        }
        public int Id
        {
            get { return _id; }
            private set { }
        }
    }
}
