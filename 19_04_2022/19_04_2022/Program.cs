using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_04_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Date[] data = new Date[10];
            Random r = new Random();
            for (int i = 0; i < data.Length; i++)
                data[i] = new Date(r.Next(32),r.Next(13),r.Next(2023));
            foreach  (Date item in data)
            {
                Console.WriteLine(item+" "+Verify);
            }
            Console.ReadKey();
        }
    }
}
