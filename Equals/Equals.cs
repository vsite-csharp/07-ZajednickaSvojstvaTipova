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

            // :020 Usporediti objekte mk1 i mk2 korištenjem statičke metode MojaKlasa.Equals te ispisati rezultat
            Console.WriteLine(MojaKlasa.Equals(mk1,mk2)); //Identična je za sve objekte gdje god se nalazi
            //Console.WriteLine(Equals(mk1,mk2)); //To prije identično je ovom gore, Object tip radi suporedbu po adresama
            //Uspoređujemo objekt sa adresom i objekt bez adrese. Ako su oba null reference vraća true. ? 

            // :021 Usporediti reference na objekte mk1 i mk2 korištenjem statičke metode MojaKlasa.ReferenceEquals te ispisati rezultat
            Console.WriteLine(MojaKlasa.ReferenceEquals(mk1,mk2)); // Opet mogu izbaciti MojaKlasa
            //Reference uvijek uspoređuje po adresama, a equals poziva metodu od konkretnog tipa

            // :022 Usporediti objekte mk1 i mk2 pozivom metode mk1.Equals te ispisati rezultat
            Console.WriteLine(mk1.Equals(mk2));
            //mk1 konkretan objekt, poziva se njegova equals metoda, koja je definirana u objectu. 
            //

            // :023 Usporediti objekte mk1 i mk2 pozivom metode mk2.Equals te ispisati rezultat
            Console.WriteLine(mk2.Equals(mk1)); // Error jer je mk2 ne postoji, pokušavama pozvati metodu na objektu koji ne postoji. 
            //Ako je ijedan null referenca vraća false 


        }

        public static void UsporedbaStruktura()
        {
            // :024 Stvoriti dvije instance ms1 i ms2 strukture MojaStruktura
            MojaStruktura ms1 = new MojaStruktura(); 
            MojaStruktura ms2 = new MojaStruktura(); 


            // :025 Usporediti objekte ms1 i ms2 korištenjem statičke metode MojaStruktura.Equals te ispisati rezultat
            Console.WriteLine(MojaStruktura.Equals(ms1,ms2));
            //Uspoređuje ih po sadržaju , prazni objekti pa je true

            // :026 Usporediti reference na objekte ms1 i ms2 korištenjem statičke metode MojaStruktura.ReferenceEquals te ispisati rezultat
            Console.WriteLine(MojaStruktura.ReferenceEquals(ms1,ms2)); // adrese su različite

            // :027 Usporediti objekte ms1 i ms2 pozivom metode ms1.Equals te ispisati rezultat
            Console.WriteLine(ms1.Equals(ms2)); // true jer uspoređuje vrijednosti, a prazni su objekti 

            // :028 Usporediti objekte ms1 i ms2 pozivom metode ms2.Equals te ispisati rezultat
            Console.WriteLine(ms2.Equals(ms1)); // true
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
