using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vsite.CSharp.ZajedničkaSvojstvaTipova
{
    // osnovna ideja gethash metode je da se koristi u nekim tablicama gdje kljuc nije int nego neki objekt
    // recimo zelimo neki rijecnik gdje je kljuc hrv rijec, a vrijednost eng prijevod
    // imamo Dictionary {string, string} rijecnik = new DI... {"auto" : "car"}{"kuca" : "house"}
    // kad zelimo vidjeti prijevod kazemo cw(rijecnik["auto"]); interno - ne dohvaca se preko imena, nego preko gethascode metode
    // hash tablica ce napraviti spremnike u koje ce ubacivati te vrijednosti
    // ono sto je pricao za pretrazivanje.. kad na kolokviju pisu od A-L i tako to
    // kad overrideamo getEquals metodu onda nas trazi da overrideamo i GetHashCode i obrnuto

    // :090 Pokrenuti program i provjeriti ispis.

    // :091 Implementirati metodu GetHashCode u klasi Osoba iz projekta MetodaEqualsZaReferentiTip tako da se metoda Main može izvesti bez problema

    // PLITKA KOPIJA: 
    // pretpostavimo da imamo klasu student i on u sebi sadrzi listu predmeta koji je upisao
    // S  -->  I kad stvorimo studenta automatski stvorimo Ispit koji se nalazi negdje na heapu
    // zelimo stvoriti novi studenta koji ce egzistirati potpuno neovisno o tom objektu
    // onda na heapu stvorimo novi objekt i kazemo == i pokazuje na onaj gore ispit

    // DUBOKA KOPIJA:
    // stvarna kopija - dva objekta postoje potpuno neovisno sa svim clanovima i kad mjenjamo jedan 
    // ne mijenja se drugi
    // da bi napravili takvu kopiju sluzi nam metoda Clone

    class GetHashCode
    {
        static void Main(string[] args)
        {

            Dictionary<Osoba, string> mjestaRođenja = new Dictionary<Osoba, string>();
            mjestaRođenja[new Osoba("Pero", 1)] = "Babina Greda";
            mjestaRođenja[new Osoba("Janko", 2)] = "Jarče Polje";
            mjestaRođenja[new Osoba("Darko", 3)] = "Vukova Gorica";

            Console.WriteLine(mjestaRođenja[new Osoba("Pero", 1)]);
            Console.WriteLine(mjestaRođenja[new Osoba("Janko", 2)]);
            Console.WriteLine(mjestaRođenja[new Osoba("Darko", 3)]);

            Console.WriteLine("\nGOTOVO!!!");
            Console.ReadKey();

        }
    }
}
