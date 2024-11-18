using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlassenGr1
{
    internal class Informatiker: Arbeiter
    {
        public string Programmiersprache { get; set; }

        public Informatiker(string name, int alter, string beruf, string programmiersprache) //: base(name, alter, beruf)
        {
            Programmiersprache = programmiersprache;
        }

        public void InfoProgrammiersprache()
        {
            int programmiersprache;
            Console.WriteLine("In was fur eine Programmiersprache arbeiten Sie? Geben Sie ein: ");
            Console.WriteLine("Java - 1");
            Console.WriteLine("Python - 2");
            Console.WriteLine("C# - 3");
            Console.WriteLine("C++ - 4");
            programmiersprache = int.Parse(Console.ReadLine());
            if (programmiersprache == 1)
                Console.WriteLine("Der Name „Java“ stammt von der indonesischen Insel Java, die für ihren Kaffee bekannt ist. Auf dem Logo von Java ist sogar eine Kaffeetasse zu sehen.");
            if (programmiersprache == 2)
                Console.WriteLine("Nicht nach einer Schlange benannt: Python wurde nach der britischen Comedy-Show „Monty Python’s Flying Circus“ benannt, nicht nach dem Reptil. Ihr Schöpfer Guido van Rossum war ein Fan der Show.");
            if (programmiersprache == 3)
                Console.WriteLine("Der Name C# leitet sich von der Notenschrift „Cis“ (♯) ab. In der Musik erhöht ein Kreuz eine Note um einen Halbton, was symbolisiert, dass C# eine Weiterentwicklung der C-Sprache ist – genauso wie Kreuznoten eine Weiterentwicklung der Grundnoten in der Musik sind.");
            if (programmiersprache == 4)
                Console.WriteLine("Aufgrund seiner Flexibilität wird C++ oft als „Schweizer Taschenmesser“ unter den Programmiersprachen bezeichnet. Es kann für ein breites Anwendungsspektrum eingesetzt werden, von Systemsoftware über Spieleentwicklung bis hin zu leistungsstarken Finanzsystemen.");
        }

        public void Schlafen()
        {
            int energydrinks, s = 0;
            Console.WriteLine("Bewerte die Qualitat deines Schlafs!");
            Console.WriteLine("Geben Sie ein, wie viele Stunden Sie diese Nacht geschlafen haben:");
            energydrinks = int.Parse(Console.ReadLine());
            if (energydrinks == 1 || energydrinks == 2 || energydrinks == 3)
            {
                s = energydrinks + 3;
                Console.WriteLine("Das ist nicht gut!!! Sie brauchen: " + s + "Energy-Drinks! Abgesehen von dieser Menge an Energy-Drinks brauchen Sie auch einen Urlaub");
            }
            if (energydrinks == 4 || energydrinks == 5 || energydrinks == 6)
            {
                s = energydrinks + 2;
                Console.WriteLine("Das ist aber sehr gut fur ein Informatiker!!! Du brauchst fogender Anzahl von Energy-Drinks: " + s);

            }
            if (energydrinks == 7 || energydrinks == 8)
            {
                s = energydrinks + 1;
                Console.WriteLine("Mensch, bst du fit!!! Wenn Sie ein wenig Energie fur den anstrengenden Tag, der folgt, wollen, empfahle ich Ihnen den folgenden Anzahl von Energy-Drinks:" + s);
            }
            if (energydrinks > 8)
            {
                Console.WriteLine("Du brauchst ja keine Energy-Drinks!!! Congratulations!");
            }
        }
    }
}
