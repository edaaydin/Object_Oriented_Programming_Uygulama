namespace _06_Enums_Ornek3
{
    public class Urun : BaseClass
    {
        // marka model alışfiyatı satışfiyatı kampanyafiyatı propları olsun.

        public string Marka { get; set; }
        public string Model { get; set; }

        private int _alisFiyati;

        public int AlisFİyati
        {
            get { return _alisFiyati; }
            set
            {
                if (value <= 0)
                    throw new Exception("Alis Fiyati 0'dan Kucuk Olamaz !");
                else
                    _alisFiyati = value;
            }
        }
        private int _satisFiyati;
        public int SatisFiyati
        {
            get
            {
                return _satisFiyati;
            }
            set
            {
                if (value < _alisFiyati)
                    throw new Exception("Alis Fiyati 0'dan Kucuk Olamaz !");

                else
                    _satisFiyati = value;
            }
        }
        private int _kampanyaFiyati;
        public int KampanyaFiyati
        {
            get { return _kampanyaFiyati; }
            set
            // Kampanya fiyati ise alıstan az ve satıstan cok olamaz.
            {
                if (value > _alisFiyati && value < _satisFiyati)
                    _kampanyaFiyati = value;
                else
                    throw new Exception("Kampanya Fİyati Alis fiyatindabn Az ve Satis Fiyatindan Cok Olamaz.");
            }
        }
    }
}
