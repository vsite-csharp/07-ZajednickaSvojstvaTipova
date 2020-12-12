using System;
using System.Diagnostics;

namespace Vsite.CSharp.ZajedničkaSvojstvaTipova
{
    // 061 U klasi Osoba iz projekta MetodaEqualsZaReferentiTip definirati operatore == i != tako da donji primjeri daju očekivane rezultate.

    // do sada smo imali metodu Equals(), uz tu metodu zgodno je implementirati operator == radi jednostavnosti
    // tako da osobe možemo uspoređivati jednostavno operatororm ==
    

    
    class JednakostZaReferentniTip
    {
        static void Jednakost(Osoba osobaA, Osoba osobaB) // korisitmo Osobu iz drugog projekta, tamo implemetiramo operator == (F12 - go to definition na Osoba)
        {
            Console.WriteLine(string.Format("{0} == {1}: {2}", osobaA, osobaB, osobaA == osobaB));
            Console.WriteLine(string.Format("{0} != {1}: {2}", osobaA, osobaB, osobaA != osobaB));
        }

        // 060 Pokrenuti program i pogledati ispise.
        static void Main(string[] args)
        {
            Osoba osobaA = new Osoba("Janko", 1);
            Osoba osobaB = osobaA;
            Jednakost(osobaA, osobaB);

            // novi "Janko" s istim matičnim brojem
            osobaB = new Osoba("Janko", 1);
            Jednakost(osobaA, osobaB);

            // novi "Janko" s drugim matičnim brojem
            osobaB = new Osoba("Janko", 2);
            Jednakost(osobaA, osobaB);

            // dvije osobe s različitim imenima i MB
            osobaB = new Osoba("Darko", 2);
            Jednakost(osobaA, osobaB);

            osobaB = null;
            Jednakost(osobaA, osobaB);

            osobaA = null;
            Jednakost(osobaA, osobaB);

            Console.WriteLine("\nGOTOVO!!!");
            Console.ReadKey();
        }
    }
}
