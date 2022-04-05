using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_03_2022
{
    internal class Rectangle
    {
        public Punct Point { get; set; }
        public int Lenght { get; set; }
        public int Width { get; set; }


        public override string ToString()
        {
            return $"Avem un punct dreptunghi care incepe la {Point.X} X si {Point.Y} Y si are lungimea {Lenght} si latimea {Width}.";
        }
    }
}
