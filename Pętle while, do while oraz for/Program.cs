using System;

namespace Pętle_while__do_while_oraz_for
{
    class Program
    {
        static void Main(string[] args)
        {
            //  WHILE | FOR | DO WHILE

            int a = 0;
            while (a < 5 ) //true
            {
                Console.WriteLine(a);
                Console.WriteLine("Tekst");
                a++;
            }

            for (int i = 0; i < 10; i++) //i jest dostępne tylko w nawiasach klamrowych danej pętli
            {
                Console.WriteLine(i+" Tekst");
            }

            do
            {
                Console.WriteLine(a);
                a++;
            } while (a <= 100);//true
            

            Console.ReadKey();
        }
    }
}
