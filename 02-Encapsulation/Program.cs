using _02_Encapsulation;

Musteri musteri = new Musteri();

//musteri.Id = 8; // set

musteri.Ad = "Ali";
musteri.Soyad = "Yilmaz";
musteri.Tc = "12345678910";


Console.WriteLine($"{musteri.Ad} -- {musteri.Soyad} -- {musteri.Id} -- {musteri.Mail} -- {musteri.Tc}"); // get
Console.ReadLine();