using System;

namespace Funkcje2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Dodaj(2, 7));
            Console.ReadKey();
        }
        static string Dodaj(int a, int b)
        {
            int wynik = a + b;
            if (wynik > 10)
            {
                return "Wynik większy od 10";   //Przy innym typie funkcji niż void należy użyć return a nie console.writeline
            }
            else
            {
                return "Wynik mniejszy od 10";
            }   
        }
    }
}
