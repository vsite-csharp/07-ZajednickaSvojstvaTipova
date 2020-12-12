using System;
using System.Diagnostics;

namespace Vsite.CSharp.ZajedničkaSvojstvaTipova
{
    // Equals() override-amo ako želimo napraviti usporedbu objekata po sadržaju

    // 031 Definirati da klasa Osoba implementira sučelje IEquatable<Osoba>

    // budući da nismo override-ali metodu equals
    // za nju se koristi metoda Equals() iz baznog tipa

    // klasu osoba želimo uspoređivati sa objektima tipa Osoba
    // sučelje IEquatable<> definira metodu Equals() koja kao argument tipa prima objekt tipa
    // osoba
    // Ctrl + . na sučelje -> implement interface 
    public class Osoba : IEquatable<Osoba> 
    {
        public Osoba(string ime, int matičniBroj)
        {
            this.ime = ime;
            this.matičniBroj = matičniBroj;
        }

        string ime;       // član referentnog tipa -> defaultno pravo pristupa je private
        int matičniBroj;  // član vrijednosnog tipa

        // 032 Implementirati metodu Equals(Osoba) iz sučelja IEquatable<Osoba> tako da za osobe s istim imenom i istim matičnim brojem rezultat bude true
        // imamo 2 metode Equals(): ovo je tipski sigurna metoda - ova metoda zna da ćemo dobiti
        // objekt tipa Osoba ili eventualno izvedenog tipa
        // a donja metoda override bool Equals(object obj) - prima object
        // jer ta metoda ne zna za niti jedan drugi tip osim za object

        // glavna implementacija ide u ovu metodu
        public bool Equals(Osoba other)
        {
            if (other == null) 
                return false;
            if (GetType() != other.GetType())
                return false;
            if (Osoba.ReferenceEquals(this, other)) // optimizacija -> kada znamo da reference pokazuju na isti komad memorije
                return true;
            return ime == other.ime && matičniBroj == other.matičniBroj;

            // jedan objekt ima pristup privatnim članovima drugog objekta istog tipa
            // pravo pristupa definira se na nivou tipa, a ne pojedinog objekta
        }

        // 033 Nadglasati (override) metodu Equals(object) tako da poziva Equals(Osoba)
        // kada override-amo metodu Equals() iz sučelja IEquatable<>
        // isto tako je dobro override-ati metodu Equals() koja je izvedena iz 
        // bazne klase System.Object

        // ako želimo pravilno ponašanje onda moramo overridea-ti i metodu Equals() koja kao argument prima
        // objekt tipa object

        // upravilu želimo napraviti tipski sigurnu metodu
        // ali moramo radi konzistentnosti - neke metode pozivaju Equals() na object-u
        // moramo implementirati override
        public override bool Equals(object obj) // tu možemo dobiti bilo koji tip podatka
        {
            return Equals(obj as Osoba); // as operator pokušava napraviti cast, i ako ne uspije vraća null ref
        }

        // implementacija GetHashCode() za GetHashCode zadatak
        // ta GetHashCode() metoda mora vratiti integer
        // koji je definiran svim objektima koji se koriste u metodi Equals()
        // budući da u metodi Equals() uspoređujemo ime i matični broj, mi moramo
        // generirati HashCode na osnovu ta dva podatka
        public override int GetHashCode()
        {
            return ime.GetHashCode() ^ matičniBroj.GetHashCode(); // ^ je ExOR, nekakvo pravilo da nam EXOR generira dovoljnu raspodjelu tih brojeva
        }


        public override string ToString()
        {
            return $"'{ime}, {matičniBroj}'";
        }

        public void PromijeniIme(string novoIme)
        {
            ime = novoIme;
        }

        // public bool Equals(Osoba other)
        // {
        //    throw new NotImplementedException();
        // }

        // treba mi za zadatak (klasu) JednakostZaReferentniTip
        // svi operatori se implementiraju kao statičke metode sa javnim pravom pristupa

        // prvi argument je ono što će se naći s lijeve strane, a drugi s desne operatora ==
        public static bool operator ==(Osoba a, Osoba b)
        {
            return Osoba.Equals(a, b);  // može i Equals(a, b);
                                        // poziva statičku metodu Equals() - override-anu metodu 
                                        // public bool Equals(Osoba other) i na taj način će napraviti provjeru
        }

        // moram implementirati i !=
        public static bool operator !=(Osoba a, Osoba b)
        {
            return !(a == b);  
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
            catch (NullReferenceException) // može se dogoditi da je neka osoba null referenca pa hvatamo iznimku
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

        // 030 Pokrenuti program bez debuggera (Ctrl+F5) i pogledati ispis
        // startamo sa without debugging -> jer će debug presresti catch i zaustaviti izvođenje
        static void Main(string[] args)
        {
            Util.IspisNaslova("Usporedba referenci na isti objekt");
            Osoba osobaA = new Osoba("Janko", 1);
            Osoba osobaB = osobaA; // pridružujemo drugu referencu -> pokazuje na istu memoriju
            UsporedbaOsoba(osobaA, osobaB);
  
            Console.WriteLine();

            Util.IspisNaslova("Usporedba s null referencom na objekt istog tipa");
            UsporedbaOsoba(osobaA, null); // trebala bi vratiti false, jer uspoređujemo sa kreiranom osobom
            
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
