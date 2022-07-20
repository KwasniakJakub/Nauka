using System;
using System.Threading;

namespace Pierwsze_programy
{
    class Program
    {
       static void Main(string[] args)
        {
            //WYŚWIETL W KONSOLI PROSTOKĄT O SZEROKOŚCI X ORAZ WYSOKOŚCI Y
            //X ORAZ Y PODAJE UŻYTKOWNIK, PROSTOKĄT ZBUDOWANY JEST Z "+"
            /*
            Console.Write("Podaj szerokość: "); //Samo write nie przechodzi do nowej lini (jak writeline)
            string xs = Console.ReadLine();
            Console.Write("Podaj wysokość: ");
            string ys = Console.ReadLine();
            Console.WriteLine();

            int x = int.Parse(xs); //Konwersja jawna stringa na int
            int y = int.Parse(ys);

            for (int i = 0; i < y; i++) //Wysokosc
            {
                for (int j = 0; j < x; j++) //Szerokosc
                {
                    Console.Write("+");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
            */

            //GRA W ZGADYWANIE LICZBY WYLOSOWANEJ PRZEZ KOMPUTER
            //KOMPUTER PDAJE LICZBĘ Z ZAKRESU 1-10
            //UŻYTKOWNIK PRÓBUJE ODGADNĄĆ WYLOSOWANĄ LICZBĘ
            //JEŻELI PODANA LICZBA JEST MNIEJSZA LUB WIĘKSZA OD WYLOSOWANEJ - WYŚWIETLA KOMUNIKAT
            //KIEDY UŻYTKOWNIK ODGADNIE LICZBĘ, WYŚWIETL INFORMACJĘ O INFORMACJĘ O WYGRANEJ

            Random rnd = new Random(); //Instancja klasy random o nazwie rnd
            int los = rnd.Next(1,11); //Pierwsza wartość oznacza minimalną liczbę, druga maksymalną + 1 
            int mojaLiczba;
            int ileRazy = 0;
            Console.WriteLine("Zgadnij liczbę z zakresu 1-10");

            do
            { 
                Console.Write("Podaj liczbę: 1:10  ");
                mojaLiczba = int.Parse(Console.ReadLine());
                if (mojaLiczba > 10)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Podałeś za dużą liczbę.");
                }
                else if (mojaLiczba < 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Podałeś za małą liczbę.");
                }
                else
                {
                    ileRazy++;
                    if (mojaLiczba > los)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Podałeś zbyt dużą liczbę");
                    }
                    else if (mojaLiczba < los)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Podałeś zbyt małą liczbę");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Gratulacje\nUdało ci się odgadnąć liczbę\nzgadłeś ją za {0} razem", ileRazy);
                        Console.ResetColor();
                    }
                }
            } while (los != mojaLiczba);

            Console.ReadKey();
        }
    }
}
