using System;
using System.Threading;

namespace Konwersja_typow__rzutowanie__komentarze_i_inne
{
    class Program
    {
        public Program()
        {

        }
        static void Main(string[] args)
        {
            //KOMENTARZE

            //SKRÓTY KLAWISZOWE 

            /*
             * ctrl-k + ctrl-d - Formatowanie kodu
             * ctrl-k + ctrl-c - Komentowanie zaznaczonego fragmentu
             * ctrl-k + ctrl-u - Odkomentowanie zaznaaczonego fragmentu
             * f5 - kompilacja kodu
             */

            //SNIPETY

            /*
             * cw - Console.WriteLine()
             * for - po wcisnieciu 2 razy tab od razu ją tworzy
             * while - tworzy petle while
             * ctor - tworzenie konstruktora
             */

            //RZUTOWANIE ZMIENNYCH

            //int i = int.MaxValue;
            ////short s = short.MaxValue;
            //byte s = byte.MaxValue;
            //double d = 5.1;

            //i = (int)d;
            //Console.WriteLine(i);


            //WCZYTYWANIE DANYCH Z KONSOLI

           /* string k = Console.ReadLine();*/ //Przypisanie do zmiennej s tego co jest w konsoli
            //Console.WriteLine(k);

            //if (Console.ReadKey().Key == ConsoleKey.D1)
            //{
            //    Console.WriteLine("PRAWDA");
            //}
            //else
            //{
            //    Console.WriteLine("Nieprawda");
            //}


            //KONWERSJA TYPÓW(STRING > INT, INT > STRING)

            //int l = int.Parse(k) + +2; //konwersja typu tekstowego na liczbowy
            //Console.WriteLine(l);
            //k = l.ToString();
            //Console.WriteLine(k);

            //ŁĄCZENIE TEKSTU & FORMATOWANIE "WRITELINE"

            string s1 = "Witaj";
            string s2 = " Świecie";
            string s3 = s1 + s2; //łączenie tekstu na pomocą zmiennej
            Console.WriteLine(s1 + s2 + "!!!\n{0}{1}", s1, s2); //{0} oznacza indeks który zamieniamy zmienną s1, która zostaje przesłana do konsoli


            //MODYFIKACJA WYGLĄDU KONSOLI

            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.White;
            Console.ResetColor(); //Resetowanie ustawień kolor konsoli
            Console.ReadKey();
            Console.Clear(); // Usuwanie napisów po pobraniu klawisza przez ReadKey

            Console.ReadKey();
        }
    }
}
