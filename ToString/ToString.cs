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

        public override string ToString()
        {
            string str="";

            if (Realni == 0 && Imaginarni == 0)
                str = "0";
            else
            {
                if (Realni != 0)
                    str = Realni.ToString();
                if (Imaginarni != 0)
                {
                    if (Realni != 0)
                    {
                        str += (Imaginarni > 0 ? "+" : "-");
                        if (Math.Abs(Imaginarni) != 1)
                            str += Math.Abs(Imaginarni);
                    }
                    else
                    {
                        if (Math.Abs(Imaginarni) != 1)
                            str = Imaginarni.ToString();
                        else if(Imaginarni < 1)
                            str += "-";
                    }

                    str += "j";
                }
            }
               
            return str;
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
