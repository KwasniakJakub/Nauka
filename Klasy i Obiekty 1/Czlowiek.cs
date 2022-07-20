using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasy_i_Obiekty_1
{
    internal class Czlowiek
    {                                   //Jeśli czegoś nie widzimy musimy nadać wyższy priorytet dostępności
        public string imie = "Jakub";   //Dajemy public(modyfikator dostępu) aby main miał dostęp do tej zmiennej (hermetyzacja)
        public string nazwisko = "Kwaśniak";

        public void przedstawSie()
        {
            Console.WriteLine("Mam na imię " + imie + ' ' + nazwisko);
        }
    }
}
