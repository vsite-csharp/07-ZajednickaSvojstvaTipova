﻿using System;

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

        // TODO:011 Nadglasati (override) metodu ToString tako da vraća niz u obliku: "2+3j", "2-j", "0", "j", "-j".

        public override string ToString()
        {
            string returnValue = "";

            if (Realni == 0 && Imaginarni == 0)
            {
                returnValue += "0";
            }

            else if (Realni == 0 && Imaginarni != 0)
            {
                if (Imaginarni < -1)
                   returnValue += $"{Imaginarni}j";

                else if (Imaginarni > 1)
                    returnValue += $"{Imaginarni}j";

               else if (Imaginarni == -1)
                    returnValue += "-j";

                else if (Imaginarni == 1)
                    returnValue += "j" ;
            }

            else if (Realni != 0 && Imaginarni == 0)
            {
                returnValue += $"{Realni}";
            }

            else if (Realni != 0 && Imaginarni != 0)
            {
                returnValue += Realni;

                if (Imaginarni < -1)
                    returnValue += $"{Imaginarni}j";

                else if (Imaginarni > 1)
                    returnValue += $"+{Imaginarni}j";

                else if (Imaginarni == -1)
                    returnValue += "-j";

                else if (Imaginarni == 1)
                    returnValue += "+j";

            }

            return returnValue;
        }
        
            
        



    }

    // TODO:010 Pokrenuti program i pogledati ispise instanci strukture KompleksniBroj.
    class ToString
    {
        // TODO:012 Pokrenuti program i usporediti ispise s očekivanima.

        // TODO:013 Pokrenuti testove u grupi TestToString i provjeriti prolaze li svi testovi. DZ
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

            kb.Imaginarni = -1;
            kb.Realni = -2;
            Console.WriteLine(kb); // "-2-j"

            kb.Imaginarni = 1;
            kb.Realni = 2;
            Console.WriteLine(kb); // "2+j"

            Console.WriteLine("\nGOTOVO!!!");
            Console.ReadKey();
        }
    }
}
