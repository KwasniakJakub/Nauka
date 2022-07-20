using System;

namespace Zmienne_stałe_i_podstawowe_typy_danych
{
    class Program
    {
        static void Main(string[] args)
        {   
            //CAŁKOWITE

            int zmienna = int.MaxValue;
            byte zmienna2 = byte.MaxValue;
            short zmienna3 = short.MaxValue;
            long zmienna4 = long.MaxValue;
            sbyte zmienna5 = sbyte.MaxValue;
            ushort zmienna6 = ushort.MaxValue;
            short zmienna7 = short.MaxValue;
            uint zmienna8 = 1;
            ulong zmienna9 = 1;

            //ZMIENNOPRZECINKOWE

            float zmienna10 = 1.13234F; //Dodajemy sufiks f
            double zmienna11 = 1.123234; //Zapewnia większą precyzję po przecinku
            decimal zmienna12 = 9.2323M; //Dodajemy sufiks M (Przechowuje najwieksze liczby zmiennoprzecinkowe)

            //TEKSTOWE

            string zmienna13 = "1"; //Przechowuje łańcuch znaków
            char zmienna14 = '{'; //Przechowuje 1 znak

            //LOGICZNE

            bool zmienna15 = true;
            bool zmienna16 = 5 > 2;
            bool zmienna17 = 5 < 2 && 5 < 3; //&& oznacza "i", || oznacza lub
            bool zmienna18 = zmienna16; //Przypisywanie wartości

            //STAŁE

            const float PI = 3.14F;

            Console.WriteLine(zmienna);
            Console.WriteLine(zmienna2);
            Console.WriteLine(zmienna3); 
            Console.WriteLine(zmienna4);
            Console.WriteLine(zmienna5);
            Console.WriteLine(zmienna6);
            Console.WriteLine(zmienna7);
            Console.WriteLine(zmienna16);
            Console.WriteLine(zmienna17);
            Console.WriteLine(zmienna18);
            Console.WriteLine(PI);
            Console.ReadKey();

        }
    }
    //sbyte Przechowuje wartość ujemną
    //Po najechaniu na rodzaj zmiennej pokazuje nam
    //wykorzystywany rodzaj typu danych
    //.MaxValue wyświetla maksymalną pojemność danej zmiennej
    
    //short domyślnie przechowuje wartości ujemne, ponieważ
    //domyślnie jest ustawiony na signed, natomiast jeśli
    //ustawimy go na ushort(usigned) będzie przechowywał tylko 
    //wartości dodatnie 
    //Każda zmienna z dopiskiem u nie przyjmie wartości ujemnej

    //Przy zmiennych zmienno przeciwkowych nie ma signed i unsigned
    //var działa na tej zasadzie jak w c++ auto (zmienna inteligentna)

    //Const (stałej) nie można zmieniać wartości
}
