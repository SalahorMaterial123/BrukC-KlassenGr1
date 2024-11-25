using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlassenGr1
{
    internal class Lyzeum : Schuler
    {
         int n1, n2, n3, n4;
        bool bursa;

        public int N1 { get; set; }
        public int N2 { get; set; }
        public int N3 { get; set; }
        public int N4 { get; set; }

       

        public static void Mittelnote(int n1, int n2, int n3, int n4, ref int m)
        {
            m = (n1 + n2 + n3 + n4) / 4;
        }

        public static bool BURSA(int m, bool bursa)
        {
            if (m > 9)
                return true;
            else
                return false;
        }
        public Lyzeum(string nrmat, bool mancare, int nrore, int n1, int n2, int n3, int n4, int m, bool bursa) : base(nrmat, mancare, nrore)
        {
            this.n1 = n1;
            this.n2 = n2;
            this.n3 = n3;
            this.n4 = n4;
            //this.m = m;
            this.bursa = bursa;
        }

        public override void prezintate()
        {
            Console.WriteLine("eu sunt "+Nrmat+" am "+Nrore+" ore si urmatoarele note "+n1+" "+n2+" "+n3+" "+n4);
        }
    }
}
