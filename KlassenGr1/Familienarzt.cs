using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlassenGr1
{
    internal class Familienarzt : Arzt
    {
        public string Altersgruppe { get; set; }

        public Familienarzt() { }

        public Familienarzt(string Name1, int Alter1, string Beruf, string altersgruppe)
        {
            Altersgruppe = altersgruppe;
        }

        public void Diagnostizieren()
        {
            Console.WriteLine("Welche Symptome haben Sie?");
            Console.WriteLine("1 - Keine Symptome");
            Console.WriteLine("2 - Leichte Symptome (z. B. Kopfschmerzen, Müdigkeit)");
            Console.WriteLine("3 - Mittelschwere Symptome (z. B. Fieber, Gliederschmerzen)");
            Console.WriteLine("4 - Starke Symptome (z. B. Atemnot, starke Schmerzen)");
            int symptome = int.Parse(Console.ReadLine());

            if (symptome == 1)
            {
                Console.WriteLine("Sie brauchen keine Behandlung. Bleiben Sie gesund!");
            }
            else if (symptome == 2)
            {
                Console.WriteLine("Kommen Sie für eine Kontrolluntersuchung vorbei.");
            }
            else if (symptome == 3)
            {
                Console.WriteLine("Wir empfehlen Ihnen eine genaue Untersuchung.");
            }
            else if (symptome == 4)
            {
                Console.WriteLine("Wir haben sofort eine dringende Behandlung für Sie eingeplant!");
            }
        }

        public void Gesundheitsberatung()
        {
            int diagnostik = 0;

            Console.WriteLine("Wie oft gehen Sie zur Vorsorgeuntersuchung?");
            Console.WriteLine("1 - Jährlich");
            Console.WriteLine("2 - Alle 2 Jahre");
            Console.WriteLine("3 - Selten (alle 5 Jahre oder mehr)");
            Console.WriteLine("4 - Nie");
            diagnostik = int.Parse(Console.ReadLine());

            switch (diagnostik)
            {
                case 1:
                    Console.WriteLine("Ausgezeichnet! Sie kümmern sich gut um Ihre Gesundheit.");
                    break;
                case 2:
                    Console.WriteLine("Gut, aber regelmäßige Vorsorge wäre besser.");
                    break;
                case 3:
                    Console.WriteLine("Bitte überlegen Sie, öfter zur Vorsorge zu gehen.");
                    break;
                case 4:
                    Console.WriteLine("Eine Vorsorgeuntersuchung ist sehr wichtig! Bitte vereinbaren Sie bald einen Termin.");
                    break;
            }
        }
    }
}
