﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_polymorphism_Ornek2
{
    public class Matematik : Ders
    {
        public override double GecmeNotuHesapla()
        {
            return GecmeNotu * 1.2;
        }
    }
}