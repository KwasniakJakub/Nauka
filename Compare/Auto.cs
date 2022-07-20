using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare
{
    internal class Auto :IComparable
    {
        public string Model { get; set; }
        public int Rocznik { get; set; }
        public Auto(string Model, int Rocznik)
        {
            this.Model = Model;
            this.Rocznik = Rocznik;
        }

        //Musi zwracać 3 przedziały wartości
        //liczby dodatnie jeśli podany obiekt(argument) jest większy od porównywalnego
        //liczbe 0 jeśli podany obiekt(argument) jest równy porównywalnemu
        //liczby ujemne jeśli podany obiekt(argument) jest mniejszy od porównywalnego
        public int CompareTo(object obj)//Porównywanie
        {
            var arg = (Auto)obj;
            if (Rocznik < arg.Rocznik)
                return 1;
            else if (Rocznik == arg.Rocznik)
                return 0;
            else
                return -1;

        }
    }
}
