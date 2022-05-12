using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_05_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Basic Queue implementation
            /*
             MyQueue q1 = new MyQueue();
             q1.Enqueue(1);
             q1.Enqueue(2);
             q1.Enqueue(3);
             Console.WriteLine($"Numarul de elemente din coada este: {q1.Count}");
             while (!q1.Empty)
             {
                 Console.WriteLine(q1.Dequeue());

             }
            */

            /*
            Random r = new Random();
            int val;
            MyQueue q2 = new MyQueue(40);
            int maxValue=30;
            for (int i = 0; i < 100; i++)
            {
                int n;
                n = r.Next(4);
                switch (n)
                {
                    case 1:
                        Console.WriteLine(q2.Dequeue());
                        break;
                    default:
                        val = r.Next(maxValue + 1);
                        q2.Enqueue(val);
                        break;
                }
            }
            */

            MyGenericQueue<string> queue = new MyGenericQueue<string>();
            queue.Enqueue("to");
            queue.Enqueue("be");
            queue.Enqueue("or");
            queue.Enqueue("not");
            queue.Enqueue("to");
            queue.Enqueue("be");
            while (queue.Empty == false)
                queue.Dequeue();
            Console.ReadKey();
        }
    }
}
