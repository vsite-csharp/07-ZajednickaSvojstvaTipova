using System;
using System.Diagnostics;

namespace Vsite.CSharp.ZajedničkaSvojstvaTipova
{
    // TODO:030 Definirati da klasa Osoba implementira sučelje IEquatable<Osoba>
    public class Osoba : IEquatable<Osoba>, ICloneable
    {
        public object Clone()
        {
            return MemberwiseClone();
        }

        public Osoba(string ime, int matičniBroj)
        {
            m_ime = ime;
            m_matičniBroj = matičniBroj;
        }

        string m_ime;       // član referentnog tipa
        int m_matičniBroj;  // član vrijednosnog tipa

        // TODO:031 Implementirati metodu Equals(Osoba) iz sučelja IEquatable<Osoba> tako da za osobe s istim imenom i istim matičnim brojem rezultat bude true
        public bool Equals(Osoba os)
        {
            if (os == null)
                return false;
            if (m_ime.Equals(os.m_ime) && m_matičniBroj.Equals(os.m_matičniBroj))
                return true;
            return false;
        }

        // TODO:032 Nadglasati (override) metodu Equals(object) tako da poziva Equals(Osoba)
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            return Equals(obj as Osoba);
        }

        //Rješenje - JednakostZaReferentniTip
        public static bool operator ==(Osoba os1, Osoba os2)
        {
            if (((object)os1) == null || ((object)os2) == null)
                return Object.Equals(os1, os2);
            return os1.Equals(os2);
        }

        public static bool operator !=(Osoba os1, Osoba os2)
        {
            if (((object)os1) == null || ((object)os2) == null)
                return !Object.Equals(os1, os2);
            return !(os1 == os2);
        }

        //Rješenje - GetHashCode
        public override int GetHashCode()
        {
            return m_ime.GetHashCode() ^ m_matičniBroj.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("'{0}, {1}'", m_ime, m_matičniBroj);
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

        static void Main(string[] args)
        {
            Console.WriteLine("Usporedba referenci na isti objekt:");
            Osoba osobaA = new Osoba("Janko", 1);
            Osoba osobaB = osobaA;
            UsporedbaOsoba(osobaA, osobaB);
            Console.WriteLine();

            Console.WriteLine("Usporedba s null referencom na objekt istog tipa:");
            UsporedbaOsoba(osobaA, null);
            Console.WriteLine();

            Console.WriteLine("Usporedba dviju osoba s različitim imenima i matičnim brojevima:");
            osobaB = new Osoba("Marko", 2);
            UsporedbaOsoba(osobaA, osobaB);
            Console.WriteLine();

            Console.WriteLine("Usporedba dviju osoba s isitim imenima i različitim matičnim brojevima:");
            osobaB = new Osoba("Janko", 5);
            UsporedbaOsoba(osobaA, osobaB);
            Console.WriteLine();

            Console.WriteLine("Usporedba dviju osoba s isitim imenima i istim matičnim brojevima:");
            osobaB = new Osoba("Janko", 1);
            UsporedbaOsoba(osobaA, osobaB);
            Console.WriteLine();

            Console.WriteLine("Usporedba bezimene osobe s osobom koja ima ime:");
            osobaB = new Osoba(null, 2);
            UsporedbaOsoba(osobaA, osobaB);
            Console.WriteLine();

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
