namespace _03_Inheritance
{
    internal class Ogrenci : Kisi
    {
        public int OgrenciNo { get; set; }
        public string Fakulte { get; set; }
        public string Bolum { get; set; }
        public Ogrenci() : base() // Constructor chaning - Zincirleme Const.
        {
            Console.WriteLine("Tureyen sinifin constructor'udur.");
        }

        public Ogrenci(string ad) : base(ad) // Atasının const'unu tetikler.
        {
            Console.WriteLine("Tureyen sinifin parametreli constructor'udur.");
        }
        public override void MesajVer()
        {
            Console.WriteLine("Ogrencinin override edilmis metodu.");
        }
    }
}
