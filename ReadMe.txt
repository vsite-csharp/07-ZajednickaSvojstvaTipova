ZajednickaSvojstvaTipova
========================

SystemObject
------------
Ilustrira kako se ponašaju implementacije metoda nasljeđenih 
izravno iz baznog System.Object tipa.


ToString
--------
Primjer nadglasavanja (override) metode ToString


Equals
------
Ilustrira razliku između statičke i nestatičke metode Equals.


EqualsZaReferentniTip
---------------------
Primjer gaženja (override) metode Equals za referentni tip koji je
izveden izravno iz System.Object.
Klasa Osoba sadrži jedno polje referentnog tipa (string m_ime) i jedno
polje vrijednosnog tipa (int m_matičniBroj). Želimo definirati da su
dva objekta tipa Osoba jednaka ako imaju isto ime i isti matični broj.
(Prekrili smo i metodu ToString da bismo dobili ljepši ispis).


EqualsZaIzvedeniReferentiTip
----------------------------
Klasa Student je izvedena iz klase Osoba - njena metoda Equals mora
pozvati Equals bazne klase + napraviti usporedbu polja koja su specifična
za izvedenu klasu.


EqualsZaVrijednosniTip
----------------------
Primjer implementacije metode Equals za vrijednosni tip.


JednakostZaReferentniTip
------------------------
Primjer implementacije operatora == i != za referentni tip.


JednakostZaVrijedniTip
----------------------
Primjer implementacije operatora == i != za vrijednosni tip.


GetHashCodeZaStringa
--------------------
Primjer što vraæa GetHashCode za slične znakovne nizove.


GetHashCode
-----------
Primjer zašto je neophodno pregaziti metodu GetHashCode ako
se pregazi metoda Equals (i obrnuto).


Clone
-----
Primjer implementacije ICloneable sučelja.