using System.Security.Cryptography;

namespace KlassenGr1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Schuler[] s=new Schuler[5];
            s[4]=new Schuler(506090,"mov","nustiu","Salahor Si Sef",180,70,"10568",false,87);
            s[0] = new Grundschule("matei",10,"direktor","10 November");
            s[1] = new Hochschule("Ghibu","Sibiu",100,"10456",true,30);
            int  m=0;
            bool bursa = false;
            bool schlafprogram = true;
            s[2] = new Lyzeum("10678", false, 37, 9, 8, 7, 6, m, bursa);
            s[3] = new Kindergarten("97431", true, 20, "B", schlafprogram);


            foreach (Schuler p in s) {
                p.prezintate();
            }
            
        }
    }
}