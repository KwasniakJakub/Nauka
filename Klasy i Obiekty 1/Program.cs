using System;
//Klasa w przeciwieństwie do funkcji nie ma nawiasów ()[]

namespace Klasy_i_Obiekty_1
{
    internal class Program
    {
        static void Main(string[] args) //W programowaniu obiektowym nie używamy słowa kluczowego static 
        {
            Czlowiek Adi = new Czlowiek();   //Tworzymy obiekt (instancje) o nazwie Adi, o typie klasy Czlowiek
            Console.WriteLine(Adi.imie);    //Wypisujemy imie Jakub 
            Adi.imie = "Bartek";            //Zmieniamy imię na Bartek (nie nadpisujemy zmiennej w klasie)
            Adi.nazwisko = "Kołacz";
      
            Console.WriteLine(Adi.imie);

            Czlowiek Adi2 = new Czlowiek();
            Console.WriteLine(Adi2.imie);   //Wypisze Jakub, nie Bartek, ponieważ nie nadpisalismy imienia w klasie 
            Adi.przedstawSie();
            Adi2.przedstawSie();
            Console.ReadKey();
        }
    }
}
