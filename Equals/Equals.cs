﻿namespace Vsite.CSharp.ZajedničkaSvojstvaTipova
{
    class MojaKlasa
    {
    }

    struct MojaStruktura
    {
    }

    static class MetodaEquals
    {
        public static void UsporedbaKlasa()
        {
            MojaKlasa? mk1 = new MojaKlasa();
            MojaKlasa? mk2 = null;

            // TODO:020 Usporediti objekte mk1 i mk2 korištenjem statičke metode MojaKlasa.Equals te ispisati rezultat


            // TODO:021 Usporediti reference na objekte mk1 i mk2 korištenjem statičke metode MojaKlasa.ReferenceEquals te ispisati rezultat


            // TODO:022 Usporediti objekte mk1 i mk2 pozivom metode mk1.Equals te ispisati rezultat


            // TODO:023 Usporediti objekte mk1 i mk2 pozivom metode mk2.Equals te ispisati rezultat


        }

        public static void UsporedbaStruktura()
        {
            // TODO:024 Stvoriti dvije instance ms1 i ms2 strukture MojaStruktura


            // TODO:025 Usporediti objekte ms1 i ms2 korištenjem statičke metode MojaStruktura.Equals te ispisati rezultat


            // TODO:026 Usporediti reference na objekte ms1 i ms2 korištenjem statičke metode MojaStruktura.ReferenceEquals te ispisati rezultat


            // TODO:027 Usporediti objekte ms1 i ms2 pozivom metode ms1.Equals te ispisati rezultat


            // TODO:028 Usporediti objekte ms1 i ms2 pozivom metode ms2.Equals te ispisati rezultat

        }

        static void Main()
        {
            Util.IspisNaslova("Usporedba klasa");
            UsporedbaKlasa();

            Console.WriteLine();

            Util.IspisNaslova("Usporedba struktura");
            UsporedbaStruktura();

            Console.WriteLine("\nGOTOVO!!!");
        }
    }
}
