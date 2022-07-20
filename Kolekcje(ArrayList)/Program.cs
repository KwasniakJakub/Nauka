using System;
using System.Collections;

namespace Kolekcje_ArrayList_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kolekcja przechowuje więcej niż 1 element
            //Jej wielkość jest dynamiczna(można dodawać i usuwać elementy)

            ArrayList list = new ArrayList();
            //list[]  //Ustawianie elementów poprzez odnoszenie się do indeksów
            list.Add(2);
            list.Add("Bartek"); //Możemy do 1 listy dodawać dowolne i różne typy danych
            list.Add(new Auto("BMW"));
            Console.WriteLine("Rozmiar przed usunięciem {0}",list.Count);
            list.RemoveAt(1);
            Console.WriteLine("Rozmiar po usunięciem {0}", list.Count);            //Console.WriteLine(list.Count);
            Console.WriteLine(list[1]);
            //Po usunięciu elementów listy jej rozmiar zostaje zmieniony
            //Nie zostają puste indeksy
            list.Insert(0, "Ala");//Ala jest teraz na początku(pierwsza wartość to indeks a druga to zawartość)
            list.Clear();   //Tablica zostaje wyczyszczona  nic już się nie wyświetla w pętli
            //Console.WriteLine(list[1]);
            //Console.WriteLine(list[2]); //Jest wyświetlana przestrzeń nazw
            Console.WriteLine("\nPętla foreach:\n");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }

}
