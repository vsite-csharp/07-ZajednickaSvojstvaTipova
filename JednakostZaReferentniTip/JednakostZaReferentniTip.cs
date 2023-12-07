namespace Vsite.CSharp.ZajedničkaSvojstvaTipova
{
    // 061 U klasi Osoba iz projekta EqualsZaReferentiTip definirati operatore == i != tako da donji primjeri daju očekivane rezultate.

    static class JednakostZaReferentniTip
    {
        static void Jednakost(Osoba? osobaA, Osoba? osobaB)
        {
            Console.WriteLine(string.Format("{0} == {1}: {2}", osobaA, osobaB, osobaA == osobaB));
            Console.WriteLine(string.Format("{0} != {1}: {2}", osobaA, osobaB, osobaA != osobaB));
        }

        // 060 Pokrenuti program i pogledati ispise.
        static void Main()
        {
            Osoba? osobaA = new Osoba("Janko", 1);
            Osoba? osobaB = osobaA;
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
        }
    }
}
