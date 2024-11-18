using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlassenGr1
{
    internal class Gymnasium : Schuler
    {
        string nameDirektor;
        int alterDirektor;
        bool berufserfahrung;
        bool aktivarbeit;
        public string NameDirektor { get; set; }
        public int AlterDirektor { get; set; }
        public bool Berufserfahrung { get; set; }
        public int Aktivarbeit { get; set; }
        // Konstruktor 1 
        public Gymnasium(string nameDirektor, int alterDirektor, bool berfuserfahrung, string nrmat, int nrore, bool mancare) : base(nrmat, mancare, nrore)
        {
            this.nameDirektor = nameDirektor;
            this.alterDirektor = alterDirektor;
            this.berufserfahrung = berfuserfahrung;
        }
        // Konstruktor 2

        /*public Gymnasium(string nameDirektor, int alterDirektor, bool berfuserfahrung)
        {
            this.nameDirektor = nameDirektor;
            this.alterDirektor = alterDirektor;
            this.berufserfahrung = berufserfahrung;
        }*/
        /*public Gymnasium(int alterDirektor)
        { this.alterDirektor=alterDirektor;}*/
        //Methode 1 
        public void erfahrung(bool berufserfahrung)
        {
            if (berufserfahrung)
            {
                Console.WriteLine("Der Direktor/ Die Direktorin " + AlterDirektor + " hat Erfahrung.");
            }
            else
            {
                Console.WriteLine("Der Direktor/ Die Direktorin " + AlterDirektor + " hat keine Erfahrung.");
            }
        }
        //Methode 2
        public void Rentegehen(bool aktivarbeit)
        {
            if (aktivarbeit)
            {
                Console.WriteLine("Der direktor muss nocn" + Aktivarbeit + "arbeiten");
            }

            else
            {
                Console.WriteLine("Der Direktor wird dieses Jahr Renter");

            }
        }
    }
}
