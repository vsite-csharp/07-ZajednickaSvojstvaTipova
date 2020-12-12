using System;

namespace Vsite.CSharp.ZajedničkaSvojstvaTipova
{
    struct KompleksniBroj
    {
        public KompleksniBroj(double realni, double imaginarni)
        {
            Realni = realni;
            Imaginarni = imaginarni;
        }

        public double Realni;
        public double Imaginarni;

        // 011 Nadglasati (override) metodu ToString tako da vraća niz u obliku: "2+3j", "2-j", "0", "j", "-j".

        // ideja je da metoda ToString() daje nekakvu recimo slikovitu informaciju o objektu
        // override System.Object metode ToString i na taj način osiguravamo da dobijemo nekakav čitljivi prikaz
        // inače ispisuje puno ime tipa od kojeg je stvorena (po defaultnoj implementaciji metode)
        public override string ToString() 
        {
            // return base.ToString();// VS studio generira tijelo metode koja poziva defaultnu implementaciju od bazne klase
            return $"{Realni}+{Imaginarni}j";
        }
    }

    // 010 Pokrenuti program i pogledati ispise instanci strukture KompleksniBroj.
    class ToString
    {
        static void Main(string[] args)
        {
            KompleksniBroj kb = new KompleksniBroj(2, 3);
            Console.WriteLine(kb); // "2+3j"
                                   // budući da WriteLine nije override-ana kako bi primala kompleksni broja
                                   // ona će na tom tipu pozvati metodu ToString();

            // TODO - DZ - kompleksni brojevi
            // primjeri ispisa - moram dobiti kako je označeno - također - provjeriti u testovima
            kb.Imaginarni = -3;
            Console.WriteLine(kb); // "2-3j"

            kb.Realni = 0;
            Console.WriteLine(kb); // "-3j"

            kb.Imaginarni = 0;
            Console.WriteLine(kb); // "0"

            kb.Imaginarni = 1;
            Console.WriteLine(kb); // "j"

            kb.Imaginarni = -1;
            Console.WriteLine(kb); // "-j"

            kb.Imaginarni = 0;
            kb.Realni = -2;
            Console.WriteLine(kb); // "-2"

            Console.WriteLine("\nGOTOVO!!!");
            Console.ReadKey();
        }
    }
}
