using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace KlassenGr1   // :Arzt
{
    internal class Zahnarzt :Arzt
    {
        // Zusätzliche Eigenschaft
        public string Spezialisierung { get; set; } //Chirugie, Aestetik, Implantologie, Paradontologie

        // Konstruktoren
        public Zahnarzt() { }
        public Zahnarzt(string name, int alter, string beruf, string spezialisierung)
        //: base(name, alter, beruf)
        {
            Spezialisierung = spezialisierung;
        }
        // Zusätzliche Methode
        public void Behandeln()
        {
            int zahnschmerzen;
            Console.WriteLine("Wie schlimm sind Ihre Zahnschmerzen?");
            Console.WriteLine("0 - gar keine Schmerzen");
            Console.WriteLine("1 - etwas tut ein bisschen weh");
            Console.WriteLine("2 - mittelmassige Schmerzen");
            Console.WriteLine("3 - starke Schmerzen");
            zahnschmerzen = int.Parse(Console.ReadLine());
            if (zahnschmerzen == 0)
                Console.WriteLine("Sie brauchen keine Behandlung!");
            if (zahnschmerzen == 1)
                Console.WriteLine("Kommen Sie zu einer Kontrolle!");
            if (zahnschmerzen == 2)
                Console.WriteLine("Sie brauchen eine Behandlung!");
            if (zahnschmerzen == 3)
                Console.WriteLine("Wir haben schon eine dringende Bahandlung fur Sie geplant!");
        }

        public void Zahndauer()
        {
            int a, zahndauer = 0;
            Console.WriteLine("Pro Tag sollte man die Zahne 2x je 2 Minuten putzen. Ausserdem muss man " +
                "taglich Zahnseide benutzen und Mundspulung ist empfohlen. Wie gut erfullen Sie all das?");
            Console.WriteLine("10 - Ich mache alles! Sogar 3x taglich!");
            Console.WriteLine("9 - Ich mache das meiste");
            Console.WriteLine("8 - Ich benutze keine Zahnseide");
            Console.WriteLine("7 - Ich putze einmal taglich");
            Console.WriteLine("6 - Ich putze 30 Sekunden pro Tag");
            Console.WriteLine("5 - Ich habe niemals meine Zahne geputzt");
            a = int.Parse(Console.ReadLine());
            zahndauer = (a - 1) * 10;
            Console.WriteLine("Herzlichen Gluckwunsch, ihre Zahne werden mit " + zahndauer + " Jahren ausfallen!");
        }
    }
}
