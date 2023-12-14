﻿namespace Vsite.CSharp.ZajedničkaSvojstvaTipova
{
    // DID_IT:101 Klasi Osoba iz projekta EqualsZaReferentiTip navesti da implementira sučelje ICloneable.

    // DID_IT:102 Implementirati metodu sučelja object ICloneable.Clone() i tipski sigurnu metodu Osoba Clone()


    static class Clone
    {
        // DID_IT:100 Pokrenuti program i pogledati ispis.
        public static void Jednakost()
        {
            Osoba osobaA = new Osoba("Janko", 1);
            Osoba osobaB = osobaA;
            // DID_IT:103 Otkomentirati donju naredbu i provjeriti ispravnost implementacije metode Clone donjim programom
            osobaB = (Osoba)osobaA.Clone();
            Console.WriteLine($"{osobaA} ReferenceEquals( {osobaB} ): {Osoba.ReferenceEquals(osobaA, osobaB)}");
            Console.WriteLine($"{osobaA} == {osobaB}: {osobaA == osobaB}");
            Console.WriteLine($"{osobaA} != {osobaB}: {osobaA != osobaB}");

            osobaB.PromijeniIme("Pero");
            Console.WriteLine($"{osobaA} ReferenceEquals( {osobaB} ): {Osoba.ReferenceEquals(osobaA, osobaB)}");
            Console.WriteLine($"{osobaA} == {osobaB}: {osobaA == osobaB}");
            Console.WriteLine($"{osobaA} != {osobaB}: {osobaA != osobaB}");
        }

        static void Main()
        {
            Jednakost();

            Console.WriteLine("\nGOTOVO!!!");
        }
    }
}
