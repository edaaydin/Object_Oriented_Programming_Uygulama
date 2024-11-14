using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Abstraction
{
    public abstract class Tur
    {
        // sealed : nesne alabilirim ama turetemem.
        // abstract : nesne alamazsın ama kalıtım verebilir.

        //static/ prop kullanılır mıydı ? 

        public string CanliTur { get; set; }
        public string Sinif { get; set; }
        public string Aile { get; set; }

        public virtual void TurGoster()
        {
            Console.WriteLine($"Tanimlanan canli turu : {CanliTur}");
        }

        public void AileGoster()
        {
            Console.WriteLine($"Tanimlanan aile : {Aile}");
        }

        public abstract void SinifGoster(); // Govde Yok !
    }
}
