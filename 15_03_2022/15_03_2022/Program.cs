using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_03_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyStack ms = new MyStack();
            Console.WriteLine("Capacitatea stivei este: {0}", ms.Capacity);
            Console.WriteLine("Numarul de elemente din stiva este:{0}", ms.Count);
            Console.WriteLine(ms.IsEmpty ? "Stiva nu contine niciun element" : "In stiva sunt elemente.");
            ms.Push(1);
            Console.WriteLine(ms.IsEmpty ? "Stiva nu contine niciun element" : "In stiva sunt elemente.");
            Console.WriteLine("Numarul elementelor din stiva este: {0}", ms.Count);
            Random rand = new Random();
            for (int i = 0; i < 42; i++)
                ms.Push(rand.Next(100));
            Console.WriteLine("Capacitatea stivei este: {0}", ms.Capacity);
            Console.WriteLine("Numarul de elemente din stiva este: {0}", ms.Count);
            Console.WriteLine("Dumping stack:");
            while (!ms.IsEmpty)
            {
                Console.Write($"{ms.Pop()} ");
            }
            try
            {
                ms.Pop();
            }
            catch (StackEmptyException ex)
            {
                Console.WriteLine(ex.Message);
            }
            //ms.Push(42);
            Console.WriteLine("Numarul de elemente din stiva este: {0}", ms.Count);
            Console.WriteLine(ms.Peek());
            Console.WriteLine("Numarul de elemente din stiva este: {0}", ms.Count);
            Console.ReadKey();

        }
    }
}
