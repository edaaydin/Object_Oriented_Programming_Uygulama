using _07_Interface;

List<IDeneme> denemes = new List<IDeneme>();

Ogrenci ogrenci = new Ogrenci();
Insan insan = new Insan();

ogrenci.Goster();

denemes.Add(insan);
denemes.Add(ogrenci);

/*
Interface(Arayüz) : İçinde kendinden implementasyon yapacak sınıfların kullanacagı metot yada propları barındırır.

katı kontrat mantıgında gittigi yerde kendini muhakkak acıklatır

o zaman soru : abstract sınıf içindeki abs. metot da interface aynı katı kontrat mantıgına sahipse biri varsa digeri neden var ?

- Erisim belirleyicisi public olabilir
- kurucu metot icermez
- Artık metot govdesi yazılabiliyor ? ama neden ve nasıl ?
- Sadece arayuzlerden kalıtım alabilir.
- Bir sınıf birden fazla interface implementasyon yapabilir.
- interface içinde field kullanmayız.
 */

