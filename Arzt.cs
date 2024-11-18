using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlassenGr1
{
    internal class Arzt:Arbeiter
    {
        public string Typ { get; set; }
        public string Grad { get; set; }
        public int Hochschuljahre { get; set; }

        public Arzt() { }

        public Arzt(string name, int alter, string typ, string grad, int hochschuljahre)
        {
            Name = name;
            Alter = alter;
            Typ = typ;
            Grad = grad;
            Hochschuljahre = hochschuljahre;
        }


        public string Name { get; set; }
        public int Alter { get; set; }


        public void Konsultation()
        {
            Console.WriteLine("Willkommen bei Dr. {Name}, Ihrem {Typ}.");
            Console.WriteLine("Wie fühlen Sie sich heute?");
            Console.WriteLine("1 - Sehr schlecht");
            Console.WriteLine("2 - Etwas unwohl");
            Console.WriteLine("3 - Gut");
            Console.WriteLine("4 - Sehr gut");

            int zustand = int.Parse(Console.ReadLine());
            switch (zustand)
            {
                case 1:
                    Console.WriteLine("Wir müssen sofort eine gründliche Untersuchung durchführen.");
                    break;
                case 2:
                    Console.WriteLine("Ich empfehle Ihnen, einen Termin für eine genauere Untersuchung zu vereinbaren.");
                    break;
                case 3:
                    Console.WriteLine("Das ist gut! Achten Sie weiterhin auf Ihre Gesundheit.");
                    break;
                case 4:
                    Console.WriteLine("Freut mich zu hören! Bleiben Sie gesund!");
                    break;
                default:
                    Console.WriteLine("Bitte geben Sie eine gültige Option ein.");
                    break;
            }
        }

        public void StudienFeedback()
        {
            Console.WriteLine("ihr Arzt hat insgesamt {Hochschuljahre} Jahre an der Universität verbracht.");
            if (Hochschuljahre < 6)
            {
                Console.WriteLine("Dieser Arzt hat möglicherweise nicht die vollständige Ausbildung abgeschlossen.");
            }
            else if (Hochschuljahre >= 6 && Hochschuljahre <= 8)
            {
                Console.WriteLine("das ist eine solide medizinische Ausbildung.");
            }
            else
            {
                Console.WriteLine("Ihr Arzt hat eine besonders lange Ausbildung genossen, möglicherweise mit Spezialisierung.");
            }
        }
    }
}

