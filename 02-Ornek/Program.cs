// ad, soyad, dogum tarihi, sinif, cinsiyet(bool) bilgilerini tutunuz.

// Ogrencinin adı soyadı olmadan olusturmayınız.

// aynı zamanda sınıf içine gelen dogum tarihi bilgisine göre yas hesaplayan metodu olusturunuz. 

// Yine class icindeki bir metotla ogrencinin tum bilgilerini ekrana basan metodu olusturunuz.

// program.cs te nesne olusturup bilgilerini basan metotla tum bilgileri basınız.


using _02_Ornek;
using System.Drawing;

Ogrenci ogrenci = new Ogrenci("Eda", "Aydın");
ogrenci.Cinsiyet = false;
ogrenci.Sinif = "7";
ogrenci.DogumTarihi = new DateTime(2003, 3, 26);
ogrenci.TumBilgiler();














