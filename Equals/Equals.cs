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

            // 020 Usporediti objekte mk1 i mk2 korištenjem statičke metode MojaKlasa.Equals te ispisati rezultat
            Console.WriteLine(Equals(mk1, mk2));//poziva od klase MetodEquals //

            // 021 Usporediti reference na objekte mk1 i mk2 korištenjem statičke metode MojaKlasa.ReferenceEquals te ispisati rezultat
            Console.WriteLine(ReferenceEquals(mk1, mk2)); //reference usporeduje uvijek po adresama// false jer mk1 i mk2 pokazuju na raz addresse

            // 022 Usporediti objekte mk1 i mk2 pozivom metode mk1.Equals te ispisati rezultat
            Console.WriteLine(mk1.Equals(mk2));//konkretan object, poziva njegivu equals metodu iz obj klase, a obj metoda equals radi usporedbu po ref

            // 023 Usporediti objekte mk1 i mk2 pozivom metode mk2.Equals te ispisati rezultat
            //Console.WriteLine(mk2.Equals(mk1));//error jer mk2 ne postoji! objekt mk2 je null

        }

        public static void UsporedbaStruktura()
        {
            // 024 Stvoriti dvije instance ms1 i ms2 strukture MojaStruktura
            MojaStruktura ms1 = new MojaStruktura();
            MojaStruktura ms2 = new MojaStruktura();

            // 025 Usporediti objekte ms1 i ms2 korištenjem statičke metode MojaStruktura.Equals te ispisati rezultat
            Console.WriteLine(Equals(ms1, ms2));//bezobzira sto su dva razlicita objekta, njihov sadrzaj je isti! (vrijednosni tipovi)

            // 026 Usporediti reference na objekte ms1 i ms2 korištenjem statičke metode MojaStruktura.ReferenceEquals te ispisati rezultat
            Console.WriteLine(ReferenceEquals(ms1,ms2)); //dva razlicita objekta => dvije razlicite adrese

            // 027 Usporediti objekte ms1 i ms2 pozivom metode ms1.Equals te ispisati rezultat
            Console.WriteLine(ms1.Equals(ms2));//true jer su vrijednosti iste (obje strukture su prazne)

            // 028 Usporediti objekte ms1 i ms2 pozivom metode ms2.Equals te ispisati rezultat
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
