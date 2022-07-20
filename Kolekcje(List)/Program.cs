using System;
using System.Collections.Generic;
using System.Collections;

namespace Kolekcje_List_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Lista typu generycznego(ma już sprecyzowany typ danych jakie ma przechowywać)

            List<Auto> list = new List<Auto>();
            list.Add(new Auto("BMW"));
            list.Add(new Auto("Mercedes"));
            list.Add(new Auto("Audi"));

            foreach (Auto item in list)
            {
                Console.WriteLine(item.Nazwa);//Możemy się odnosić do typów danych danej klasy
            }
            //Większość metod jest tych samych co w ArrayList

            Console.ReadKey();
        }
    }
}
