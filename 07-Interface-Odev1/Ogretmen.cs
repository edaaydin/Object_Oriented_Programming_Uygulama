namespace _07_Interface_Odev1
{
    internal class Ogretmen : IBirey, IOgretmen
    {
        public string Isim { get; set; }

        public void Bilgi()
        {
            Console.WriteLine($"{Isim} ismindeki ogretmenimiz okulumuzda ders vermektedir...");
        }

        public void DersAnlat()
        {
            Console.WriteLine($"{Isim} ismindeki ogretmenimiz fizik dersi anlatmaktadir...");
        }
    }
}
