using System;
using System.Collections.Generic;

namespace Compare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Auto auto1 = new Auto("FIAT", 1999);
            Auto auto2 = new Auto("MERCEDES", 1995);
            Auto auto3 = new Auto("BMW", 2000);
            Auto auto4 = new Auto("AUDI", 1989);
            Auto auto5 = new Auto("SKODA", 2015);

            List<Auto> listaSamochodów = new List<Auto>();
            listaSamochodów.Add(auto1);
            listaSamochodów.Add(auto2);
            listaSamochodów.Add(auto3);
            listaSamochodów.Add(auto4);
            listaSamochodów.Add(auto5);

            listaSamochodów.Sort(new AutoComparer());

            foreach (var item in listaSamochodów)
            {
                Console.WriteLine("Marka: {0}\n Rocznik: {1}",item.Model, item.Rocznik);
            }

            Console.ReadKey();
        }
    }
}
