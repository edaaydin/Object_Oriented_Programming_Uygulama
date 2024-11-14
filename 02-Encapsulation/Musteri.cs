using System.IO.Pipes;

namespace _02_Encapsulation
{
    public class Musteri
    {
        // Field'a deger ataması disaridan yapılmasın ama okunabilsin
        // id rastgele deger atayalim

        public Musteri()
        {
            Idatama();
        }

        private void Idatama()
        {
            Random random = new Random();
            _id = random.Next(1000, 9999);
        }

        private int _id;

        public int Id
        {
            get { return _id; }
            private set { _id = value; }
        }

        // E-mail'e kimse deger atamasın ama soyadına deger atandıgında otomatik olarak formatlı atama yapılsın.

        private string _mail;

        public string Mail
        {
            get { return _mail; }
            private set { }
        }

        public string Ad { get; set; }
        // deger atama ve okuma islemleri yapılsın ancak okurken butun harfleri buyuk okusun ve tabiki okuduktan sonrada maili olustursun.

        private string _soyad;

        public string Soyad
        {
            get { return _soyad.ToUpper(); }
            set
            {
                _soyad = value;
                _mail = string.Format("{0}.{1}@gmail.com", Ad, _soyad);
            }
        }

        // tc'ye deger atamasi yapisin ama once 11 karakter kontrolu ve karakterlerin gercekten rakan olup olması kontrolu yapılsın.

        // okurken de sadece ilk 3 karakteri gosterilsin digerlerinin yerine * koyulsun.

        private string _tc;

        public string Tc
        {
            get { return _tc.Substring(0, 3).PadRight(11, '*'); }
            set
            {
                if (value.Length == 11)
                {
                    for (int i = 0; i < 11; i++)
                    {
                        bool karakterKontrol = char.IsNumber(value[i]);
                        if (!karakterKontrol)
                        {
                            throw new ArgumentException("Rakam olmak zorunda !");
                        }

                        else
                        {
                            _tc = value;
                        }
                    }
                }
                else
                {
                    throw new Exception("11 karakter yazmak zorundasiniz !");
                }
            }
        }
    }
}
