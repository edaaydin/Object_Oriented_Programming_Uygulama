using _03_Inheritance;

Kisi kisi = new Kisi()
{
    Ad = "Ali",
    Soyad = "Yılmaz",
    Boy = 1.63,
    Cinsiyet = "Erkek"
};
kisi.MesajVer();

Console.WriteLine(new string('*', 30));

Ogrenci ogrenci = new Ogrenci()
{
    Ad = "Ece",
    Soyad = "Sen",
    Cinsiyet = "Kadin",
    Fakulte = "Muhendislik",
    Bolum = "Makine"
};

Console.WriteLine(new string('*', 30));
Ogrenci ogrenci1 = new Ogrenci("Ayse");

// ogrenci.MesajVer();

List<Kisi> kisilerim = new List<Kisi>();
kisilerim.Add(kisi);
kisilerim.Add(ogrenci);
kisilerim.Add(ogrenci1);

foreach (Kisi item in kisilerim)
{


    if (item is Ogrenci)
    {
        Console.WriteLine($"Ad : {item.Ad} - Bolum : {((Ogrenci)item).Bolum}");
    }

}

