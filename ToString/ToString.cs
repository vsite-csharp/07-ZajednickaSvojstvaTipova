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

        // TODO:010 Nadglasati (override) metodu ToString tako da vraća niz u obliku: "2+3j", "2-j", "0", "j", "-j".
        public override string ToString()
        {
            if(Imaginarni == 0)
            {
                return Realni.ToString();
            }
            else
            {
                string r = Realni.ToString();
                if (Realni == 0)
                    r = "";
                if (Imaginarni < -1)
                {
                    return r + Imaginarni + "j";
                }
                else if (Imaginarni > 0)
                {
                    return Imaginarni > 1 ? r + "+" + Imaginarni + "j" : r + "j";
                }
                else
                    return r + "-j";
            }
        }
    }

    class ToString
    {
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

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
