using System;
using System.Diagnostics;

namespace Vsite.CSharp.ZajedničkaSvojstvaTipova
{
    // Klasi Osoba iz projekta MetodaEqualsZaReferentiTip navesti da implementira sučelje ICloneable.

    // Implementirati metodu sučelja object ICloneable.Clone() i tipski sigurnu metodu Osoba Clone()
    



    class Clone
    {
        //  Pokrenuti program i pogledati ispis.
        public static void Jednakost()
        {
            Osoba osobaA = new Osoba("Janko", 1);
            Osoba osobaB = osobaA;
            // Otkomentirati donju naredbu i provjeriti ispravnost implementacije metode Clone donjim programom
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
            Console.ReadKey();
        }
    }
}
