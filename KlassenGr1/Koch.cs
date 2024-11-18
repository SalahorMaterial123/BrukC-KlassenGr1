using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace KlassenGr1
{
    internal class Koch : Arbeiter
    {
        public bool Berufserfahrung { get; set; }
        public string Spezialitaet { get; set; }

        //Konstruktor 1
        public Koch(string name, int alter, bool berufserfahrung, string spezialitaet)
     : base(name, alter, "Koch", berufserfahrung ? 1 : 0)  // Assuming 1 for experience, 0 for none
        {
            Berufserfahrung = berufserfahrung;
            Spezialitaet = spezialitaet;
        }

        //Konstruktor 2
        public Koch(string name, int alter)
            : base(name, alter, "Koch", 0)
        {
            Berufserfahrung = false;
            Spezialitaet = "Unbekannt";
        }

        public string GerichtKochen(string gericht)
        {
            return $"{Name} kocht jetzt {gericht}.";
        }

        public string KochzeitBerechnen(int zutatenAnzahl)
        {
            return $"Die Kochzeit beträgt {zutatenAnzahl * 10} Minuten.";
        }

        public string BerufserfahrungAnzeigen()
        {
            return Berufserfahrung
                ? $"{Name} hat Berufserfahrung als Koch."
                : $"{Name} ist noch Anfänger in der Küche.";
        }

        public string SpezialitaetAnzeigen()
        {
            return $"Die Spezialität von {Name} ist {Spezialitaet}.";
        }

        //Uberschriebene Klasse
        public override void Vorstellen()
        {
            base.Vorstellen();  // Apelează metoda Vorstellen din Arbeiter pentru a prezenta informațiile de bază
            Console.WriteLine($"Ich arbeite als Koch und liebe es, Spezialitäten wie {Spezialitaet} zuzubereiten.");
        }

    }
}
