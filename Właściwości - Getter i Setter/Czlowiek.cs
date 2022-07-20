using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Właściwości___Getter_i_Setter
{
    internal class Czlowiek
    {
        public string imie;
        private int wiek1;

        //I Sposób

        //public int getWiek()
        //{
        //    return wiek;
        //}
        //public void setWiek(int w)
        //{
        //    //Logika biznesowa
        //    if (w >= 0 && w <= 200) 
        //    wiek = w;
        //}
        ////Dzięki dwóm metodom mamy możliwość pobrania oraz ustawienia wartości

        //Utworzy zmienną i będzie możliwy w niej odczyt i zapis 
        // public int wiek { get; set; }   //Zastępujemy zmienną właściwością (snippet prop)

        //Pełne properties(snippet propfull)

        private int wiek;
        public int Wiek   //Zmienna rozbudowana(właściwość/properties)
        {
            get { return wiek; }
            set
            {   if(value >= 0 && value <= 200)  //Jeśli jest większe od 0 i mniejsze od 200
                    wiek = value;               //Wtedy przypisz wartość
                else
                    wiek = 0;
            }
        }

    }
}
