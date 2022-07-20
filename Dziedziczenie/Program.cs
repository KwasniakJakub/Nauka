using System;

namespace Dziedziczenie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ziemia ziemia = new Ziemia();
            Mars mars = new Mars();
            ziemia.Atmosfera();
            ziemia.PoraDniaINocy(); //Dzięki dziedziczeniu mamy dostęp do metod w klasach abstrakcyjnych
            ziemia.RuchObrotowy();
            mars.Atmosfera();
            Console.ReadKey();
        }
    }

    abstract class CialoNiebieskie  //abstract(powiązany z dziedziczeniem)
    {                               //Nie możemy tworzyć instancji do klasy abstrakcyjnej
        public string nazwa { get; set; }
        public void RuchObrotowy()
        {
            Console.WriteLine("Każde ciało niebieskie posiada ruch obrotowy");
        }
    }
    abstract class Planeta : CialoNiebieskie //Klasa Planeta dziedziczy pola po Ciału Niebieskim
    {
        public void PoraDniaINocy()
        {
            Console.WriteLine("Pory Dnia i Nocy");
        }
    }
    //Klasy mogą dziedziczyć po sobie kilka razy
    //Dzięki temu mamy kod otwarty na modyfikacje
    class Ziemia : Planeta
    {
        public void Atmosfera()
        {
            Console.WriteLine("Atmosfera Ziemska");
        }
    }
    class Mars : Planeta
    {
        public void Atmosfera()
        {
            Console.WriteLine("Atmosfera Marsa");
        }
    }
}
