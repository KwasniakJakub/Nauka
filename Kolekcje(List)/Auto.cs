using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolekcje_List_
{
    internal class Auto
    {
        public string Nazwa { get; set; }
        public Auto(string marka)
        {
            Nazwa = marka;
        }
        public void UruchomSilnik()//Można wywołać tą metodę dziedzicząc z listy 
        {

        }
    }
}
