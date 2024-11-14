namespace _07_Interface_Odev1
{
    internal class Ogrenci : IBirey, IOgrenci
    {
        public string Isim { get; set; }

        public void Bilgi()
        {
            Console.WriteLine($"{Isim} ismindeki ogrencimiz");
         
        }

        public void DerCalis()
        {
            Console.WriteLine($"{Isim} ismindeki ogrencimiz desr calisiyor...");
        }

        public void DersAnlat()
        {
            throw new NotImplementedException();
        }
    }
}
