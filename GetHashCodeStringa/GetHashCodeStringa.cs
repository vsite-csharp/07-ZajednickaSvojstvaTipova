using System;

namespace Vsite.CSharp.ZajedničkaSvojstvaTipova
{
    class GetHashCodeStringa
    {
        static void Main(string[] args)
        {
            // 080 Pokrenuti program i usporediti ispise. Koja dva znakovna niza daju najbliže brojeve?
            // GetHashCode podsjetimo se, vraća jedinstveni identifikator za svaki objekt
            // HashCode-ovi se generiraju određenim algoritmima
            // osigurava da svaki objekt ima jedinstveni broj
            // ideja je da se ne može repsoducirati preko sadržaja
            // iz sličnih objekata možemo dobiti potpuno različite brojeve

            // smisao je da se koristi u hash tablicama (riječnicima) <ključ, vrijednost>
            
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
