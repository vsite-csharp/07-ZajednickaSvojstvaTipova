using System;
using System.Diagnostics;

namespace Vsite.CSharp.ZajedničkaSvojstvaTipova
{
    //:031 Definirati da klasa Osoba implementira sučelje IEquatable<Osoba>
    public class Osoba : IEquatable<Osoba>, ICloneable
    {
        public Osoba(string ime, int matičniBroj)
        {
            this.ime = ime;
            this.matičniBroj = matičniBroj;
        }

        string ime;       // član referentnog tipa
        int matičniBroj;  // član vrijednosnog tipa

        //:032 Implementirati metodu Equals(Osoba) iz sučelja IEquatable<Osoba> tako da za osobe s istim imenom i istim matičnim brojem rezultat bude true


        //:033 Nadglasati (override) metodu Equals(object) tako da poziva Equals(Osoba)


        public override string ToString()
        {
            return $"'{ime}, {matičniBroj}'";
        }

        public void PromijeniIme(string novoIme)
        {
            ime = novoIme;
        }

        public bool Equals(Osoba other)
        {
            if (other == null)
                return false;
            if (GetType() != other.GetType())
                return false;
            if (!Equals(ime, other.ime))
                return false;
            return matičniBroj.Equals(other.matičniBroj); //moze i ==
        }

        public override bool Equals(object obj)
        {
            return this.Equals(obj as Osoba); //vrati null ako nemoze i pozove ovi gornji equals
        }

        public override int GetHashCode()
        {
            return ime.GetHashCode() ^ matičniBroj.GetHashCode();
        }

        object ICloneable.Clone()
        {
            return new Osoba(ime, matičniBroj);
        }
        public Osoba Clone()
        {
            return new Osoba(ime, matičniBroj);
        }
    }

    class EqualsZaReferentniTip
    {
        public static void UsporedbaOsoba(Osoba osobaA, Osoba osobaB)
        {
            Console.WriteLine(osobaA);
            Console.WriteLine(osobaB);

            try
            {
                Console.WriteLine(osobaA.Equals(osobaB));
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("POGREŠKA: osobaA je null referenca pa nema metodu Equals!");
            }
            try
            {
                Console.WriteLine(osobaB.Equals(osobaA));
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("POGREŠKA: osobaB je null referenca pa nema metodu Equals!");
            }

            // poziv statičke metode
            Console.WriteLine(Osoba.Equals(osobaA, osobaB));

            Console.WriteLine(Osoba.ReferenceEquals(osobaA, osobaB));
        }

        // TODO:030 Pokrenuti program bez debuggera (Ctrl+F5) i pogledati ispis
        static void Main(string[] args)
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
            Console.ReadKey();
        }
    }
}
