using System;
using System.Collections;
using System.Collections.Generic;

namespace Kolecje_Queue__Stack_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Różni się tym, że nie możemy w standardowy sposób dodawać elementów do kolejki
            //Kolejka
            //Queue<int> queue = new Queue<int>();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //Console.WriteLine(queue[1]); Nie możemy odnosić się do konkretnego indeksu
            //Console.WriteLine(queue.Peek());    //Służy do podejrzenia tego co jest na samej górze
            //Console.WriteLine(queue.Dequeue()); //Służy do wyświetlania elementu (z każdym kolejnym wystąpieniem będzie pojawiał się kolejny element)
            //Console.WriteLine(queue.Dequeue());
            //queue.Enqueue(9);//Będzie na samym dole, ponieważ elementy są dodawane na koniec
            //Console.WriteLine(queue.Dequeue());
            //Console.WriteLine(queue.Peek()); //Nie zadziałą, ponieważ nie można odczytywać elementów z już pustej kolekcji

            //Stos
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            //Console.WriteLine(stack.Peek());    //Wyświetla ostatni element stosu
            //Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Pop());     //Wyświetla/Zdejmuje elementy ze stosu od końca
            Console.WriteLine(stack.Pop());
            stack.Push(9);  //W przeciwieństwie do kolejki w stosie wpierw pojawi się 9 a na koncu wprowadzona 3
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());

            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}
            Console.ReadKey();
        }
    }
}