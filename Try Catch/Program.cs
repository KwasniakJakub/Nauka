using System;

namespace Try_Catch
{
    //Throw-rzuć/wyrzuć wyjątek
    //exception - wyjątek
    //throw jest ostatnią instrukcją skoku
    //throw new excepiton
    //try - spróbuj
    //nie powinniśmy pisać całej aplikacji w klamrach jednego try(należy zamieszczać jak najmniej kodu)
    //Kolejność wykonywania catchów to od góry do dołu 
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            { 
                Console.WriteLine("Wynik = "+Dzielenie(5)); //W przypadku dzielenia przez 0 mamy już domyślnie taki wyjątek w C#
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Nie można przeprowadzić dzielenia przez 0!!! "+ e.Message);
            }
            catch(Exception e)    //Możmy precyzować jaki wyjątek chcemy przechwytywać(w nawiasach)
            {
                Console.WriteLine("O nie coś poszło nie tak! " + e.Message);
            }
            finally //Wykonuje się zawsze 
            {
                Console.WriteLine("Ja i tak posprzątam");
            }
            Console.ReadKey();
        }

        public static float Dzielenie(int a)
        {
            if(a == 5)  //Sprawdzamy cza a jest równe 5
            {
                throw new Exception("Nigdy nie dziel przez 5");
            }
            //else
            //{
               
            //}
            return 10 / a;  //Podziel dziesięć przez liczbę przypisaną do zmiennej a
        }
    }
}