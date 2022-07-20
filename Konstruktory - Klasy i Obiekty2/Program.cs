using System;

namespace Konstruktory___Klasy_i_Obiekty2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Z racji ze w konstruktorze uzylismy zmiennej imie typu string
            //To musimy teraz w nawiasach napisać imię naszej osoby
            Czlowiek Adi = new Czlowiek("Marek", "Kowalski");
            Adi.przedstawSie();
            Console.WriteLine(Adi.nazwisko);
            Adi.imie = "Bartek";
            Adi.przedstawSie();
            
            Console.ReadKey();
        }
    }
}
