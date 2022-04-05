using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _22_03_2022;
namespace _05_04_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // creati o structura de date care sa defineasca un dreptunghi cu atributele:
            // - un punct care reprezinta coordonatele stanga sus
            // - lungimea
            // - latimea
            // constructori: 
            // - cu 4 parametri (x, y, lungime, latime)
            // - cu 3 parametri ( punct, lungime latime)
            // - cu 2 parametri (lungime si latime) x=0,y=0
            // - fara parametri toate valorile pe 0
            // Metode:
            // - aria
            // - perimetru
            Rectangle rectangle = new Rectangle(new Punct(1, 1), 10, 15);
            Console.WriteLine(rectangle);
            Console.ReadKey();
        }
    }
}
