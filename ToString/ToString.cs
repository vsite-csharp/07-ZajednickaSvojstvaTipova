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
            //return base.ToString(); ako ovako ostavimo dobijemo isto
            if (Realni < 0 && Imaginarni < 0)
                return Realni + "" + Imaginarni + "j";

            else if (Realni > 0 && Imaginarni < 0)
                return Realni + "" + Imaginarni + "j";

            else if (Imaginarni == 0)
                return Realni + "";

            else if (Realni == 0 &&Imaginarni==1) {
            
                     return "j";
        }
            else if (Realni == 0 && Imaginarni == -1)
            {

                return "-j";
            }
            else if (Realni == 0 && Imaginarni <0)
            {

                return Imaginarni+"j";
            }

            else if (Realni == 0 && Imaginarni == 0)
                return "";

            else
                return Realni + "+" + Imaginarni + "j"; 
            /*nakon unosa overrida:
                2+3j
                2+-3j
                0+-3j
                0+0j
                0+1j
                0+-1j
                -2+0j
            GOTOVO!!!*/
            
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
            /*bez overrida:
             * po defaultu puno ime klase zajedno sa namespace-om
             * 
                Vsite.CSharp.ZajednickaSvojstvaTipova.KompleksniBroj
                Vsite.CSharp.ZajednickaSvojstvaTipova.KompleksniBroj
                Vsite.CSharp.ZajednickaSvojstvaTipova.KompleksniBroj
                Vsite.CSharp.ZajednickaSvojstvaTipova.KompleksniBroj
                Vsite.CSharp.ZajednickaSvojstvaTipova.KompleksniBroj
                Vsite.CSharp.ZajednickaSvojstvaTipova.KompleksniBroj
                Vsite.CSharp.ZajednickaSvojstvaTipova.KompleksniBroj
                GOTOVO!!!
             */

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
