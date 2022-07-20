using System;

namespace Instrukcje_switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int liczba = int.Parse(Console.ReadLine());

            //if działa tylko jeśli jako pierwszy argument podajemy już zadeklarowaną zmienną
            //a drugi o takich samych parametrach jak zmienna po lewej 
            //np nie porównamy liczby(int) do zdania(stringa)

            //Zbudowany switch za pomocą instrukcji warunkowych 
            //if(liczba == 1)
            // {
            //     Console.WriteLine("jeden");
            // }
            //else if(liczba == 2)
            // {
            //     Console.WriteLine("Dwa");
            // }
            //else if(liczba == 3)
            // {
            //     Console.WriteLine("trzy");
            // }
            //else
            // {
            //     Console.WriteLine("Inna wartość");
            // }

            //switch (liczba)     //Zmienna w środku switcha i słowa po case muszą być tego samego typu co  nzmienna użyta w nawiasach switcha  
            //{
            //    case 1:                         //Sprawdzanie jakąliczbę podaliśmy
            //        Console.WriteLine("Jeden"); //Co chcemy zrobić
            //        goto koniec;                      //Zamiast break można używać również goto
            //    case 2:
            //        Console.WriteLine("Dwa");
            //        goto case 3;                //Przechodzimy po tym do case 3
            //    case 3:
            //        Console.WriteLine("Trzy");
            //        break;
            //    case 4:
            //    koniec:
            //        Console.WriteLine("koniec");
            //        break;
            //    default:
            //        Console.WriteLine("Inna wartość");
            //        break;
            //}

            //Console.WriteLine("Dodatkowy tekst");

            char znak = 'a';
                switch (znak)
            {
                case 'a':
                    Console.WriteLine("A");
                    goto case 'c';
                case 'b':
                    Console.WriteLine("B");
                    break;
                case 'c':
                    Console.WriteLine("c");
                    break;
                    
            }
            Console.ReadKey();
        }
    }
}
