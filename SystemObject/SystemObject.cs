﻿namespace Vsite.CSharp.ZajedničkaSvojstvaTipova
{
    // TODO:000 Definirati klasu MojaKlasa bez ikakvih članova, samo s praznom definicijom.


    static class SystemObject
    {
        public static void IspisToString()
        {
            // TODO:001 Otkomentirati donje naredbe.
            //MojaKlasa mk1 = new MojaKlasa();
            //MojaKlasa mk2 = mk1;
            //MojaKlasa mk3 = new MojaKlasa();

            // TODO:002 Za svaki objekt (mk1, mk2, mk3) pozvati njegovu metodu ToString i ispisati na konzolu ono što ona vraća.

        }

        public static void IspisGetType()
        {
            // TODO:003 Otkomentirati donje naredbe.
            //MojaKlasa mk1 = new MojaKlasa();
            //MojaKlasa mk2 = mk1;
            //MojaKlasa mk3 = new MojaKlasa();

            // TODO:004 Za svaki objekt (mk1, mk2, mk3) pozvati njegovu metodu GetType i ispisati na konzolu ono što ona vraća.

        }

        public static void IspisGetHashCode()
        {
            // TODO:005 Otkomentirati donje naredbe.
            //MojaKlasa mk1 = new MojaKlasa();
            //MojaKlasa mk2 = mk1;
            //MojaKlasa mk3 = new MojaKlasa();

            // TODO:006 Za svaki objekt (mk1, mk2, mk3) pozvati njegovu metodu GetHashCode i ispisati na konzolu ono što ona vraća.

        }

        public static void IspisEquals()
        {
            // TODO:007 Otkomentirati donje naredbe.
            //MojaKlasa mk1 = new MojaKlasa();
            //MojaKlasa mk2 = mk1;
            //MojaKlasa mk3 = new MojaKlasa();

            // TODO:008 Otkomentirati donje naredbe i ispisati na konzolu rezultate usporedbi.
            //Console.WriteLine(mk1.Equals(mk2));
            //Console.WriteLine(mk1.Equals(mk3));
            //Console.WriteLine(mk2.Equals(mk1));
            //Console.WriteLine(mk2.Equals(mk3));
            //Console.WriteLine(mk3.Equals(mk1));
            //Console.WriteLine(mk3.Equals(mk2));
        }

        static void Main()
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
        }
    }
}
