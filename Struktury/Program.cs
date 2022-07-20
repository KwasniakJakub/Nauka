using System;

namespace Struktury
{
    //Strukture można porównać do ograniczonej klasy 
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Punkt2D punkt1; //Możemy tworzyć obiekty oparte na strukturach w ten sposób
            Punkt2D punkt2 = new Punkt2D(9, 4);
            punkt1.x = 5;   //Natomiast przy takim spoosobie zmienne nie mają przypisanych domyślnych wartości
            punkt1.y = 10;
            //Punkt2D punkt2;
            //punkt2 = punkt1;
            //punkt2.x = 7;

            Punkt2D punkt3 = punkt1 + punkt2;//Tworzymy przeciążenie operatora dodawania

            Console.WriteLine(punkt1.x);
            Console.WriteLine(punkt1.y);
            Console.WriteLine(punkt1.OdlegloscOdSrodka());
            Console.WriteLine("\n");
            Console.WriteLine(punkt2.x);
            Console.WriteLine(punkt2.y);
            Console.WriteLine(punkt2.OdlegloscOdSrodka());
            Console.WriteLine("\n");
            Console.WriteLine(punkt3.x);
            Console.WriteLine(punkt3.y);
            Console.WriteLine(punkt3.OdlegloscOdSrodka());

            Console.ReadKey();

        }
    }
    struct Punkt2D
    //W strukturach nie możemy przypisywać wartości zmiennym
    {   //Możemuy w strukturze tworzyć konstruktory
        public static Punkt2D operator + (Punkt2D a, Punkt2D b) //
        {
            return new Punkt2D(a.x + b.x, a.y + b.y);
        }
        public Punkt2D(int x, int y)    //Nie możemy utworzyć pustego konstruktora
        {
           this.x = x;//
           this.y = y;
        }
        public int x;
        public int y;
        public double OdlegloscOdSrodka()
        {
            return Math.Round(Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)), 1);
        }
    }
    //struct Punkt3D : IComparable//Struktury możemy dziedziczyć tylko po interfejsach
    //{
    //        public int CompareTo(object obj)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
}
