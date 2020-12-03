using System;

namespace Vsite.CSharp.ZajedničkaSvojstvaTipova
{
    using Osoba = EqualsZaVrijednosniTip.Osoba;

    public class JednakostZaVrijedniTip
    {
        public static void Jednakost(Osoba osobaA, Osoba osobaB)
        {
            //  Otkomentirati donje naredbe i provjeriti može li se kod prevesti i izvesti.
            Console.WriteLine($"{osobaA} == {osobaB}: {osobaA == osobaB}");
            Console.WriteLine($"{osobaA} != {osobaB}: {osobaA != osobaB}");

            // TODO:071 Strukturi Osoba u projektu MetodaEqualsZaVrijednosniTip definirati operatore == i != tako da donji primjeri daju očekivane rezultate.
        }

        static void Main(string[] args)
        {

            // dvije osobe s različitim imenima i MB
            Osoba osobaA = new Osoba("Janko", 1);
            Osoba osobaB = osobaA;
            Jednakost(osobaA, osobaB);

            osobaB = new Osoba("Janko", 1);
            Jednakost(osobaA, osobaB);

            osobaB = new Osoba("Darko", 2);
            Jednakost(osobaA, osobaB);

            osobaB = new Osoba("Janko", 2);
            Jednakost(osobaA, osobaB);

            Console.WriteLine("\nGOTOVO!!!");
            Console.ReadKey();
        }
    }
}
