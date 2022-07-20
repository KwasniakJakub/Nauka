using System;
using System.Collections;
using System.Collections.Generic;

namespace Kolekcje_Dictionary_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Różni się od listy tym, że pierwszy typ danych
            //To klucz kolekcji, a drugi to wartość która przechowuje kolekcja

            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(1, "Ania");
            dictionary.Add(2, "Bartek");
            //dictionary.Add(2, "Ola"); Klucze nie mogą się powtarzać
            if (!dictionary.ContainsKey(2))
                dictionary.Add(2, "Ola");//Nie zostanie dodany, ponieważ instrukcja warunkowa to zablokuje
            dictionary.Add(3, "Ola");
            dictionary.Add(4, "Ola");
            // indeksy nie muszą być wstawiane po kolei
            dictionary.Add(100, "Maciej");

            foreach (var item in dictionary)
            {
                Console.WriteLine("{0} : {1}", item.Key, item.Value);
            }
            Console.ReadKey();
        }
    }
}
