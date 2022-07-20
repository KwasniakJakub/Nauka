using System;
using System.Diagnostics;
using System.Text;


namespace Operacje_na_stringach__StringBuilder_
    //tworzenie obiektu na bazie StringBuilder działa na takiej samej zasadzie
    //Jak zwykła konkatenacja.
    //ctrl + . pokazuje inteligentny tag (IDE podpowiada co możemy zrobić aby zlikwidować błąd)
{


    internal class Program
    {
        static void Main(string[] args)
        {
            //konkatenacja 
            //string tekst = "Tekst";
            //string tekst2 = "Tekst";
            //string wynik = tekst+ tekst2;
            //Console.WriteLine(wynik);
            //Console.ReadKey();
            Stopwatch stopwatch = new Stopwatch();
            int ile = 50000;

            stopwatch.Start();//Włączenie licznika
            BudujString(ile);
            stopwatch.Stop();//Zatrzymanie licznika
            Console.WriteLine("Standardowa metoda {0} ms", stopwatch.ElapsedMilliseconds);  //Standardowy sposób
            stopwatch.Reset();//Resetowanie licznika

            stopwatch.Start();
            BudujStringBuilder(ile);
            stopwatch.Stop();
            Console.WriteLine("Metoda StringBuilder {0} ms", stopwatch.ElapsedMilliseconds);
            Console.ReadKey();
        }
        //Tworzenie komentarza do metody za pomocą trzech "/"
        /// <summary>
        /// Metoda buduje string 
        /// </summary>
        /// <param name="ile">Podaj długość pętli</param>
        /// <returns>Zwracamy gotowy tekst</returns>
        public static string BudujString(int ile)
        {
            string tekst = "";
            for (int i = 0; i < ile; i++)
            {
                tekst += i;
            }
            return tekst;
        }
        public static string BudujStringBuilder(int ile)
        {
            string tekst = "";
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < ile; i++)
            {
                stringBuilder.Append(i);    //Działa na takiej samej zasadzie jak konkatenacja
            }
            //Nie możemy go odczytać w czasie tworzenia, ponieważ nie jest to tak naprawdę string
            //Więc musimy przekonwertować na string-a
            tekst = stringBuilder.ToString();
            return tekst;
        }

    }
}
