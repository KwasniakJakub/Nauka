using System;
using System.Diagnostics;

namespace Rekurencje
{
    //Rekurencja - wywołanie metody wewnątrz samej siebie
    internal class Program
    {
        static void Main(string[] args)
        {
            const int liczba = 5;
            Stopwatch stoper = new Stopwatch();
            //Sposób nierekurencyjny
            stoper.Start();
            Console.WriteLine(Silnia(liczba));
            stoper.Stop();
            Console.WriteLine(stoper.ElapsedTicks); //Wyświetlanie ticków procesora

            stoper.Reset();

            stoper.Start();
            Console.WriteLine(SilniaRek(liczba));
            stoper.Stop();
            Console.WriteLine(stoper.ElapsedTicks); //Wyświetlanie ticków procesora

            Console.ReadKey();
        }
        private static long SilniaRek(int x)
        {
            //Zawsze w przypadku rekurencji musi być chodziaż 1 przypadek domyślny
            if(x <= 1)
            {
                return 1;
            }
            else
            {
                return SilniaRek(x - 1) * x;
            }
        }
        private static long Silnia(int x)
        {
            long wynik = 1;
            while(x > 1)
            {
                wynik *= x;
                x--;
            }
            return wynik;
        }
    }
}
