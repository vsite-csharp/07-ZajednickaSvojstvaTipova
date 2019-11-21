using System;

namespace Vsite.CSharp.ZajedničkaSvojstvaTipova
{
    // TODO:000 Definirati klasu MojaKlasa bez ikakvih članova, samo s praznom definicijom.
    class MojaKlasa
    {

    }

    class SystemObject
    {
        public static void IspisToString()
        {
            // TODO:001 Otkomentirati donje naredbe.
            MojaKlasa mk1 = new MojaKlasa();
            MojaKlasa mk2 = mk1;
            MojaKlasa mk3 = new MojaKlasa();

            // TODO:002 Za svaki objekt (mk1, mk2, mk3) pozvati njegovu metodu ToString i ispisati na konzolu ono što ona vraća.
            Console.WriteLine(mk1.ToString());
            Console.WriteLine(mk2.ToString());
            Console.WriteLine(mk3.ToString());
        }

        public static void IspisGetType()
        {
            // TODO:003 Otkomentirati donje naredbe.
            MojaKlasa mk1 = new MojaKlasa();
            MojaKlasa mk2 = mk1;
            MojaKlasa mk3 = new MojaKlasa();

            // TODO:004 Za svaki objekt (mk1, mk2, mk3) pozvati njegovu metodu GetType i ispisati na konzolu ono što ona vraća.
            Console.WriteLine(mk1.GetType());
            Console.WriteLine(mk2.GetType());
            Console.WriteLine(mk3.GetType());
        }

        public static void IspisGetHashCode()
        {
            // TODO:005 Otkomentirati donje naredbe.
            MojaKlasa mk1 = new MojaKlasa();
            MojaKlasa mk2 = mk1;
            MojaKlasa mk3 = new MojaKlasa();

            // TODO:006 Za svaki objekt (mk1, mk2, mk3) pozvati njegovu metodu GetHashCode i ispisati na konzolu ono što ona vraća.
            Console.WriteLine(mk1.GetHashCode());
            Console.WriteLine(mk2.GetHashCode());
            Console.WriteLine(mk3.GetHashCode());
        }

        public static void IspisEquals()
        {
            // TODO:007 Otkomentirati donje naredbe.
            MojaKlasa mk1 = new MojaKlasa();
            MojaKlasa mk2 = mk1;
            MojaKlasa mk3 = new MojaKlasa();

            // TODO:008 Otkomentirati donje naredbe i ispisati na konzolu rezultate usporedbi.
            Console.WriteLine(mk1.Equals(mk2));
            Console.WriteLine(mk1.Equals(mk3));
            Console.WriteLine(mk2.Equals(mk1));
            Console.WriteLine(mk2.Equals(mk3));
            Console.WriteLine(mk3.Equals(mk1));
            Console.WriteLine(mk3.Equals(mk2));
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Ispis ToString");
            IspisToString();

            Console.WriteLine("Ispis GetType");
            IspisGetType();

            Console.WriteLine("Ispis GetHashCode");
            IspisGetHashCode();

            Console.WriteLine("Ispis Equals");
            IspisEquals();

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
