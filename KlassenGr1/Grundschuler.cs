using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grundschule
{
    internal class Grundschule : Schuler
    {
        public string SchuleAnders { get; set; }

        public Grundschule(string name, int alter, string beruf, string schuleAnders) //: base(name, alter, beruf)
        {
            SchuleAnders = schuleAnders;
        }

        public void GehenSchuleAnders()
        {
            int schuleAnders;
            int ok = 1;
            Console.WriteLine("Geben Sie ein in welcher Klasse Sie sind (1-4): ");
            Console.WriteLine("Erste Klasse - 1");
            Console.WriteLine("Zweite Klasse - 2");
            Console.WriteLine("Dritte Klasse - 3");
            Console.WriteLine("Vierte Klasse - 4");
            schuleAnders = int.Parse(Console.ReadLine());
            if (schuleAnders == 1)
                ok = 0;
            if (schuleAnders == 2)
                ok = 0;
            if (schuleAnders == 3)
                ok = 0;
            if (schuleAnders == 4)
                ok = 1;
            if (ok == 0)
                Console.WriteLine("Du gehst nicht! Schade...");
            else
                Console.WriteLine("YAYYYYYYYYYYYYY! Du gehst!!!");
        }

        public void BerechnenbisExam()
        {
            int klasse, dif = 8;
            Console.WriteLine("Wie viele Jahre bist du von einer Prufung entfernt?");
            Console.WriteLine("Geben Sie ein, wie viele Stunden Sie diese Nacht geschlafen haben:");
            klasse = int.Parse(Console.ReadLine());
            if (klasse == 1)
            {
                dif = dif - klasse;
                Console.WriteLine("Du hast noch: " + dif + "Jahre");
            }
            if (klasse == 2)
            {
                dif = dif - klasse;
                Console.WriteLine("Du hast noch: " + dif + "Jahre");
            }
            if (klasse == 3)
            {
                dif = dif - klasse;
                Console.WriteLine("Du hast noch: " + dif + "Jahre");
            }
            if (klasse == 4)
            {
                dif = dif - klasse;
                Console.WriteLine("Du hast noch: " + dif + "Jahre");
            }
        }
    }
}
