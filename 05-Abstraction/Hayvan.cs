using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Abstraction
{
    public class Hayvan : Tur
    {
        public override void SinifGoster()
        {
            Console.WriteLine($"Hayvanin sinifi : {Sinif}");
        }
        public override void TurGoster()
        {
            base.TurGoster();
        }
    }
}
