using System;

namespace Vsite.CSharp.ZajedničkaSvojstvaTipova
{
    class MojaKlasa
    {

    }

    class SystemObject
    {
        public static void IspisToString()
        {
            MojaKlasa mk1 = new MojaKlasa();
            MojaKlasa mk2 = mk1;
            MojaKlasa mk3 = new MojaKlasa();

            Console.WriteLine(mk1.ToString());
            Console.WriteLine(mk2.ToString());
            Console.WriteLine(mk3.ToString());
        }

        public static void IspisGetType()
        {
            MojaKlasa mk1 = new MojaKlasa();
            MojaKlasa mk2 = mk1;
            MojaKlasa mk3 = new MojaKlasa();

            Console.WriteLine(mk1.GetType());
            Console.WriteLine(mk2.GetType());
            Console.WriteLine(mk3.GetType());
        }

        public static void IspisGetHashCode()
        {
            MojaKlasa mk1 = new MojaKlasa();
            MojaKlasa mk2 = mk1;
            MojaKlasa mk3 = new MojaKlasa();

            Console.WriteLine(mk1.GetHashCode());
            Console.WriteLine(mk2.GetHashCode());
            Console.WriteLine(mk3.GetHashCode());
        }

        public static void IspisEquals()
        {
            MojaKlasa mk1 = new MojaKlasa();
            MojaKlasa mk2 = mk1;
            MojaKlasa mk3 = new MojaKlasa();

            Console.WriteLine(mk1.Equals(mk2));
            Console.WriteLine(mk1.Equals(mk3));
            Console.WriteLine(mk2.Equals(mk1));
            Console.WriteLine(mk2.Equals(mk3));
            Console.WriteLine(mk3.Equals(mk1));
            Console.WriteLine(mk3.Equals(mk2));
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Ispis ToString");
            IspisToString();

            Console.WriteLine("Ispis GetType");
            IspisGetType();

            Console.WriteLine("Ispis GetHashCode");
            IspisGetHashCode();

            Console.WriteLine("Ispis Equals");
            IspisEquals();

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
