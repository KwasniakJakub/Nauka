using System;
using System.Globalization;

namespace CutureInfo___Systematyzacja_nazewnictwa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Weź kultury i wyślij typ wyliczeniowy(kropka lub przecinek) wszystkich możliwych
            //var c = CultureInfo.GetCultures(CultureTypes.AllCultures);
            //foreach (var item in c)
            //{
            //    Console.WriteLine(item.Name);
            //    Console.WriteLine(item.NumberFormat.NumberDecimalSeparator);//Wyświetla w jakich kulturach używana jest . a w jakich ,
            //}

            Console.WriteLine(CultureInfo.CurrentCulture.Name);
            //CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator = ":";//Nie możemy tak zrobić, ponieważ możliwy jest tylko odczyt
            var newCulture = (CultureInfo)CultureInfo.CurrentCulture.Clone();//(CultureInfo) - rzutowanie na cultureinfo
            newCulture.NumberFormat.NumberDecimalSeparator = ":";
            newCulture.NumberFormat.NegativeSign = "MINUS ";//Zastąpiliśmy przecinek słowem minus
            CultureInfo.CurrentCulture = newCulture;

            int a = -5;
            float b = 3.14f;    //W konsoli wyświetla się , zamiast .
            
            Console.WriteLine($"{a}\n{b}");  //Nowszy sposób na wprowadzanie takich danych (tablica asocjacyjna)
            Console.ReadKey();
        }
    }
}
