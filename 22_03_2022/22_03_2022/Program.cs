using System;

namespace _22_03_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Punct p1 = new Punct { X = 2.4, Y = 4.3 };

            Punct p2 = new Punct();

            Punct p3 = new Punct(3, 4);

            Punct p4 = new Punct(5);

            Punct p5 = new Punct(5.0, 6.0) { Color = Color.Verde };

            Console.WriteLine(p5);
            Console.WriteLine($"Distanta de la origine la punctul {p1} este {p1.CalculareDistantaPanaLaOrigine()}");
            Console.WriteLine($"Distanta dintre punctul {p1} si punctul {p2} {p1.CalculareDistantaPuncte(p2)}");

            Punct p6 = new Punct(1, 1);
            Console.WriteLine(p6);
            p6.MoveBy(2, 2);
            Console.WriteLine(p6);
            Console.ReadKey();
        }
    }
}
