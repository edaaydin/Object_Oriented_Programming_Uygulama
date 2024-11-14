/*
1- İçinde id ve barkod, olusturma tarihi propları olan nesne almayan baseclass olusturunuz.(TAMAMLANDI!)

2- baseclass içinde barkoda atanırken içerde saltdatabase olmadıgına bakılsın sonra atansın(Metotla !!!)

3- id otomatik olarak kendi artsın.

4- baseclasstan kalıtımla oluşan urun sınıfı içine : marka model alışfiyatı satışfiyatı kampanyafiyatı propları olsun.(TAMAMLANDI!)

5- alışfiyatı 0 ve daha azı olmamalı, atanırken kontrol.(TAMAMLANDI!)

6- satış fiyatı, alıştan az ve satıstan çok olamaz.(TAMAMLANDI!)

-Kampanya fiyati ise alıstan az ve satıstan cok olamaz. (TAMAMLANDI!)

7- urunden tureyen sınıf yani tv sınıfı kendi içinde extra olarak akıllıtv mi ? hdmı var mı? ekran boyutu proplarını barındırır.(TAMAMLANDI!)

8- yine üründen tureyen bilgisayar sınıfı kendi içinde işlemcihazı hafıza propları barındırır.(TAMAMLANDI!)

9- sanaldatabase sınıfı içinde sonuc enumı tipinde donus yapan ve arrayliste nesne eklememizi sağlayan ekleme metodu yazınız. metot tv,bilgisayar,urun olabilir..)

10- metot içinde parametrenin boş olması yada barkodunun boş olup olmaması kontrol etsin, ona gore sonuc dondursun.

11- Yine bu sınıf içinde barkodun arraylistte daha önce kullanılıp kullanılmadıgını bool döen metot yazınız kiii nesnelere barkod eklerken bu metot iş yapsın !!!
 */

using _06_Enums_Ornek3;

try
{
    Bilgisayar bilgisayar = new Bilgisayar()
    {
        Marka = "Lenovo",
        Model = "K200",
        AlisFİyati = 100,
        SatisFiyati = 200,
        KampanyaFiyati = 150,
        Barkod = "123"

    };
    SanalDataBase.YeniUrunEkle(bilgisayar);

    Tv tv = new Tv()
    {
        Marka = "Samsung",
        Model = "K200",
        AlisFİyati = 100,
        SatisFiyati = 200,
        KampanyaFiyati = 150,
        Barkod = "123"
    };
    Console.WriteLine(SanalDataBase.YeniUrunEkle(tv));
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
