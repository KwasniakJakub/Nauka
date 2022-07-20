using System;

namespace Static_vs_Non_Static_Klasy_i_Obiekty_część_3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CzlowiekStatic.Liczbaludnosci);
            CzlowiekStatic.Liczbaludnosci = 10000;
            //Przy klasach statycznych
            //zmienną liczba ludności nadpisujemy wartością 10000
            //i teraz będzie miała cały czas taką wartość
            Console.WriteLine(CzlowiekStatic.Liczbaludnosci);
            Math.Abs(-2);       //Klasa statyczna(Przechowuje wartości )
            Math.Abs(-5);       


            //Do klas niestatycznych musimy się odwołać poprzez
            //utworzenie nowego obiektu
            Czlowiek czlowiek = new Czlowiek();
            czlowiek.imie = "Marek";
            Console.WriteLine(czlowiek.imie);
            Czlowiek czlowiek2 = new Czlowiek();
            Console.WriteLine(czlowiek2.imie);
            //Przy klasach niestatycznych 
            //Po nadpisaniu jakiejś zmiennej nie zmieniamy jej wartości na stałe
            //Możemy wywołać domyślną zmienną tworząc nowy obiekt na bazie tej samej klasy

            Console.WriteLine(Czlowiek.liczbaLudnosci);
            
            Console.ReadKey();
        }
    }
}
