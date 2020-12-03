using System;

namespace Vsite.CSharp.ZajedničkaSvojstvaTipova
{
    class MojaKlasa
    {
    }

    struct MojaStruktura
    {
    }

    class MetodaEquals
    {
        public static void UsporedbaKlasa()
        {
            MojaKlasa mk1 = new MojaKlasa();
            MojaKlasa mk2 = null;

            

            Console.WriteLine(MojaKlasa.Equals(mk1, mk2));
            Console.WriteLine(MojaKlasa.ReferenceEquals(mk1,mk2));
            Console.WriteLine(mk1.Equals(mk2));
            Console.WriteLine(mk2.Equals(mk1));


        }

        public static void UsporedbaStruktura()
        {
            MojaStruktura ms1 = new MojaStruktura();
            MojaStruktura ms2 = new MojaStruktura();
            Console.WriteLine(MojaStruktura.Equals(ms1,ms2));
            Console.WriteLine(ms1.Equals(ms2));
            Console.WriteLine(ms2.Equals(ms1));
        }

        static void Main(string[] args)
        {
            Util.IspisNaslova("Usporedba klasa");
            UsporedbaKlasa();

            Console.WriteLine();

            Util.IspisNaslova("Usporedba struktura");
            UsporedbaStruktura();

            Console.WriteLine("\nGOTOVO!!!");
            Console.ReadKey();
        }
    }
}
