﻿using System;
using System.Diagnostics;

namespace Vsite.CSharp.ZajedničkaSvojstvaTipova
{
    // TODO:101 Klasi Osoba iz projekta MetodaEqualsZaReferentiTip navesti da implementira sučelje ICloneable.

    // TODO:102 Implementirati metodu sučelja object ICloneable.Clone() i tipski sigurnu metodu Osoba Clone()


    class Clone
    {
        // TODO:100 Pokrenuti program i pogledati ispis.
        public static void Jednakost()
        {
            Osoba osobaA = new Osoba("Janko", 1);
            Osoba osobaB = osobaA;
            // TODO:103 Otkomentirati donju naredbu i provjeriti ispravnost implementacije metode Clone donjim programom
            //osobaB = (Osoba)osobaA.Clone();
            Console.WriteLine($"{osobaA} ReferenceEquals( {osobaB} ): {Osoba.ReferenceEquals(osobaA, osobaB)}");
            //true, potpuno isto mjesto u memoriji
            Console.WriteLine($"{osobaA} == {osobaB}: {osobaA == osobaB}"); //true
            Console.WriteLine($"{osobaA} != {osobaB}: {osobaA != osobaB}"); //false

            osobaB.PromijeniIme("Pero"); //plitka kopija
            Console.WriteLine($"{osobaA} ReferenceEquals( {osobaB} ): {Osoba.ReferenceEquals(osobaA, osobaB)}");
            Console.WriteLine($"{osobaA} == {osobaB}: {osobaA == osobaB}");
            Console.WriteLine($"{osobaA} != {osobaB}: {osobaA != osobaB}");
        }

        static void Main()
        {
            Jednakost();

            Console.WriteLine("\nGOTOVO!!!");
            Console.ReadKey();
        }
    }
}
