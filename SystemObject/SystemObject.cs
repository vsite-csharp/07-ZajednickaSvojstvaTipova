using System;

namespace Vsite.CSharp.ZajedničkaSvojstvaTipova
{
    // 000 Definirati klasu MojaKlasa bez ikakvih članova, samo s praznom definicijom.
    class MojaKlasa
    {
        // iako smo ju definirali i nismo naveli da je izvedena, implicitno je izvedena iz klase Sytsem.Object,
        // i nasljeđuje sve metode koje ona ima
    }

    class SystemObject
    {
        public static void IspisToString()
        {
            // 001 Otkomentirati donje naredbe.
            // tip: Ctrl + K, U - uncomment
            MojaKlasa mk1 = new MojaKlasa();

            MojaKlasa mk2 = mk1; // deklariramo novu instancu i pridružujemo prvu instancu
                                 // imamo dvije reference koje će pokazivati na isti komad memorije (objekt)

            MojaKlasa mk3 = new MojaKlasa(); // stvaramo novu instancu
                                             // defacto - stvorili smo 2 objekta, prvom objektu smo pridružili 2 reference koje pokazuju na isti objekt

            // 002 Za svaki objekt (mk1, mk2, mk3) pozvati njegovu metodu ToString i ispisati na konzolu ono što ona vraća.
            // tip: cw, 2x tab - ConsoleWriteLine();
            Console.WriteLine(mk1.ToString());
            Console.WriteLine(mk2.ToString());
            Console.WriteLine(mk3); // implicitno je pozvana ToString();

            // budući da nismo override-ali metodu ToString(), pozvat će se implementacija iz System.Object, a ona vraća puno ime dotičnog tipa
            // namespace, ime klase
            // dakle koristi se defaultna implementacija metode ToString();

        }

        public static void IspisGetType()
        {
            // 003 Otkomentirati donje naredbe.
            MojaKlasa mk1 = new MojaKlasa();
            MojaKlasa mk2 = mk1;
            MojaKlasa mk3 = new MojaKlasa();

            // 004 Za svaki objekt (mk1, mk2, mk3) pozvati njegovu metodu GetType i ispisati na konzolu ono što ona vraća.
            // tip: Ctrl + d - duplicate line

            var tip = mk1.GetType(); // tip je System.Type
                                     // preko mehanizma refleksije možemo saznati sve informacije koje su sadržane u ovom tipu
                                     // budući da nema ništa definirano, možemo saznati full name i preko base type-a možemo 
                                     // saznati sve što je taj naslijedio

            Console.WriteLine(tip);
            Console.WriteLine(mk2.GetType());
            Console.WriteLine(mk3.GetType());
        }

        public static void IspisGetHashCode()
        {
            // 005 Otkomentirati donje naredbe.
            MojaKlasa mk1 = new MojaKlasa();
            MojaKlasa mk2 = mk1;
            MojaKlasa mk3 = new MojaKlasa();

            // 006 Za svaki objekt (mk1, mk2, mk3) pozvati njegovu metodu GetHashCode i ispisati na konzolu ono što ona vraća.
            // GetHashCode() metoda bi trebala dati nekakav identifikator koji bi jednoznačno identificirao svaku instancu objekta

            Console.WriteLine(mk1.GetHashCode()); 
            Console.WriteLine(mk2.GetHashCode()); // budući da pokazuju na isti objekt, očekujemo da će hash biti isti za mk1 i mk2
            Console.WriteLine(mk3.GetHashCode()); // vraća drugu vrijednost


        }

        public static void IspisEquals()
        {
            // 007 Otkomentirati donje naredbe.
            MojaKlasa mk1 = new MojaKlasa();
            MojaKlasa mk2 = mk1; // referenca
            MojaKlasa mk3 = new MojaKlasa();

            // 008 Otkomentirati donje naredbe i ispisati na konzolu rezultate usporedbi.
            Console.WriteLine(mk1.Equals(mk2)); // pitamo objekt mk1 je li jednak objektu mk2 -> implementacija Equals() metode u System.Object
                                                // radi usporedbu po referencama -> vraća true
            Console.WriteLine(mk1.Equals(mk3)); // vraća false
            Console.WriteLine(mk2.Equals(mk1)); // true
            Console.WriteLine(mk2.Equals(mk3)); // false 
            Console.WriteLine(mk3.Equals(mk1)); // false
            Console.WriteLine(mk3.Equals(mk2)); // false
        }

        static void Main(string[] args)
        {
            Util.IspisNaslova("Ispis ToString:");
            IspisToString();

            Console.WriteLine();

            Util.IspisNaslova("Ispis GetType:");
            IspisGetType();

            Console.WriteLine();

            Util.IspisNaslova("Ispis GetHashCode:");
            IspisGetHashCode();

            Console.WriteLine();

            Util.IspisNaslova("Ispis Equals:");
            IspisEquals();

            Console.WriteLine("\nGOTOVO!!!");
            Console.ReadKey();
        }
    }
}
