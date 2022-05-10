using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_05_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyQueue q1 = new MyQueue();
            q1.Enqueue(1);
            q1.Enqueue(2);
            q1.Enqueue(3);
            Console.WriteLine($"Numarul de elemente ramase in coada este: {q1.Count}");
            while (!q1.Empty)
            {
                Console.WriteLine(q1.Dequeue());
            }
            MyGenericQueue<int> q2 = new MyGenericQueue<int>();
            Random rnd = new Random();
            for (int i = 1; i <= 40; i++)
            {
                int op = rnd.Next(3);
                if (op <= 2)
                {
                    int val = rnd.Next(1000);
                    q2.Enqueu(val);
                    Console.WriteLine("enqueue - " + val);
                }
                else
                {
                    q2.Dequeue();
                    Console.WriteLine("dequeue - " );

                }
            }

            Console.ReadKey();

        }
    }
}
