using System;
using System.Runtime.Intrinsics.Arm;

namespace Instrukcje_warunkowe_if_else_if
{
    class Program
    {
        static void Main(string[] args)
        {
            //INSTRUKCJE IF 

            int a = -1;
            //bool b = a > 0;

            if (a > 0) 
            {
                Console.WriteLine("A jest większe od 0");
            }
            else if (a < 0) 
            {
                Console.WriteLine("A jest mniejsze od 0");
            }
            else
            {
                Console.WriteLine("A jest równe 0");
            }

            int b = 6;
            /*
            if (b > 0)
            {
                Console.WriteLine("b jest większe od 0");
            }
            if (b > 5)
            {
                Console.WriteLine("b jest większe od 5");
            }
            */
            if (b > 0 && b > 5)
            {
                Console.WriteLine("b jest większe od 0");
                Console.WriteLine("b jest większe od 5");
            }
            else if (b > 0)
            {
                Console.WriteLine("b jest większe od 0");
            }
            else if (b > 5)
            {
                Console.WriteLine("b jest większe od 5");
            }
            else if (b == 0)
            {
                Console.WriteLine("b jest równe 0  ");
            }
            //Jeżeli jeden zostanie spełniony to kolejne nie są wykonywane
            //Zamiast if,else if należy użyc 2 razy if lub operatora && i dwóch cw
            //Typ zwracany jest typu bool
            Console.ReadKey();
        }
    }
}
