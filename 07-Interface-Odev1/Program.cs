/*
1- Interface (Arayüz) Nedir ?

- Bir sınıfın yada yapının belli bir yeteneklere sahip olmasını garanti eder ancak bu yeteneklerin nasıl uygulanacagını sınıflarda belirler.
- Referans turlu degiskenlerdir.
- I ile baslaması = name convertions gelenegidir.

Name Convertions = Programlamada ve yazılım geliştirmede kullanılan adlandırma standartlarını ifade eder.
Sınıflar ve Yapılar: Pascal Case
Arayüzler: Pascal Case, ancak I ile başlamalıdır.
Metotlar: Pascal Case
Değişkenler ve Alanlar: Camel Case
Sabitler: UPPER_CASE 

- İnterface'ler, sınıfların imzasıdır nedeni ise sudur : İnterfacelerin nesnelerinin olmamasından kaynaklıdır. boylece maliyeti daha dusuktur.
- İnterfacelerin erisim belirleyicisi public olmak zorundadır. Cunku metoda dısardan ulasılması gerekir.
- Interface'ler kurucu metot içermez çünkü bir interface'in amacı sadece kurallar (imzalar) belirtir ve bunları sınıflarda uygulatır. Kurucu metotlar ise bir sınıfın nasıl oluşturulacağını belirler, bu yüzden abstract sınıflar kurucu metot içerebilirken interface'ler içermez.

Soru : Artık Metot Gövdesi Yazılabiliyor? Neden ve Nasıl?

- C# 8.0 ile birlikte interface'lere varsayılan metotlar eklenebilmiştir bunlara default implementation denir. 
- Yeni bir metot eklenmesi gerektiğinde, o interface'i implement eden tüm sınıflarda değişiklik yapmadan yeni davranışlar kazandırabiliriz. Normal sartlarda govde tanımlanmazken govde tanımlarız ve bunu da farklı classta override ederek kullanabiliriz. Ama interfacedeki gibi bu interfaceyi (default implementation) classta tanımlayıp kullanmak zorunda degiliz ! Yani bu sayede mevcut kodlar bozulmadan yeni özellikleri ekleyip kullanabiliriz.

- Bir sınıf birden fazla interface alabilir (coklu davranıs bicimi) ancak bir sınıf sadece bir sınıftan kalıtım alır ..!

- İnterfaceler birbirlerine kalıtım verebilirler.

- Bir class farklı bir class'tan kalıtım alırken bir yandan da birden fazla interface'i implement edebilir.

Soru : Abstract sınıf içindeki abs. metot da interface de aynı katı kontrat mantıgına sahipse biri varsa digeri neden var ?

- Her ikisi de "katı kontrat" (strict contract) kavramını temsil eder, yani bu yapılar kullanıldığı sınıflara belirli kurallar koyar.

- Interface: İçinde sadece imzalar (signature) vardır, bu imzalar bir sınıf tarafından implement edilmelidir.
- Neden var? Interface'ler, birbirinden tamamen bağımsız sınıflar arasında ortak bir kontrat oluşturmak için kullanılır. Interface, implement edildiği sınıfa zorunlu olarak uygulaması gereken kuralları belirtir. Çoklu kalıtım desteklemez, fakat çoklu implementasyonu (bir sınıf birden fazla interface'ten türeyebilir) destekler.

- Abstract Sınıf: İçinde hem tam tanımlı (gövdesi olan) hem de tanımsız (sadece imza olan) metotlar bulunabilir.
- Neden var? Abstract sınıflar, temelde bir sınıf hiyerarşisinde ortak özelliklerin ve davranışların tanımlanması için kullanılır. Eğer belirli bir davranışın tüm alt sınıflar tarafından aynı şekilde yapılması gerekiyorsa, bu davranışı abstract sınıf içinde tanımlayabilirsiniz.

Soru : Abstraction class ta static prop kullanılır mıydı ? 

- Evet, abstrakt sınıflarda (abstract class) static özellikler (properties) ve static metotlar tanımlanabilir. Abstrakt sınıflar, soyut bir yapı sunar ve içinde hem soyut (abstract) hem de somut (concrete) üyeleri barındırabilir.

- Static Üyeler: Static üyeler (özellikler veya metotlar) sınıfın kendisine aittir ve bir örnek (instance) oluşturmadan erişilebilir. Bu, tüm örnekler için ortak olan bir durumu temsil eder.
- Static Üyelerin Kullanımı: Abstrakt bir sınıfta tanımlanan static üyeler, doğrudan sınıf adı ile erişilir. Örnek bir nesne oluşturmaya gerek yoktur.
- Soyut Üyeler: Static üyeler, soyut olamaz. Yani, bir static metot veya özellik, soyut olarak tanımlanamaz.

soru :   public class Ogrenci : Insan // to do : ıdeneme tipinden biri istendiginde ogrenci gidebilir mi ?

- Evet, bir sınıf bir arayüzü (interface) implement ettiğinde, o sınıfın örneği (nesnesi), o arayüz tipinden bir nesne olarak kullanılabilir. Bu, arayüz (interface) implementasyonunun temel işlevlerinden biridir ve polymorphism (çok biçimlilik) denilen nesne yönelimli programlamanın bir özelliği ile ilgilidir. ve miras alıp kullanabilir.
  

Soru : void Goster(); // Neden govdelerini acikliyoruz, nasıl kullanıyoruz.

- void Goster(); gibi bir tanım, bir interface veya soyut sınıf içindeki soyut (abstract) metot tanımını ifade eder. Bu tür bir metot, ilgili sınıfların bu metodu implement etmelerini zorunlu kılar.

--- Neden Gövdeyi Açıklıyoruz?
- Soyut bir metot, yalnızca başlık kısmıyla tanımlanır ve metodun gövdesi (içeriği) tanımlanmaz. Bu, alt sınıfların bu metodu kendilerine göre nasıl implement edeceklerini belirlemeleri için bir fırsat sunar.
- Soyut metotlar, polymorphism (çok biçimlilik) özelliğini kullanarak, üst sınıf referanslarının alt sınıf nesneleriyle çalışmasına olanak tanır. Bu, uygulamanın esnekliğini artırır.
- Bir sınıf, bir interface veya soyut sınıfı implement ettiğinde, ilgili soyut metotları tanımlamak zorundadır. Bu, belirli bir işlevselliği garanti eder.

Soru : public double GecmeNotu { get; set; } // static nasıl kullanılıyor ? kullanma amacı nedir?

- Static Özellik: static anahtar kelimesi ile tanımlanan bir özellik, sınıfın kendisine ait olup, sınıfın tüm örnekleri tarafından paylaşılır.
- Neden Kullanılır? Genellikle sınıf düzeyindeki değerleri tutmak için kullanılır. Örneğin, tüm öğrenciler için ortak bir geçme notu veya sınıf düzeyinde bir sayaç gibi.
- static özellikler, bir sınıfın tüm örnekleri arasında paylaşılan değerleri saklamak için kullanılır. Bu özelliklerin amacı, genel bilgileri yönetmek ve sınıf düzeyinde belirli bir durumu temsil etmektir. Özellikle aynı bilgiyi birçok nesnede tutmak gerektiğinde kullanılır.

Ozetlemek Gerekirse;

INTERFACE

- Govde icermez, imza barındırır ancak C# 8.0 versiyonuyla birlikte metotlarda govde tanımlayabiliyoruz.
- Coklu implementasyon destegi saglar, field ve ctor icermez.
- Sadece public'tir ancak istisnai bir durum da Explicity İmplement edildiginde private olarak tanımlanabiliyor.
- Sııflara yetenek kazandırır.

ABSTRACT CLASS

- Hem govdeli hem govdesiz sekilde tanımlanabilir.
- tek bir abstract class'ta turer. Field ve ctor icerebilir.
- Her turden erisim belirleyicisi olabilir.
- Ortak ozellik ve davranısları paylasır.
 */

using _07_Interface_Odev1;

Ogrenci ogrenci = new Ogrenci()
{
    Isim = "Eda"
};
ogrenci.Bilgi();
ogrenci.DerCalis();

Console.WriteLine("*******************************************************");

Ogretmen ogretmen = new Ogretmen();
ogretmen.Isim = "Eda";
ogretmen.Bilgi();
ogretmen.DersAnlat();