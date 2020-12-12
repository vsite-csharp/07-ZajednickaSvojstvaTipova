using System;

namespace Vsite.CSharp.ZajedničkaSvojstvaTipova
{
    class MojaKlasa
    {
    }

    struct MojaStruktura
    {
    }

    class MetodaEquals
    {
        public static void UsporedbaKlasa()
        {
            MojaKlasa mk1 = new MojaKlasa();
            MojaKlasa mk2 = null;

            // 020 Usporediti objekte mk1 i mk2 korištenjem statičke metode MojaKlasa.Equals te ispisati rezultat

                // System.Object radi usporedbu po referenci, ako 2 instance pokazuju na isti objekt
                // Equals će vratiti true
                // ponekad želimo usporediti dvije različite instance objekta i usporediti njihove sadržaje
                // ne želimo jednakost po identitetu, nego jednakost po vrijednosti (sadržaju) tih objekata

            Console.WriteLine(MojaKlasa.Equals(mk1, mk2)); // poziva Equals iz System.Object, nisam morao navesti MojaKlasa. ...
            // za referentne tipove je bolje koristiti statičku metodu Equals, jer ona u svom tijelu provjeri je li neki 
            // od objekata null referenca
            // prvo provjeri jesu li oba null reference -> vraća true
            // provjerava je li jedan od objekata null referenca, ako je vraća false
            // na kraju poziva Equals na jednom od objekata i tek onda ulazi u igru ova donja metoda (koja bi vratila exception da ju direktno pozivamo)

            // 021 Usporediti reference na objekte mk1 i mk2 korištenjem statičke metode MojaKlasa.ReferenceEquals te ispisati rezultat

            // ReferenceEquals() uvijek radi usporedbu po referencama, ako mi override-amo Equals za neki tip (možemo definirati drugačije ponašanje)
            // ReferenceEquals() će uvijek vraćati usporedbu po referencama
            Console.WriteLine(MojaKlasa.ReferenceEquals(mk1, mk2));


            // 022 Usporediti objekte mk1 i mk2 pozivom metode mk1.Equals te ispisati rezultat
            Console.WriteLine(mk1.Equals(mk2));

            // 023 Usporediti objekte mk1 i mk2 pozivom metode mk2.Equals te ispisati rezultat
            // Console.WriteLine(mk2.Equals(mk1)); // rezultat ove 2 metode bi trebao biti isti, ali tu će se dogoditi null reference exception (mk2 = null)
            // defacto ne postoji mk2 -> niti nema metodu Equals


        }

        public static void UsporedbaStruktura()
        {
            // 024 Stvoriti dvije strukture ms1 i ms2 na isti način kao i za gornje instance klasa mk1 i mk2
            MojaStruktura ms1 = new MojaStruktura();
            MojaStruktura ms2 = new MojaStruktura();
            // MojaStruktura ms2 = null; -> strukturi ne možemo pridružiti null referencu (osim ako nije nullable)

            // 025 Usporediti objekte ms1 i ms2 korištenjem statičke metode MojaStruktura.Equals te ispisati rezultat
            Console.WriteLine(MojaStruktura.Equals(ms1,ms2));
            // za vrijednosne tipove Equals ne radi usporedbu po adresama, nego po sadržaju tih struktura
            // prolazi sve članove strukture i pojedinačno uspoređuje članove -> to omogućava mehanizam refleksije
            // ako su identični vraća true, inače false

            // 026 Usporediti objekte ms1 i ms2 pozivom metode ms1.Equals te ispisati rezultat
            Console.WriteLine(ms1.Equals(ms2));

            // 027 Usporediti objekte ms1 i ms2 pozivom metode ms2.Equals te ispisati rezultat
            Console.WriteLine(ms2.Equals(ms1));

        }

        static void Main(string[] args)
        {
            Util.IspisNaslova("Usporedba klasa");
            UsporedbaKlasa();

            Console.WriteLine();

            Util.IspisNaslova("Usporedba struktura");
            UsporedbaStruktura();

            Console.WriteLine("\nGOTOVO!!!");
            Console.ReadKey();
        }
    }
}
