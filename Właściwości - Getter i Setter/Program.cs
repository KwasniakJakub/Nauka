using System;

namespace Właściwości___Getter_i_Setter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Czlowiek Adi = new Czlowiek();
            Adi.imie = "Adrian";
            //Adi.wiek = 20;          //Jeśli ustawimy -20 to będzie to bez sensu (nie można mieć -20 lat)
            //Adi.setWiek(25);
            //Adi.setWiek(-20);
            //Adi.wiek = -20;
            Adi.Wiek = 20;
            Adi.Wiek = -20;

            Console.WriteLine($"Jestem {Adi.imie} lat {Adi.Wiek}.");
            Console.ReadKey();
        }
    }
}
