using System;

namespace Try_Catch_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Wynik " + Dzielenie(5));
            }
            //catch (DivideByZeroException e)
            //{
            //    Console.WriteLine("Dzielisz przez 0"+e.Message);
            //}
            catch(DivideByFiveException exc)
            {
                Console.WriteLine("Wyjątek dzielenia  przez 5\n"+exc.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("O nie, coś poszło nie tak" + e.Message); ;
            }
            Console.ReadKey();
        }
        public static float Dzielenie(int a)
        {
            if(a == 5)
            {
                throw new DivideByFiveException("Wystąpił błąd");
            }
            return 10 / a;
        }
    }
    class DivideByFiveException : Exception //Dziedziczymy o exception
    //Warto kod z wyjątkami umieszczać w osobnym pliku
    {
        public DivideByFiveException()
        {
            Console.WriteLine("BŁĄD");
        }
        //W ten sposób można również przekazać inny wyjątek
        //z którego wyniknął drugi
        //public DivideByFiveException(string message, Exception innerException) : base(message, innerException)
        //{

        //}
        public DivideByFiveException(string message) : base(message)
        {

        }
    }
}
