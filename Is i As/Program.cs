using System;

namespace Is_i_As
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //zwierze1 = kot1;//Nadpisanie referencji
            //kot1 = zwierze1;//Nie zadziała z racji hierarchi dziedziczeń 
            Zwierze zwierze1 = new Kot();
            Kot kot1 = new Kot();

            //zwierze1 = new Kot(); //zmieniamy referencje obiektu zwierze1 z Kot na Zwierze
            // kot1 = (Kot)zwierze1;   //Nie mamy natomiast już dostępu do metod z klasy Kot
            //Console.WriteLine(kot1 is Kot); //CZY kot jest Kotem(klasy kot)
            //if(kot1 is Kot)
            //zwierze1 = kot1;

            //Kot kot2 = (Kot)zwierze --Tak nie powinniśmy robić
            Kot kot2 = zwierze1 as Kot;//Jest to dużo lepsza opcja niż powyższa 
            //Jeśli powyższy kod się nie uda, to przy kot2 zostanie przypisany null
            //if(zwierze1 is Kot)
            if(!(kot2 == null))
            {
                //zwierze1 = (Zwierze)kot1;
                //Kot kot2 = (Kot)zwierze1;
                kot2.PijMleko();
                Console.WriteLine("Powiodło się");
            }
            else
            {
                //Kot kot2 = (Kot)zwierze1; Takie rzutowanie się nie powiedzie
                Console.WriteLine("Nie powiodło się");
            }
        }
    }
    class Zwierze
    {
        public void DajGlos()
        {
            Console.WriteLine("Domyślny głos");
        }
    }
    class Kot:Zwierze
    {
        public void PijMleko()
        {
            Console.WriteLine("Pij Mleko");
        }
    }
}
