using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vsite.CSharp.ZajedničkaSvojstvaTipova
{
    // 090 Pokrenuti program i provjeriti ispis.

    // 091 Implementirati metodu GetHashCode u klasi Osoba iz projekta MetodaEqualsZaReferentiTip tako da se metoda Main može izvesti bez problema

    class GetHashCode
    {
        static void Main(string[] args)
        {
            // imamo riječnik (hash tablica) - za svaku osobu pridružujemo datum rođenja
            // preko Osobe dolazimo do mjesta rođenja

            // ključ je string -> za svaku osobu je pridruženo mjesto rođenja

            // hash tablice jednostavno od objekata koje služe kao ključ prilikom ubacivanja zatraži njegov hash code
            // i taj hash code mu služi da bi napravio (uvjetno rečeno, to se zove vjedro) u koje stavi dotični objekt

            // kada naleti na drugi objekt, drugi ključ, iz njega će napraviti drugi hash code
            // napravit će u tablici novo vjedro (novu kantu) u koju će staviti drugi objekt
            // i tako zna iz kojeg "vjedra" izvaditi tu vrijednost

            // može se dogoditi da sva različita objekta imaju isti hash code, bez obzira što smo mi implementirali GetHashCode() metodu
            // ako u vjedru nađe više objekata, onda kod za pronalaženje objekta ide od objekta do objekta i za njih koristi metodu Equals()
            // i uspoređuje jesu li ta dva objekta jednaka

            Dictionary<Osoba, string> mjestaRođenja = new Dictionary<Osoba, string>();
            mjestaRođenja[new Osoba("Pero", 1)] = "Babina Greda";
            mjestaRođenja[new Osoba("Janko", 2)] = "Jarče Polje";
            mjestaRođenja[new Osoba("Darko", 3)] = "Vukova Gorica";

            Console.WriteLine(mjestaRođenja[new Osoba("Pero", 1)]); // key not found exception
                                                                    // ovaj dictionary za pristup objektu koristi njegov GetHashCode
                                                                    // defaultna implementacija od GetHashCode od System.Object generira
                                                                    // HashCOde na osnovu memorisjke lokacije u kojima je taj objekt stvoren
                                                                    // ovdje pokušavamo preko identičnog ključa, ali sada je to nova osoba, novo mjesto rođenja
                                                                    // GetHashCode neće biti identičan jer se radi o različitim memorijskim lokacijama

                                                                    // da bi osigurali da možemo pristupiti preko identičnih osoba
                                                                    // očito moramo override-ati GetHashCode metodu i na neki način osigurati
                                                                    // da će Osobe s istim imenom i matičnim brojem daju isti GetHashCode

                                                                    // na Osoba definiramo implementaciju GetHashCode metode


            Console.WriteLine(mjestaRođenja[new Osoba("Janko", 2)]);
            Console.WriteLine(mjestaRođenja[new Osoba("Darko", 3)]);

            Console.WriteLine("\nGOTOVO!!!");
            Console.ReadKey();

        }
    }
}
