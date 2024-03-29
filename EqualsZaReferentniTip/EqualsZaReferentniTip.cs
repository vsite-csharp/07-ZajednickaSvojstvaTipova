﻿namespace Vsite.CSharp.ZajedničkaSvojstvaTipova
{
    // TODO:031 Definirati da klasa Osoba implementira sučelje IEquatable<Osoba>
    public class Osoba
    {
        public Osoba(string? ime, int matičniBroj)
        {
            this.ime = ime;
            this.matičniBroj = matičniBroj;
        }

        private string? ime;               // član referentnog tipa
        private readonly int matičniBroj;  // član vrijednosnog tipa

        // TODO:032 Implementirati metodu Equals(Osoba) iz sučelja IEquatable<Osoba> tako da za osobe s istim imenom i istim matičnim brojem rezultat bude true


        // TODO:033 Nadglasati (override) metodu Equals(object) tako da poziva Equals(Osoba)


        public override string ToString()
        {
            return $"'{ime}, {matičniBroj}'";
        }

        public void PromijeniIme(string novoIme)
        {
            ime = novoIme;
        }
    }

    static class EqualsZaReferentniTip
    {
        public static void UsporedbaOsoba(Osoba? osobaA, Osoba? osobaB)
        {
            Console.WriteLine(osobaA);
            Console.WriteLine(osobaB);

            try
            {
                Console.WriteLine(osobaA?.Equals(osobaB));
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("POGREŠKA: osobaA je null referenca pa nema metodu Equals!");
            }
            try
            {
                Console.WriteLine(osobaB?.Equals(osobaA));
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("POGREŠKA: osobaB je null referenca pa nema metodu Equals!");
            }

            // poziv statičke metode
            Console.WriteLine(Osoba.Equals(osobaA, osobaB));

            Console.WriteLine(Osoba.ReferenceEquals(osobaA, osobaB));
        }

        // TODO:030 Pokrenuti program i pogledati ispis
        static void Main()
        {
            Util.IspisNaslova("Usporedba referenci na isti objekt");
            Osoba osobaA = new Osoba("Janko", 1);
            Osoba osobaB = osobaA;
            UsporedbaOsoba(osobaA, osobaB);
  
            Console.WriteLine();

            Util.IspisNaslova("Usporedba s null referencom na objekt istog tipa");
            UsporedbaOsoba(osobaA, null);
            
            Console.WriteLine();

            Util.IspisNaslova("Usporedba dviju osoba s različitim imenima i matičnim brojevima");
            osobaB = new Osoba("Marko", 2);
            UsporedbaOsoba(osobaA, osobaB);
            
            Console.WriteLine();

            Util.IspisNaslova("Usporedba dviju osoba s istim imenima i različitim matičnim brojevima");
            osobaB = new Osoba("Janko", 5);
            UsporedbaOsoba(osobaA, osobaB);
            
            Console.WriteLine();

            Util.IspisNaslova("Usporedba dviju osoba s istim imenima i istim matičnim brojevima");
            osobaB = new Osoba("Janko", 1);
            UsporedbaOsoba(osobaA, osobaB);
            
            Console.WriteLine();

            Util.IspisNaslova("Usporedba bezimene osobe s osobom koja ima ime");
            osobaB = new Osoba(null, 2);
            UsporedbaOsoba(osobaA, osobaB);
            
            Console.WriteLine("\nGOTOVO!!!");
        }
    }
}
