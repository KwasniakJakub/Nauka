using System;
using System.Linq;

namespace Tablice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TABLICE(zbiór dużej ilości danych pod jedną nazwą)

            //int temperatura1 = ;
            //int temperatura2 = ;
            //I tak to temperatura365
            //JEDNOWYMIAROWE                //Ilość elementów w tablicy
            int[] tablicaTemperatur = new int[365]; //Najczęściej używany sposób 
            string[] dniTygodnia = { "poniedziałek", "wtorek", "środa", "czwartek", "piątek", "sobota", "niedziela" };   //Drugi sposób rzadziej użwany

            //tablicaTemperatur[0] = 22;  //Odwołanie sie do indeksu 0
            //tablicaTemperatur[364] = 23;
            //Console.WriteLine(tablicaTemperatur[364]);

            for (int i = 0; i < dniTygodnia.Length; i++) //Będzie się wykonywac dopoki nie przekroczy max dlugosci tablicy dniTygodnia
            {
                Console.WriteLine(dniTygodnia[i]);
            }
            Console.WriteLine();

            //DWUWYMIAROWA(TABLICE TABLIC/PODTABLICE)

            int[,] tablica = new int[2, 3];      //Inicjowanie tabeli dwuwymiarowej
            int[,,] tablica2 = new int[2, 3, 4]; //Inicjowanie tablicy trzywymiarowej
            
            int[][] tablica3 = new int[2][];    //Inicjowanie tablicy tablic z dwoma kontenerami
            tablica3[0] = new int[3];           //Zapisanie do 2 kontenerów tablicy nowych tablic
            tablica3[1] = new int[2];

            int[] tablica4 = new int[4];
            tablica4[0] = 5;
            tablica4[1] = 3;
            tablica4[2] = 10;
            tablica4[3] = 1;

            Console.WriteLine();
            //Console.WriteLine(tablica4.Max());    //Wypisanie najwiekszej wartosci tablicy
            //Console.WriteLine(tablica4.Sum());    //Wypisanie sumy wartości tablicy
            Console.WriteLine();
            
            for (int i = 0; i < tablica4.Length; i++)
            {
                Console.Write(tablica4[i] + " ");
            }

            Console.WriteLine();
            Array.Sort(tablica4);

            Console.WriteLine("Posortowana tablica:");
            for (int i = 0; i < tablica4.Length; i++)
            {
                Console.Write(tablica4[i] + " ");
            }

            Console.WriteLine();
            Array.Reverse(tablica4);
            Console.WriteLine("Odwrócona tablica");
            
            for (int i = 0; i < tablica4.Length; i++)
            {
                Console.Write(tablica4[i] + " ");
            }

            Console.WriteLine();

            tablica3[0][0] = 2;
            tablica3[0][1] = 5;
            tablica3[0][2] = 3;
            tablica3[1][0] = 32;
            tablica3[1][1] = 42;

            //Wyświetlanie tablicy tablic pętlą
            for (int i = 0; i < tablica3.Length; i++)
            {
                for (int j = 0; j < tablica3[i].Length; j++)
                {
                    Console.Write(tablica3[i][j] + " ");
                }
                Console.WriteLine();
            }

            tablica[0, 0] = 1;
            tablica[0, 1] = 2;
            tablica[0, 2] = 3;
            tablica[1, 0] = 10;
            tablica[1, 1] = 25;
            tablica[1, 2] = 56;

            //Wyświetlanie tablicy dwuwymiarowej pętlą
            for (int i = 0; i < tablica.GetLength(0); i++)
            {
                for (int j = 0; j < tablica.GetLength(1); j++)
                {
                    //Console.Write(tablica[i, j] + " ");
                }
                //Console.WriteLine();
            }

            //Console.WriteLine(tablica.Length);
            Console.WriteLine("Długość drugiego wymiaru wynosi " + tablica.GetLength(1));    //Wyświetlanie wielkości danego wymiaru tablicy(0 lub 1)
            Console.WriteLine(tablica3.GetLength(0));
            Console.ReadKey();
        }
    }
}
