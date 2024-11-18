using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlassenGr1
{
    internal class Hochschule : Schuler2
    {
        public string Name { set; get; }
        public string Ort { set; get; }
        public int AnzahlStudierende { get; set; }
        bool mancare;
        public bool Mancare { set; get; }

        public Hochschule(string name, string ort,int anzahlstudierende, string nrmat, bool mancare, int nrore):base(nrmat, mancare,  nrore)
        {
            Name = name;
            Ort = ort;
            AnzahlStudierende = anzahlstudierende;
        }

        public void Details()
        {
            Console.WriteLine("Name Hochschule: ");
            Console.WriteLine("Standort: ");
        }
        
        public int StudienJahre(string profil)
        {
            if (profil == "calculatoare")
                return 3;
            if (profil == "filologie")
                return 4;
            if (profil == "inginerie")
                return 5;
            return 0;
        }

        public int Stunden(string profil)
        {
            if (profil == "calculatoare")
                return 8;
            if (profil == "filologie")
                return 6;
            if (profil == "inginerie")
                return 7;
            return 0;
        }
        public override void mancareFreuTraurig()
        {
            
            if (mancare == true)
                Console.WriteLine("Der Schuler bekommt Essen");
            else
                Console.WriteLine("Der Schuler bekommt kein Essen");
        }
    }

    
}
