using System;

namespace Dziedziczenie_2_
{
    //Abstrakcyjne metody mogą się znajdować
    //Tylko w abstrakcyjnej klasie
    internal class Program
    {
        static void Main(string[] args)
        {
            Mag p1 = new Mag("Elf", 200, 50);
            //Console.WriteLine("Imię: {0}, Punkty HP: {1}, Punkty Many: {2}", p1.imie, p1.punktyHP, p1.mana);
            p1.Ruch();
            //Postac p2 = new Postac("Elf", 200, 10); - Nie możemy stworzyć obiektu, ponieważ klasa Postac jest abstrakcyjna
        }
    }
    //Tworymy logikę gry RPG
    abstract class Postac//Prymitywna klasa podstawowa
    {
        //public Postac()
        //{

        //}
        public Postac(string imie, int punktyHP)
        {
            this.imie = imie;
            this.punktyHP = punktyHP;
        }

        //public virtual void Ruch() //virtual oznacza że metoda jes otwarta na dalsze doskonalanie i modyfikacje
        //{
        //    Console.WriteLine("Ruch Postaci ");
        //}
        public abstract void Ruch();  

        public string imie;
        public int punktyHP;

    }
    sealed class Mag : Postac   //sealed działa w drugą stronę niż abstract
    {                           //Blokuje opcję dalszego dziedziczenia dla klasy
        public Mag(string imie, int punktyHP, int mana) : base(imie, punktyHP)    //Odwołaj się do podstawy
        {                                                                         //Alternatywa dla przypisywania ze słowem kluczowym this
            //this.imie=imie;
            //this.punktyHP=punktyHP;
            this.mana = mana;   
        }
        //{
        //    Console.WriteLine("Ruch Maga");
        //    base.Ruch();
        //}
        //public void Ruch()  //Wymuszenie słowa kluczowego new
        //{
        //    Console.WriteLine("Ruch Maga ");
        //}

        public int mana;

        public override void Ruch()
        {
            Console.WriteLine("Ruch maga");
        }
    }
    //class SuperMag : Mag  //Nie możemy dziedziczyć z racji klasy sealed
    //{
    //    public SuperMag()
    //    {

    //    }
    //}

}