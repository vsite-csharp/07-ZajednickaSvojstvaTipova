namespace Vsite.CSharp.ZajedničkaSvojstvaTipova
{
    // :090 Pokrenuti program i provjeriti ispis.

    // :091 Implementirati metodu GetHashCode u klasi Osoba iz projekta EqualsZaReferentiTip tako da se metoda Main može izvesti bez problema

    static class GetHashCode
    {
        static void Main()
        {
            Dictionary<Osoba, string> mjestaRođenja = new Dictionary<Osoba, string>();
            mjestaRođenja[new Osoba("Pero", 1)] = "Babina Greda";
            mjestaRođenja[new Osoba("Janko", 2)] = "Jarče Polje";
            mjestaRođenja[new Osoba("Darko", 3)] = "Vukova Gorica";

            Console.WriteLine(mjestaRođenja[new Osoba("Pero", 1)]);
            Console.WriteLine(mjestaRođenja[new Osoba("Janko", 2)]);
            Console.WriteLine(mjestaRođenja[new Osoba("Darko", 3)]);

            Console.WriteLine("\nGOTOVO!!!");
        }
    }
}
