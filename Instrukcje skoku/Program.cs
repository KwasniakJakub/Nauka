using System;

namespace Instrukcje_skoku
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // INSTRUKCJE SKOKU


            int a = 0;
        //while (true)
        //{
        //    if(a > 10) //Jeśli a dojdzie do 10 to pęta się przerwie za pomocą break;
        //    {
        //        break;
        //    }
        //    Console.WriteLine(a);
        //    a++;
        //}
        //Console.WriteLine(a);

        //for (int i = 0; i < 10; i++)
        //{
        //    if (i % 2 == 1)
        //    {
        //        continue; //Kontunuuj ignorująć liczby parzyste(ignoruj to co jest dalej i przejdź do kolejnego obiegu pętli )
        //    }
        //    Console.WriteLine(i);
        //}

        jeden:          //etykiety
            Console.WriteLine("Jeden");
            goto trzy; //Po wykonaniu tej lini idź do etykiery 3 i pomiń reszte
        dwa:
            Console.WriteLine("Dwa");
        trzy:
            Console.WriteLine("Trzy");
            goto jeden;


            Console.ReadKey();
        }
    }
}
