Tämä on yksinkertainen console application observer-mallista, jonka tarkoitus on kuvata observer-mallin rakennetta.

Toiminnallisuus:

- IObserver & Observer: Rajapinta ja luokka viestien vastaanottamiseen. Observer-luokka toteuttaa Notify-metodin, joka tulostaa vastaanotetun viestin.

- Publisher: Luokka, joka ylläpitää listaa. Se tarjoaa metodit tilaajien lisäämiseen, poistamiseen ja viestien lähettämiseen kaikille listalla oleville.

- Program: Ohjelman suorituslogiikka, jossa luodaan julkaisija ja tilaajat, hallinnoidaan tilauksia sekä testataan viestien välitystä käytännössä.

Suorittaminen:

- Kopioi koodi C#-konsolisovellukseen (esim. Program.cs).

- Aja ohjelma dotnet run
