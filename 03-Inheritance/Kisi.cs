namespace _03_Inheritance
{
    // MultiInheritance : Coklu katilim.
    public class Kisi
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Cinsiyet { get; set; }
        public double Boy { get; set; }
        public Kisi()
        {
            Console.WriteLine("Ben temel sinifin kurucusuyum.");
        }
        public Kisi(string ad)
        {
            Console.WriteLine("Ben Temel sinifin parametreli kurucusuyum.");
        }

        public void BilgileriGoster()
        {
            Console.WriteLine($"Kisinin Adi : {Ad} - Soyadi : {Soyad} - Cinsiyet : {Cinsiyet} ");
        }

        // Virtual : Kalıtımla aktarıldıgı yerde istenirse override edilebilir yani ezilecek metodun govdesi istenildigi gibi sekillendirilir yada hic dokunulmaz ve oldugu gibi kabul edilip calısmaya devam eder.
         public virtual void MesajVer()
        {
            Console.WriteLine("Ben temel sınıfın virtual metoduyum");
        }
    }
}
