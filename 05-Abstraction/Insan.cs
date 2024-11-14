using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Abstraction
{
    internal class Insan : Hayvan
    {
        public override void SinifGoster()
        {
            Console.WriteLine($"Insanin sinifi : {Sinif}");
        }

        public override void TurGoster() // virtual
        {
            Console.WriteLine($"Hayvanin turu : {CanliTur}");
        }
        

    }
}
