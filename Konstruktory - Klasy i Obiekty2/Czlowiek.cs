using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Konstruktor budujemy w klasie w której chcemy go wywoływać

namespace Konstruktory___Klasy_i_Obiekty2
{
    internal class Czlowiek
    {
        public Czlowiek()
        {

        }
        public Czlowiek(string imieKonstruktora)   //Konstruktor w klasie człowiek(domyślnie nic nie zwraca(VOID))
        {
            imie = imieKonstruktora;
            //Console.WriteLine("Jestem konstruktorem");
            //Podczas tworzenia obiektu na bazie klasy czlowiek
            //Za każdym razem będzie się pojawiał np. powyższy napis 
        }

        public Czlowiek(string imieKonstruktora, string nazwiskoKonstruktora)
        {
            imie = imieKonstruktora;
            nazwisko = nazwiskoKonstruktora;
        }

        //Jeśli czegoś nie widzimy musimy nadać wyższy priorytet dostępności
        public string imie = "BRAK";   //Dajemy public(modyfikator dostępu) aby main miał dostęp do tej zmiennej (hermetyzacja)
        public string nazwisko = "BRAK";

        public void przedstawSie()
        {
            Console.WriteLine("Mam na imię " + imie + ' ' + nazwisko);
        }


        ~Czlowiek()//Destruktor
        {
            //Console.WriteLine("Jestem destruktorem");
            //Podczas usuwania obiektu na bazie klasy czlowiek
            //Za każdym razem będzie się pojawiał np. powyższy napis 
            System.Diagnostics.Trace.WriteLine("Jestem Destruktorem");
            Console.WriteLine("Jestem Destruktorem");
        }

    }
}
