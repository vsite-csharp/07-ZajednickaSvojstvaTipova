using System;
using System.Diagnostics;

namespace Vsite.CSharp.ZajedničkaSvojstvaTipova
{
    // TODO:040 Definirati da klasa Student implementira sučelje IEquatable<Student>
    class Student : Osoba
    {
        public Student(string ime, int matičniBroj, string smjer, int godina) : base(ime, matičniBroj)
        {
            m_smjer = smjer;
            m_godina = godina;
        }

        string m_smjer;
        int m_godina;

        // TODO:041 Implementirati metodu Equals(Student) iz sučelja IEquatable<Student> da uključi dodatne usporedbe da bi studenti bili jednaki samo ako su na istom smjeru i godini.


        // TODO:042 Nadglasati (override) metodu Equals(object) tako da poziva metodu Equals(Student).



        public override string ToString()
        {
            return string.Format("{0} ({1} {2}.godina)", base.ToString(), m_smjer, m_godina);
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

        static void Main(string[] args)
        {
            // dva različita studenta
            Student studentA = new Student("Janko", 1, "Programiranje", 3);
            Student studentB = new Student("Darko", 2, "Administriranje", 2);

            UsporedbaStudenata(studentA, studentB);

            // novi "Janko" s istim matičnim brojem, isti smjer i godina
            studentB = new Student("Janko", 1, "Programiranje", 3);
            UsporedbaStudenata(studentA, studentB);

            // "Janko", ali na drugoj godini
            studentB = new Student("Janko", 1, "Programiranje", 2);
            UsporedbaStudenata(studentA, studentB);

            studentA = studentB;
            UsporedbaStudenata(studentA, studentB);

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
