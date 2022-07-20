using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolekcje_ArrayList_
{
    internal class Auto
    {
        public string Nazwa { get; set; }//Pole
        public Auto(string marka)//Konstruktor
        {
            Nazwa = marka;  //Przechowywanie nazwy danego auta
        }
        public override string ToString()   //Dzięki tej linijce zamiast wyświetlać się nazwa przestrzeni nazw
        {                                   //Będzie wyświetlała się faktyczna zawartość danego elementu listy
            return Nazwa;
        }
    }
}
