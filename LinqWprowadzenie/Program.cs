using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqWprowadzenie
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var listaIntow = new List<int>()
            {
                3,7,8,11,2,1
            };
            var listaStringow = new List<string>()
            {
                "Ala",
                "Ma",
                "Dużego",
                "Kota",
                "I",
                "",
                "Samochód"
            };
            var listaUzytkownikow = new List<Uzytkownik>()
            {
                new Uzytkownik
                {
                    imie = "Patryk",
                    nazwisko = "Kowalski",
                    Email = "Patryk.Kowalski@gmail.com"
                },
                new Uzytkownik
                {
                    imie = "Maciek",
                    nazwisko = "Gola",
                    Email = "Maciek.Gola@gmail.com"
                },
                new Uzytkownik
                {
                    imie = "Piotr",
                    Email = "Patryk.Kowalski@gmail.com"
                },
                null    //4 uzytkownik jako null
            };
            //Wszystkie operacje są leniwe(Wszystkie dane wpierw przetwarzamy i zapisujemy, ale nie robimy żadnych struktur(nie są w kodzie i nie możemy ich użyć), a gdy potrzebujemy ich użyć tworzymy z nich strukture)
            //Przetwarza tylko to co potrzebujemy
            //ToList ZAWSZE ZAGNIEŻDZAMY NA KOŃCU
            // listaIntow.Select(x => x + 2).ToList();  //Gdy nie używamy klamer to return-ujemy automatycznie

            //listaUzytkownikow.Select(x => x.imie);
            //listaUzytkownikow.Select(x => new //Samo new tworzy klase anonimowa
            //{
            //    imie = x.imie,
            //    nazwisko = x.nazwisko
            //}).Select(x => x.imie);

            //var listaNazwiskUzytkownikow = listaUzytkownikow.Where(x => !string.IsNullOrEmpty(x.nazwisko));//Nie wyrzuca wyjątku, ponieważ jest lazyloading (where się nie wykonał, bo nie zrobiliśmy tolist)  
            var listaNazwiskUzytkownikow = listaUzytkownikow.Where(x => x != null && !string.IsNullOrEmpty(x.nazwisko)).ToList();//Tutaj wyrzuci wyjątek, chyba że damy x != null
            listaNazwiskUzytkownikow.ForEach(x =>
            {
                Console.WriteLine(x.imie + " " + x.nazwisko);   //Wypisze za pomocą linq
            });

            //var listaNazwiskUzytkownikow2 = listaUzytkownikow.Where(x => x != null && x.nazwisko == "Bla").First(); //Przy first nie dajemy ToList (Wyrzuci wyjątek, ponieważ nie mamy w liście elementu z nazwiskiem "Bla")
            //var uzytkownik = listaUzytkownikow.Where(x => x != null && x.nazwisko == "Bla").FirstOrDefault();
            //if(uzytkownik != null)
            //{
            //    Console.WriteLine(uzytkownik.imie + " " + uzytkownik.nazwisko);   //Lepszy sposób niż powyższy(nie wyrzuci wyjątku)
            //}

            //var uzytkownik = listaUzytkownikow.Where(x => x != null && x.imie == "Piotr").FirstOrDefault(); //Jeśli mamy where(warunek).FirstOrDefault możemy dać w miejsce where firstordefault bez where
            //if (uzytkownik != null)
            //{
            //    Console.WriteLine(uzytkownik.imie + " " + uzytkownik.nazwisko);   //Lepszy sposób niż powyższy(nie wyrzuci wyjątku)
            //}

            //var uzytkownik = listaUzytkownikow.Where(x => x != null && x.Email == "Patryk.Kowalski@gmail.com").Skip(1).FirstOrDefault(); //Skip pomija pierwszy element napotkany spełniający warunek
            //if (uzytkownik != null)
            //{
            //    Console.WriteLine(uzytkownik.imie + " " + uzytkownik.nazwisko);   //Lepszy sposób niż powyższy(nie wyrzuci wyjątku)
            //}

            var posortowaneStringi = listaStringow.OrderBy(x => x).ToList();
            var posortowaneStringi2 = listaStringow.OrderByDescending(x => x).ToList(); //Odwrotne sortowanie
            var sumaIntów = listaIntow.Sum(x => x);
            Console.WriteLine(sumaIntów);

            //Grupowanie po mailach

            listaUzytkownikow.Where(x => x != null).GroupBy(x => x.Email).ToList().ForEach(x =>
            {
                Console.WriteLine(x.Key);

                x.ToList().ForEach(y =>
                {
                    Console.WriteLine(y.imie);
                });

            }) ; 

            //foreach (var a in listaIntow)
            //{
            //}
            //Przyjmuje inta i zwraca inta
            //Func<int, int> function = (a) => { return a; };                  //WYRAŻENIE LAMBDA
            //Action function2 = () => { Console.WriteLine("HelloWorld"); };   //WYRAŻENIE LAMBDA
            //Action function3 = (a) =>  Console.WriteLine(a);
            //function2();
            //function2.Invoke();

        }
    }
}
