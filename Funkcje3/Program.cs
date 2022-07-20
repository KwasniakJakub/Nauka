using System;

namespace Funkcje3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[2];
            tab[0] = 5;
            tab[1] = 2;
            Console.WriteLine("Przed: " + tab[0] + " , " + tab[1]);
            //int a;
            //Console.WriteLine("Przed: " + a);
            //Test2(ref a);    //Dzięki temu zmieniamy wartość na stałe a nie wracamy do domyślnej 5
            //Test3(out a);
            Test4(ref tab);
            Console.WriteLine("Po: " + tab[0] + " , " + tab[1]);
            Console.ReadKey();
        }
        static void Test(ref int a)     //Jeśli chcemy pracować na orginale używamy referencji(ref)
        {
            a += 5;
            Console.WriteLine("W funkcji: " + a);
        }
        static void Test2(ref int b)     //Jeśli chcemy pracować na orginale używamy referencji(ref)
        {
            b += 5;
            Console.WriteLine("W funkcji: " + b); //w przypadku gdy w funkcji mamy zmienną b a w mainie zmienną a to i tak działa
        }
        static void Test3(out int b)    //out używamy kiedy nie wiemy co chcemy przypisać podczas jej wywoływania
        {
            b = 5;
            b += 5;
            Console.WriteLine("W funkcji: " + b);
        }
        static void Test4(ref int[] tab)    //Działamy na oryginale bez słowa kluczowego ref, ponieważ tablica jest typem złożonym
        {
            //tab[0] = 555;     
            //tab[1] = 222;
            tab = new int[2];   //Gdy tworzymy nową tablicę to wartości są domyślne(te co w mainie)
            tab[0] = -5;        //Bez utworzenia nowej tablicy pracujemy na oryginale i zamieniamy wartości
            tab[1] = -2;        //Możemy również użyć referencji podczas tworzenia tablicy i wtedy również pracujemy na oryginale

            Console.WriteLine("W funkcji: " + tab[0] + " , " + tab[1]);
        }
    }
}
