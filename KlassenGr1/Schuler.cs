using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlassenGr1
{
    internal class Schuler : Mensch
    {
        //date
        string nrmat; //numarul matricol al fiecarui elev
        bool mancare; //beneficiaza sau nu de mancare la scoala
        int nrore; //nr de ore saptamanal

        //Metode
        //Gettere si Settere pentru date
        public void setNrmat(string nrmat)
        { this.nrmat = nrmat; }
        public string getNrmat()
        { return nrmat; }
        public void setMancare(bool mancare)
        { this.mancare = mancare; }
        public bool getMancare()
        { return mancare; }
        public void setNrore(int nrore)
        { this.nrore = nrore; }
        public int getNrore()
        { return nrore; }

        //Eigenschaften
        public string Nrmat
        {
            get { return this.nrmat; }
            set { this.nrmat = value; }
        }
        public bool Mancare
        {
            get { return this.mancare; }
            set { this.mancare = value; }
        }
        public int Nrore
        {
            get { return this.nrore; }
            set { this.nrore = value; }
        }

        //constructori
        //constructor complet cu datele din baza Mensch inclusiv
        public Schuler(int cnp, string haarfarbe, string geschlecht, string nameVorname, int grcm, int gw, string nrmat, bool mancare, int nrore) : base(cnp, haarfarbe, geschlecht, nameVorname, grcm, gw)
        {
            this.nrmat = nrmat;
            this.mancare = mancare;
            this.nrore = nrore;
        }
        //constructor cu toate datele din clasa aceasta, fara clasa baza
        public Schuler(string nrmat, bool mancare, int nrore)
        {
            this.nrmat = nrmat;
            this.mancare = mancare;
            this.nrore = nrore;
        }

        //Overloading la constructor
        //constructori individuali pentru fiecare data a acestei clase
        public Schuler(string nrmat)
        { this.nrmat = nrmat; }
        public Schuler(bool mancare)
        { this.mancare = mancare; }
        public Schuler(int nrore)
        { this.nrore = nrore; }
        public Schuler(int nrore,string s)
        { this.nrore = nrore; }

        //constructor de copiere pentru datele acestei clase
        public Schuler(Schuler schuler) //Kopiierungskonstruktor mit einem Objekt der Klasse als Parameter
        {
            nrmat = schuler.getNrmat();
            mancare = schuler.getMancare();
            nrore = schuler.getNrore();
        }

        //Override
        public override int lebensdauer()
        {
            Random rnd = new Random();
          
            return rnd.Next(10);
        }

        //alte metode
        public virtual void mancareFreuTraurig()
        {
            if (getMancare() == true)
                Console.WriteLine("Der Schuler " + getNrmat() + " ist freu.");
            else
                Console.WriteLine("Der Schuler " + getNrmat() + " ist traurig.");
        }
        public bool validNrmat(string nrmat)
        {
            if (string.IsNullOrEmpty(nrmat)) //nrmat este NULL sau gol
                return false;
            if (nrmat.All(char.IsLetterOrDigit) == false) //nrmat contine si alte caractere, decat litere sau numere
                return false;

            bool okay;
            if (Char.IsLetter(nrmat[0]) == true) //primul caracter din nrmat este o litera
                okay = true;
            else
                return false;
            /*for ul verifica daca nrmat incepe cu litere si se terminaa cu cifre
             * FARA a se amesteca intre ele literele cu cifrele
             * (fara a fi alternative intre ele)
             */
            for (int i = 0; i < nrmat.Length; i++)
            {
                if (Char.IsLetter(nrmat[i]) && okay == true)
                    continue;
                else if (Char.IsLetter(nrmat[i]) && okay == true)
                    okay = false;
                else if (Char.IsNumber(nrmat[i]) && okay == false)
                    continue;
                else if (Char.IsLetter(nrmat[i]) && okay == false)
                    return false;
            }
            //daca toate conditiile de pana acum s au intrunit, 
            //inseamna ca nrmat are formatul bun si e valid
            return true;
        }
        public void program(int ore, ref bool incarcat)
        {
            //daca nrore este mai mic decat numarul de ore introdus,
            //programul nu este incarcat
            if (getNrore() < ore)
                incarcat = false;
            else
                incarcat = true;
        }
        public void incarcat(Schuler schuler, bool incarcat)
        {
            //se afiseaza tipul programului elevului trimis ca parametru
            //programul poate fi supraincarcat sau lejer
            if (incarcat == true)
                Console.WriteLine("Der Schüler " + schuler.getNrmat() + " hat ein überladenes Programm.");
            else
                Console.WriteLine("Der Schüler " + schuler.getNrmat() + " hat ein lässiges Programm.");
        }
    }
}

