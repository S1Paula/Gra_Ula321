using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Gra_Ula321
{
    internal class Przeciwnicy
    {
        internal class Przeciwnik
        {
            public int Hp { get; set; }
            public int Atak { get; set; }
            public int[] Bron { get; set; }
            public int NumerRundy { get; set; }
        }
    }



}