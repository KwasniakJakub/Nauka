using System;

namespace Operacje_na_Stringach__params_i_object_
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            //Program odporny na różnego rodzaju błędy

            //Console.WriteLine("Tekst {0},");
            //object obj = 1;
            //object obj2 = "Tekst";
            Console.WriteLine(GenerujTekst("Mam na imię #0 i mam #1 lat ", "Adam", 22));    //Zabezpieczone przed błędami(czy to podamy 1 argument czy 3)
            Console.ReadKey();
        }
                                                         //Dziedziczy cechy z klasy object
                                                         //Paramsz przyjmuje nieograniczoną liczbe elementów
        public static string GenerujTekst(string tekst,  params object[]args)     //Przy wypisywaniu większej ilośći argumentów lepiej użyć takiego sposobu
        {                                               //Dzięki temu możemy za pomocą funkcji przesyłać parametry o różnych typach
            for (int i = 0; i < args.Length; i++)
            {
                tekst = tekst.Replace("#"+i, args[i].ToString());
            }
            return tekst;
        }
    }
}
