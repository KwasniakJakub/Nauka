using System;

namespace Operatory_arytmetyczne_i_logiczne
{
    class Program
    {
        static void Main(string[] args)
        {
            const string STALA = "Hello"; //Stała której wartość musimy od razu przypisać
            string zmienna; //= "Hello"; //Rezerwujemy pamięć dla zmiennej
            zmienna = "Hello"; //Przypisujemy wartość
            Console.WriteLine(zmienna);
            

            //OPERATORY ARYTMETYCZNE (MATEMATYCZNE)

            int a = 5;
            int b = 9;
            int c;

            c = b % a; //modulo oznacza Podzielmy b/a i zwróćmy resztę
            a += b;
            a++; //Wykorzystywane do skakania po indeksach(inkrementacja)
            a--; //Dekrementacja

            //OPERATORY LOGICZNE

            bool d = 2 >= 1; //Sprawdzanie czy lewa strona jest większa lub równa prawej
            bool e = 2 == 2; //Sprawdzanie czy lewa strona równa się prawej
            bool f = 2 != 2; //Sprawdzanie czy lewa strona jest różna od prawej
            
            //OPERATOR JEDNOARGUMENTOWY (negacja)

            bool g = !(2 == 2); //Wyświetla odwrotność (w typ przypadku false)
            bool h = !(3 == 2); //Wyświetla odwrotność (w typ przypadku true)
            
            //KONIUNKCJA LOGICZNA

            bool i = 1 == 1 && 1!=1; //&& oznacza "i"
            bool j = 1 == 1 || 1 != 1 || false || false; //|| oznacza "lub"
            bool k = true || true && false;

            //WARTOŚĆ BEZWZGLĘDNA

            
            Console.WriteLine(a);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(g);
            Console.WriteLine(h);
            Console.WriteLine(i);
            Console.WriteLine(j);
            Console.WriteLine(k);
            Console.WriteLine(Math.Pow(2, 3));//Pierwsza cyfra oznacza liczbę podnoszoną, druga oznacza potęge
            Console.WriteLine(Math.Sqrt(9)); //Pierwiastek z liczby 9
            Console.WriteLine(Math.Abs(-5)); //Wartość bezwzględna z liczby 5
            Console.ReadKey();
        }
    }
    //Jeśli chcemy uzyskać wynik dzielenia z uwzględnieniem
    //liczb po przecinku, to należy wykorzystać zmienne typu
    //float

}
