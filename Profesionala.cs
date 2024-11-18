using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace KlassenGr1
{
    internal class Profesionala : Lyzeum
    {
        bool practica;
        string[] profil = { "spadasin", "bucatar", "salahor" };
        public bool Practica { set; get; }
        public string Profil { set; get; }

        public Profesionala(bool practica, string[] profil, string nrmat, bool mancare, int nrore, int n1, int n2, int n3, int n4, int m, bool bursa) : base(nrmat, mancare, nrore, n1, n2, n3, n4, m, bursa)
        {
            this.practica = practica;
            this.profil = profil;
        }

        public void datapract(bool practica)
        {
            DateTime dateTime = DateTime.Now;
            if (dateTime.Month % 2 == 1 && dateTime.Day > 17 && dateTime.Day < 23)
                practica = true;
            else
                practica = false;
            Console.WriteLine(practica);
        }

        public void repartizare(string[] profil)
        {
            int x = 0;
            Mittelnote(N1, N2, N3, N4, ref x);
            if(x>9)
                Console.WriteLine(profil[0]);
            if (x < 9 && x >= 7)
                Console.WriteLine(profil[1]);
            if (x < 7)
                Console.WriteLine(profil[2]);
        }
    }
}
