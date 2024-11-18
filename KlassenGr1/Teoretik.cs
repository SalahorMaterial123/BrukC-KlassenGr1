using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace KlassenGr1
{
    internal class Teoretik:Lyzeum
    {
        bool olympiade;
        float promovabilitate_bac;
        string direktor_name = "";

        public float Promovabilitate_bac { get; set; }
        public string Direktor_name { get; set; }
        public bool Olympiade { get; set; }

        public virtual int ArbeitJahre_Direktor()
        {

            int inceput = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Falls er noch arbeitet , schreibt 0");
            int sf = Int32.Parse(Console.ReadLine());
            if (sf == 0)
                return 2024 - inceput;
            else if (inceput < sf)
                return sf - inceput;
            else
                return 0;
        }
        int[] stunden = { 4, 5, 6, 7, 5, 6, 2 };

        public virtual int StundenProTag()
        {
            Random r = new Random();
            int s = r.Next(stunden.Length);
            return s;
        }
        public Teoretik(bool olympiade, float promovabilitate_bac, string direktor_name,string nrmat, bool mancare, int nrore, int n1, int n2, int n3, int n4, int m, bool bursa):base( nrmat,  mancare,  nrore,  n1, n2,  n3,  n4,  m,  bursa)
        {
            this.olympiade = olympiade;
            this.promovabilitate_bac = promovabilitate_bac;
            this.direktor_name = direktor_name;

            if (nrore > 5)
                Console.Write("zu viel");
            int m1=0;
            Mittelnote(3,4,5,6,ref m1);
        }
    }
}
