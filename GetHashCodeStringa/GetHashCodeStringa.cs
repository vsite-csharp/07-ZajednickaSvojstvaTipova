namespace Vsite.CSharp.ZajedničkaSvojstvaTipova
{
    static class GetHashCodeStringa
    {
        static void Main()
        {
            // :080 Pokrenuti program i usporediti ispise. Koja dva znakovna niza daju najbliže brojeve?
            // niti jedan... 
            Console.WriteLine($"cat.GetHashCode() = {"cat".GetHashCode()}");
            Console.WriteLine($"cta.GetHashCode() = {"cta".GetHashCode()}");
            Console.WriteLine($"cap.GetHashCode() = {"cap".GetHashCode()}");
            Console.WriteLine($"car.GetHashCode() = {"car".GetHashCode()}");
            Console.WriteLine($"cut.GetHashCode() = {"cut".GetHashCode()}");

            Console.WriteLine("\nGOTOVO!!!");
        }
    }
}
