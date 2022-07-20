using System;

namespace Interfejsy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Postac p1 = new Postac("Elf", 200);
            //p1.Atak(100);

            //W taki sposób odwołujemy się do metod z implementacją jawną...
            IAtakMieczem atak = (IAtakMieczem)p1; 
            atak.Atak(25);
            IAtakMagiczny atak2 = (IAtakMagiczny)p1;
            atak2.Atak(50);
            Console.ReadKey();
        }
    }

    interface IAtakMagiczny//Interfejs może przechowywać metody jak klasy (zmiennych nie może)
    {
        //void atak()
        //{
        //    Console.WriteLine();  MMetody w interfejsach nie mogą posiadać również ciała
        //}

        void Atak(int pktAtaku);

    }
    interface IAtakMieczem
    {
        //Za każdym razem gdy dodamy nową metodę
        //To musimy implementować nowy interfejs
        //void AtakSpecjalny(int pktAtaku);
        //void AtakSpecjalnySuper(int pktAtaku);

        void Atak(int pktAtaku);
    }

    class Postac : IAtakMagiczny, IAtakMieczem    //Możemy dziedziczyć tylko po 1 klasie lub po kilkunastu interfejsach
    {
        public Postac(string imie, int punktyHP)
        {
            this.imie = imie;
            this.punktyHP = punktyHP;
        }
        public string imie;
        public int punktyHP;

        void IAtakMagiczny.Atak(int pktAtaku)
        {
            Console.WriteLine("IAtakMagiczny");
        }

        void IAtakMieczem.Atak(int pktAtaku)
        {
            Console.WriteLine("IAtakMieczem");
        }

        //public void Atak(int pktAtaku)
        //{
        //    Console.WriteLine("Zadano {0} punktów obrażeń",pktAtaku);
        //}



        //public void AtakSpecjalny(int pktAtaku)
        //{
        //    Console.WriteLine();
        //}

        //public void AtakSpecjalnySuper(int pktAtaku)
        //{
        //    Console.WriteLine();
        //}
    }
}
