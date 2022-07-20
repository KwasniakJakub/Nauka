using System;

namespace Funkcje_1
{
    internal class Program
    {
        static void Main(string[] args) //Main to funkcja(metoda)
        //Należy wpisać słowo kluczowe static
        //void(pustka/nic) - nie zwraca wyniku(można zastępowac czymś innym)
        //Main to nazwa metody(rozpoczya się zawsze od metody main). Można użyć innych nazw
        //W nawiasach przekazujemy argumenty(w tym przypadku typ string i jego nazwa args)
        //      f(x) - nazwaFunkcji(jakiśArgument)  
        {

            // Console.WriteLine("Witaj " + args[0]);
            //Wyświetla witaj jakub, ponieważ we właściwościach projektu, w zakładce
            //debugowanie wpisalismy w argumencie wiersza polecenia "Jakub"

            int c = 5;
            Dodaj(2, 4);    //Przekazujemy dwie wartości do funkcji dodawania
            Dodaj(2, c);    //Również działa
            Dodaj2(2, 6);
            Dodaj3(2, 4, d:2);      //d:2 przypisujemy argumentowi d 2 i pomijamy c
            Console.ReadKey();  
        }
        static void Dodaj(int a, int b)
        {
            int wynik = a + b;
            Console.WriteLine("Wynik dodawania: " + wynik);
        }
        static void Dodaj(int a, int b, int c)
        {
            int wynik = a + b + c;
            Console.WriteLine("Wynik dodawania: " + wynik);
        }
        static void Dodaj2(int a, int b, int c = 0)  //Jeśli przypiszemy do c 0 można wywołać funkcję z dwoma argumentami
        {
            int wynik = a + b + c;
            Console.WriteLine("Wynik dodawania: " + wynik);
        }
        static void Dodaj3(int a, int b, int c = 2, int d = 0)  //Jeśli przypiszemy do c 0 można wywołać funkcję z dwoma argumentami
        {
            int wynik = a + b + c;
            Console.WriteLine("Wynik dodawania: " + wynik);
        }

    }
}
