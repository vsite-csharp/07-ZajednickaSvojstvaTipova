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

        override public string ToString() {
            string r, i;

            // kako bi moglo bit preko ternarnog operatora, ali je nepregledno
            //i = Imaginarni == 1 ? "j" : Imaginarni == -1 ? "-j" : Imaginarni == 0 ? "" : Imaginarni.ToString();
            //i += Imaginarni != 1 && Imaginarni != -1 && Imaginarni != 0 ? "j" : "";

            r = Realni != 0 ? Realni.ToString() : "";
            r += Imaginarni > 0 && Realni != 0 ? "+" : "";

            i = Imaginarni.ToString();
            if (Imaginarni == 0 && Realni != 0)
                i = "";
            if (Imaginarni != 0)
                i += "j";
            if (Imaginarni == 1)
                i = "j";
            if (Imaginarni == -1)
                i = "-j";

            return r + i;
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
