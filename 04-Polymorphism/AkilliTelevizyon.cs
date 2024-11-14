using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Polymorphism
{
    // Pollymorphism : Aynı metodun/yetenegin iliski sınıflar icinde farklı kullanılabiliyor olması.
    internal class AkilliTelevizyon : Televizyon
    {
        public override void EkranaYaz(string data)
        {
            Console.WriteLine($"Akilli TV : {data}");

        }
    }
}
