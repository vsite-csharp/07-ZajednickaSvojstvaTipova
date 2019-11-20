using System;
using System.Diagnostics;

namespace Vsite.CSharp.ZajedničkaSvojstvaTipova
{
    // TODO:100 Klasi Osoba iz projekta MetodaEqualsZaReferentiTip navesti da implementira sučelje ICloneable

    // TODO:101 Implementirati metodu sučelja object ICloneable.Clone() i tipski sigurnu metodu Osoba Clone()


    class Clone
    {
        public static void Jednakost()
        {
            Osoba osobaA = new Osoba("Janko", 1);
            Osoba osobaB = osobaA;
            // TODO:102 Otkomentirati donju naredbu i provjeriti ispravnost implementacije metode Clone donjim programom
            //osobaB = osobaA.Clone();
            Console.WriteLine(string.Format("{0} ReferenceEquals( {1} ): {2}", osobaA, osobaB, Osoba.ReferenceEquals(osobaA, osobaB)));
            Console.WriteLine(string.Format("{0} == {1}: {2}", osobaA, osobaB, osobaA == osobaB));
            Console.WriteLine(string.Format("{0} != {1}: {2}", osobaA, osobaB, osobaA != osobaB));
        }

        static void Main()
        {
            Jednakost();

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
