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
        public override string ToString()
        {
            if ((Imaginarni <0) && (Imaginarni != -1))
            {
                if (Realni == 0)
                {
                    return $"{Imaginarni}j";
                }
                return $"{Realni}{Imaginarni}j";
            }
            else if (Imaginarni == -1)
            {
                if (Realni == 0)
                {
                    return $"-j";
                }
                return $"{Realni}-j";
            }
            else if (Imaginarni == 0)
            {
                if (Realni == 0)
                {
                    return $"0";
                }
                return $"{Realni}";
            }
            else if (Imaginarni == 1)
            {
                if (Realni == 0)
                {
                    return $"j";
                }
                return $"{Realni}+j";
            }
            return $"{Realni}+{Imaginarni}j";
        }
    }

    // 010 Pokrenuti program i pogledati ispise instanci strukture KompleksniBroj.
    class ToString
    {
        // 012 Pokrenuti program i usporediti ispise s očekivanima.

        // 013 Pokrenuti testove u grupi TestToString i provjeriti prolaze li svi testovi.
        static void Main(string[] args)
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

            Console.WriteLine("\nGOTOVO!!!");
            Console.ReadKey();
        }
    }
}
