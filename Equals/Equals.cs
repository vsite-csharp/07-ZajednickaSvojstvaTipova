﻿using System;

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
            Console.WriteLine(Equals(mk1, mk2));

            // :021 Usporediti reference na objekte mk1 i mk2 korištenjem statičke metode MojaKlasa.ReferenceEquals te ispisati rezultat
            Console.WriteLine(ReferenceEquals(mk1, mk2));


            // :022 Usporediti objekte mk1 i mk2 pozivom metode mk1.Equals te ispisati rezultat
            Console.WriteLine(mk1.Equals(mk2));

            // :023 Usporediti objekte mk1 i mk2 pozivom metode mk2.Equals te ispisati rezultat
            Console.WriteLine(mk2.Equals(mk1));

        }

        public static void UsporedbaStruktura()
        {
            // :024 Stvoriti dvije strukture ms1 i ms2 na isti način kao i za gornje instance klasa mk1 i mk2
            MojaStruktura ms1 = new MojaStruktura();
            MojaStruktura ms2 = new MojaStruktura();

            // :025 Usporediti objekte ms1 i ms2 korištenjem statičke metode MojaStruktura.Equals te ispisati rezultat
            Console.WriteLine(Equals(ms1, ms2));


            // :026 Usporediti objekte ms1 i ms2 pozivom metode ms1.Equals te ispisati rezultat
            Console.WriteLine(ReferenceEquals(ms1, ms2));


            // :027 Usporediti objekte ms1 i ms2 pozivom metode ms2.Equals te ispisati rezultat
            Console.WriteLine(ms1.Equals(ms2));

            //:028
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
