﻿namespace Vsite.CSharp.ZajedničkaSvojstvaTipova
{
    using Osoba = EqualsZaVrijednosniTip.Osoba;

    static public class JednakostZaVrijedniTip
    {
        public static void Jednakost(Osoba osobaA, Osoba osobaB)
        {
            // TODO:070 Otkomentirati donje naredbe i provjeriti može li se kod prevesti i izvesti.
            //Console.WriteLine($"{osobaA} == {osobaB}: {osobaA == osobaB}");
            //Console.WriteLine($"{osobaA} != {osobaB}: {osobaA != osobaB}");

            // TODO:071 Strukturi Osoba u projektu EqualsZaVrijednosniTip definirati operatore == i != tako da donji primjeri daju očekivane rezultate.
        }

        static void Main()
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
        }
    }
}
