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

        // :011 Nadglasati (override) metodu ToString tako da vraća niz u obliku: "2+3j", "2-j", "0", "j", "-j".
        public override string ToString()
        {
            return $"{Realni}+{Imaginarni}j" ;
        }
        private string ImaginaryPart()
        {
            throw new NotImplementedException();
        }

    }

    // :010 Pokrenuti program i pogledati ispise instanci strukture KompleksniBroj.
    static class ToString
    {
        // :012 Pokrenuti program i usporediti ispise s očekivanima.

        // TODO:013 Pokrenuti testove u grupi TestToString i provjeriti prolaze li svi testovi.
        static void Main()
        {
            KompleksniBroj kb = new KompleksniBroj(2, 3);
            Console.WriteLine(kb); // "2+3j"

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

            kb.Imaginarni = -1;
            kb.Realni = -2;
            Console.WriteLine(kb); // "-2-j"

            kb.Imaginarni = 1;
            kb.Realni = 2;
            Console.WriteLine(kb); // "2+j"

            Console.WriteLine("\nGOTOVO!!!");
        }
    }
}
