using System;

namespace Dziedziczenie_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mag p1 = new Mag("Elf", 200, 50);
            Console.WriteLine("Imię: {0}, Punkty HP: {1}, Punkty Many: {2}", p1.imie, p1.punktyHP, p1.mana);
        }
    }
    //Tworymy logikę gry RPG
    class Postac//Prymitywna klasa podstawowa
    {
        //public Postac()
        //{

        //}
        public Postac(string imie, int punktyHP)
        {
            this.imie = imie;
            this.punktyHP = punktyHP;
        }
        public string imie;
        public int punktyHP;
        
    }
    class Mag : Postac
    {
        public Mag(string imie, int punktyHP, int mana) : base (imie,punktyHP)    //Odwołaj się do podstawy
        {                                                                         //Alternatywa dla przypisywania ze słowem kluczowym this
            //this.imie=imie;
            //this.punktyHP=punktyHP;
            this.mana=mana;
        }
        public int mana;
    }
}
