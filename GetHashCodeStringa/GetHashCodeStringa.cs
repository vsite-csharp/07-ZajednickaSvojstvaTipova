using System;

namespace Vsite.CSharp.ZajedničkaSvojstvaTipova
{
    class GetHashCodeStringa
    {
        static void Main(string[] args)
        {
            // :080 Pokrenuti program i usporediti ispise. Koja dva znakovna niza daju najbliže brojeve?
            // Prvi i zadnji

            Console.WriteLine($"cat.GetHashCode() = {"cat".GetHashCode()}");
            Console.WriteLine($"cta.GetHashCode() = {"cta".GetHashCode()}");
            Console.WriteLine($"cap.GetHashCode() = {"cap".GetHashCode()}");
            Console.WriteLine($"car.GetHashCode() = {"car".GetHashCode()}");
            Console.WriteLine($"cut.GetHashCode() = {"cut".GetHashCode()}");

            Console.WriteLine("\nGOTOVO!!!");
            Console.ReadKey();
        }
    }
}
