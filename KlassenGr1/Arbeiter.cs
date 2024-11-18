using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace KlassenGr1
{
    internal class Arbeiter : Mensch
    {
        public string Name { get; set; }
        public int Alter { get; set; }
        public string Beruf { get; set; }
        public int Erfahrung { get; set; }

        public Arbeiter() { }

        public Arbeiter(string name, int alter, string beruf, int erfahrung)
        {
            Name = name;
            Alter = alter;
            Beruf = beruf;
            Erfahrung = erfahrung;
        }
        public virtual void Vorstellen()
        {
            Console.WriteLine($"Hallo, ich heiße {Name}, ich bin {Alter} Jahre alt.");
            Console.WriteLine($"Ich arbeite als {Beruf} und habe {Erfahrung} Jahre Erfahrung.");
        }

        public override int lebensdauer()
        {
            Random rnd = new Random();

            return rnd.Next(10);
        }

        public void VerfügbarkeitPrüfen()
        {
            Console.WriteLine("An welchen Tagen sind Sie verfügbar?");
            Console.WriteLine("1: Montag bis Freitag");
            Console.WriteLine("2: Nur am Wochenende");
            Console.WriteLine("3: Flexibel, je nach Projekt");

            int verfügbar;
            if (int.TryParse(Console.ReadLine(), out verfügbar))
            {
                switch (verfügbar)
                {
                    case 1:
                        Console.WriteLine("Sie sind von Montag bis Freitag verfügbar.");
                        break;
                    case 2:
                        Console.WriteLine("Sie sind nur am Wochenende verfügbar.");
                        break;
                    case 3:
                        Console.WriteLine("Sie sind flexibel verfügbar.");
                        break;
                    default:
                        Console.WriteLine("Ungültige Eingabe.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Bitte geben Sie eine gültige Zahl ein.");
            }
        }
        public void GehaltBerechnen()
        {
            Console.WriteLine("Wie viele Stunden pro Woche arbeiten Sie?");
            int stunden;
            if (int.TryParse(Console.ReadLine(), out stunden))
            {
                double stundenlohn = 20.0;
                double bonus = Erfahrung * 0.05;
                double gehalt = stunden * stundenlohn * (1 + bonus);

                Console.WriteLine($"Ihr wöchentliches Gehalt beträgt {gehalt:F2} EUR.");
            }
            else
            {
                Console.WriteLine("Bitte geben Sie eine gültige Zahl ein.");
            }
        }
    }
}
    
