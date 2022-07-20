using System;
using System.IO;

namespace Operacje_na_plikach__.txt_
{
    //Exists-istnieje
    //Przy tworzeniu ścieżk dajemy na początku @ lub podwójne //
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"plik.txt"; //path-ścieżka(do pliku)
            StreamWriter sw; //Zmienna na bazie obiektu StreamWriter
            if (!File.Exists(path))
            {
                //Tworzenie pliku za pomocą stingWritera
                sw = File.CreateText(path); //Stworzenie textu w pliku o ścieżce przypisanej w path
                Console.WriteLine("Plik został utworzony");
            }
            else
            {                             //Ustawiamy również na true
                sw = new StreamWriter(path, true); //Jeśli plik nie istnieje to tworzymy nowy plik
                Console.WriteLine("Plik został otwarty"); 
            }
            Console.WriteLine("Podaj tekst: ");
            string tekst = Console.ReadLine();
            sw.WriteLine(tekst); //Zapisanie do pliku sw stringa pobranego w konsoli zapisanego pod zmienną tekst
            sw.Close(); //Zamykamy aby zwolnić miejsce

            StreamReader sr = File.OpenText(path); //Odczytujemy 
            string s = "";
            int i = 1;
            Console.WriteLine("\nZAWARTOŚĆ PLIKU: ");
            while((s = sr.ReadLine()) != null) //Odczytywanie do momentu pustej lini (dopóki jest różne od nullnull)
            {
                Console.WriteLine(i++ + ". " + s);
            }
            sr.Close();

            Console.ReadKey();
        }
    }
}
