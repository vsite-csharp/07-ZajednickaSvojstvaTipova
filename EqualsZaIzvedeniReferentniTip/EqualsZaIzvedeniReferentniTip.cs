﻿using System;
using System.Diagnostics;

namespace Vsite.CSharp.ZajedničkaSvojstvaTipova
{
    // TODO:041 Definirati da klasa Student implementira sučelje IEquatable<Student>
    class Student : Osoba, IEquatable<Student>
    {
        public Student(string ime, int matičniBroj, string smjer, int godina) : base(ime, matičniBroj)
        {
            this.smjer = smjer;
            this.godina = godina;
        }

        string smjer;
        int godina;

        
        public override string ToString()
        {
            return $"{base.ToString()} ({smjer} {godina}.godina)";
        }

        // TODO:042 Implementirati metodu Equals(Student) iz sučelja IEquatable<Student> da uključi dodatne usporedbe da bi studenti bili jednaki samo ako su na istom smjeru i godini.
        // TODO:043 Nadglasati (override) metodu Equals(object) tako da poziva metodu Equals(Student).
        public bool Equals(Student? other)
        {
            if ((this.smjer == other.smjer) && (this.godina == other.godina))
                return base.Equals(other);
            return false;
        }

        public override bool Equals(Object other) {
            if (other == null)
            {
                return false;
            }
            if (this.GetType() != this.GetType())
                return false;

            return Equals((Student) other);
        }
    }

    class EqualsZaIzvedeniReferentiTip
    {
        public static void UsporedbaStudenata(Student studentA, Student studentB)
        {
            Console.WriteLine(studentA);
            Console.WriteLine(studentB);

            try
            {
                Console.WriteLine(studentA.Equals(studentB));
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("POGREŠKA: studentA je null referenca pa nema metodu Equals!");
            }
            try
            {
                Console.WriteLine(studentB.Equals(studentA));
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("POGREŠKA: studentB je null referenca pa nema metodu Equals!");
            }

            Console.WriteLine(Osoba.ReferenceEquals(studentA, studentB));

        }

        // TODO:040 Pokrenuti program i pogledati ispis.
        static void Main(string[] args)
        {
            // dva različita studenta
            Student studentA = new Student("Janko", 1, "Programiranje", 3);
            Student studentB = new Student("Darko", 2, "Administriranje", 2);

            UsporedbaStudenata(studentA, studentB);

            Console.WriteLine();

            // novi "Janko" s istim matičnim brojem, isti smjer i godina
            studentB = new Student("Janko", 1, "Programiranje", 3);
            UsporedbaStudenata(studentA, studentB);

            Console.WriteLine();

            // "Janko", ali na drugoj godini
            studentB = new Student("Janko", 1, "Programiranje", 2);
            UsporedbaStudenata(studentA, studentB);

            Console.WriteLine();

            studentA = studentB;
            UsporedbaStudenata(studentA, studentB);

            Console.WriteLine("\nGOTOVO!!!");
            Console.ReadKey();
        }
    }
}
