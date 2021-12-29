using System;
using System.Diagnostics;

namespace Vsite.CSharp.ZajedničkaSvojstvaTipova
{
    public class EqualsZaVrijednosniTip
    {
        // :051 Definirati da struktura Osoba implementira sučelje IEquatable<Osoba>
        public struct Osoba : IEquatable<Osoba>
        {
            public Osoba(string ime, int matičniBroj)
            {
                this.ime = ime;
                this.matičniBroj = matičniBroj;
            }

            string ime;
            int matičniBroj;

            // :052 Implementirati metodu Equals(Osoba) iz sučelja IEquatable<Osoba> tako da za osobe s istim matičnim brojem rezultat bude true (bez obzira na ime)
            public bool Equals(Osoba other)
            {
                return matičniBroj.Equals(other.matičniBroj);
            }

            // :053 Nadglasati (override) metodu Equals(object) tako da poziva Equals(Osoba)
            public override bool Equals(object obj)
            {
                if(!(obj is Osoba))
                {
                    return false;
                }
                return base.Equals((Osoba)obj);
            }

            public override string ToString()
            {
                return $"'{ime}, {matičniBroj}'";
            }

            public void PromijeniIme(string novoIme)
            {
                ime = novoIme;
            }

            public static bool operator ==(Osoba o1, Osoba o2)
            {
                return Equals(o1, o2);
            }

            public static bool operator !=(Osoba o1, Osoba o2)
            {
                return !Equals(o1, o2);
            }
        }

        public static void UsporedbaOsoba(Osoba osobaA, Osoba osobaB)
        {
            Console.WriteLine(osobaA);
            Console.WriteLine(osobaB);

            Console.WriteLine(osobaA.Equals(osobaB));
            Console.WriteLine(osobaB.Equals(osobaA));
        }

        // :050 Pokrenuti program i pogledati ispis.
        static void Main(string[] args)
        {
            // dvije osobe s različitim imenima i MB
            Osoba osobaA = new Osoba("Janko", 1);
            Osoba osobaB = new Osoba("Darko", 2);
            UsporedbaOsoba(osobaA, osobaB);

            Console.WriteLine();

            // preslika osobe A
            osobaB = osobaA;
            UsporedbaOsoba(osobaA, osobaB);

            Console.WriteLine();

            // novi "Janko" s istim matičnim brojem
            osobaB = new Osoba("Janko", 1);
            UsporedbaOsoba(osobaA, osobaB);

            Console.WriteLine();

            // "Janko" je odlučio promijeniti spol
            osobaB.PromijeniIme("Mira");
            UsporedbaOsoba(osobaA, osobaB);

            Console.WriteLine("\nGOTOVO!!!");
            Console.ReadKey();
        }
    }
}
