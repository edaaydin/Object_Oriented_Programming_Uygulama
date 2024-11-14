// Enum : Gelistiriciler icin tasarlanan kod sabiti.

using _06_Enums;

Console.WriteLine(Renkler.Mavi);


// yada arka plandaki int degeri almak istersek casting aliriz.

Console.WriteLine((int)Renkler.Turuncu);

// Amac arka plandaki sayilar.

foreach (int item in Enum.GetValues(typeof(Renkler)))
{
    Console.WriteLine(item);
}
Console.WriteLine(new string('-', 25));

// Isimlerini almak istersem

foreach (string item in Enum.GetNames(typeof(Renkler)))
{
    Console.WriteLine(item);
}
Console.WriteLine(new string('-', 25));

foreach (string item in Enum.GetNames<Renkler>())
{
    Console.WriteLine(item);
}