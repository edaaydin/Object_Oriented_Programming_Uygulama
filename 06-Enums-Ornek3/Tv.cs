using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Enums_Ornek3
{
    public class Tv : Urun
    {
        // akıllıtv mi ? hdmı var mı? ekran boyutu proplarını barındırır.

        public bool AkilliTvMi { get; set; }
        public bool HDMVarMi { get; set; }
        public int EkranBoyutu { get; set; }


    }
}
