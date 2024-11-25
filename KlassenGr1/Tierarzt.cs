using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlassenGr1
{
    internal class Tierarzt:Arzt
    {
        public string Spezialgebiet { get; set; }

        public Tierarzt() { }

        public Tierarzt(string name, int alter, string spezialgebiet,string grad,int hochschulejahr) : base (name, alter,grad, spezialgebiet,hochschulejahr)
        {
            Spezialgebiet = spezialgebiet;
        }

        private Dictionary<string, string> _symptomZuKrankheit = new Dictionary<string, string>
    {
        {"Husten", "Husteninfekt"},
        {"Erbrechen", "Verdauungsstörungen"},
        {"Appetitlosigkeit", "Verschiedene Ursachen"}
    };


        public void DiagnoseStellen(string tierArt, string symptome)
        {
            if (_symptomZuKrankheit.ContainsKey(tierArt) && _symptomZuKrankheit[tierArt].Contains(symptome))
            {
                if (_symptomZuKrankheit.ContainsKey(symptome))
                {
                    Console.WriteLine($"Mögliche Diagnose für {tierArt}: {_symptomZuKrankheit[symptome]}");
                }
                else
                {
                    Console.WriteLine($"Das Symptom {symptome} ist bekannt für {tierArt}, aber es konnte keine spezifische Krankheit zugeordnet werden.");
                }
            }
            else
            {
                Console.WriteLine("Es konnte keine eindeutige Diagnose gestellt werden. Weitere Untersuchungen sind erforderlich.");
            }
        }


        public void OperationDurchfuehren(string tierArt, string operationstyp, int dauerInMinuten)
        {
            Console.WriteLine($"Ich führe eine {operationstyp}-Operation bei einem {tierArt} durch. Die voraussichtliche Dauer beträgt {dauerInMinuten} Minuten.");
        }

        public void TierBesitzerBeraten(string tierArt, string spezifischesProblem)
        {
            switch (tierArt)
            {
                case "Hund":
                    if (spezifischesProblem == "Haarausfall")
                    {
                        Console.WriteLine("Bei Haarausfall beim Hund könnte eine Allergie oder ein Ernährungsproblem vorliegen. Bitte konsultieren Sie einen Tierarzt.");
                    }
                    break;
            }
        }


    }
}
