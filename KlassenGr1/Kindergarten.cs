using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlassenGr1
{
    internal class Kindergarten:Schuler
    {
        string gruppe;
        bool schlafprogram;
        bool mitagsessen;
        public string Gruppe { set; get; }
        public bool Schlafprogram { set; get; }
        public bool Mitagsessen { set; get; }

        public Kindergarten(string nrmat, bool mancare, int nrore, string gruppe, bool schlafprogram ) : base( nrmat,  mancare,  nrore)
        {
            Gruppe = gruppe;
            Schlafprogram = schlafprogram;
        }

        public string GruppeDetector(int alter, bool deutsch)
        {
            if (alter == 3) gruppe = "kleine ";
            if (alter == 4) gruppe = "mittlere ";
            if (alter == 5) gruppe = "grosse ";
            if (deutsch == true) gruppe += "Deutschgruppe ";
            else gruppe += "Rumanischgruppe ";
            return gruppe;
        }

        public string Meniu(string alergii)
        {
            if (alergii == "nuci") return "Meniu normal, fara nuci";
            if (alergii == "ciocolata") return "Meniu normal fara ciocolata";
            if (alergii == "intoleranta gluten") return "Meniu fara grau, secara si orz";
            if (alergii == "intoleranta lactoza") return "Meniu fara lapte";
            if (alergii == "fructe") return "Meniu normal fara fructele aferente";
            if (alergii == "sensibilitate la carne") return "Meniu vegetarian";
            return "Meniu normal";
        }
        public override void prezintate()
        {
            Console.WriteLine("eu sunt " + Nrmat + " dorm in intervalul " + schlafprogram + " si apartin grupei" + gruppe);
        }
        public override void mancareFreuTraurig()
        {
            if (Mitagsessen == true) Console.WriteLine("Das Kind beckommt Mittagsessen");
            else Console.WriteLine("Das Kind beckommt kein Mittagsessen");
        }
    }
}
