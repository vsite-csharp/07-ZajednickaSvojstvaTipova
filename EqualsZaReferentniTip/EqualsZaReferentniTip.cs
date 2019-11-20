﻿using System;
using System.Diagnostics;

namespace Vsite.CSharp.ZajedničkaSvojstvaTipova
{
    // TODO:030 Definirati da klasa Osoba implementira sučelje IEquatable<Osoba>
    public class Osoba
    {
        public Osoba(string ime, int matičniBroj)
        {
            m_ime = ime;
            m_matičniBroj = matičniBroj;
        }

        string m_ime;       // član referentnog tipa
        int m_matičniBroj;  // član vrijednosnog tipa

        // TODO:031 Implementirati metodu Equals(Osoba) iz sučelja IEquatable<Osoba> tako da za osobe s istim imenom i istim matičnim brojem rezultat bude true


        // TODO:032 Nadglasati (override) metodu Equals(object) tako da poziva Equals(Osoba)



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
