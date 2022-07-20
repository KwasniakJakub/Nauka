using System;

namespace Enum
{
    //Enum - wyliczenie/typ wyliczeniowy
    //Warto z nich korzystać gdzie tylko się da 
    //Jest swego rodzaju zabezpieczeniem 
    internal class Program
    {
        enum PoryRoku : sbyte            //sbyte(lub inny typ zmiennych) oznacza jakiego typy dane ma przechowywać
        {                               //Wartości się inkrementuja(wystarczy najechać na pory roku)
            Wiosna = 15, Lato = 25, Jesień = 5, Zima = -5  //Z automatu są uznawane jako stringi
        }
        static void Main(string[] args)
        {
            //PoryRoku poraRoku = PoryRoku.Zima;
            PoryRoku poraRoku = (PoryRoku)25;
            Console.WriteLine((int)poraRoku);

            Console.ReadKey();
        }
    }
}
