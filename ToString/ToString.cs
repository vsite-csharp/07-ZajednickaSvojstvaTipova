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

        // Nadglasati (override) metodu (do kraja) ToString tako da vraća niz u obliku: "2+3j", "2-j", "0", "j", "-j".
        public override string ToString()
        {
            if (this.Realni == 0)
            {
                if (this.Imaginarni == 0)
                {
                    return "0";
                }

                if (this.Imaginarni == 1)
                {
                    return "j";
                }

                if (this.Imaginarni == -1)
                {
                    return "-j";
                }

                return $"{this.Imaginarni}j";
            }

            if (this.Imaginarni == 0)
            {
                return $"{this.Realni}";
            }

            if (this.Imaginarni < 0)
            {
                if (this.Imaginarni == -1)
                {
                    return $"{this.Realni}-j";
                }

                return $"{this.Realni}{this.Imaginarni}j";
            }

            if (this.Imaginarni == 1)
            {
                return $"{this.Realni}+j";
            }

            return $"{this.Realni}+{this.Imaginarni}j";
        }
    }

    // Pokrenuti program i pogledati ispise instanci strukture KompleksniBroj.
    class ToString
    {
        // Pokrenuti program i usporediti ispise s očekivanima.

        // Pokrenuti testove u grupi TestToString i provjeriti prolaze li svi testovi.
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
