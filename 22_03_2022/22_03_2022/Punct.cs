using System;

namespace _22_03_2022
{
    internal class Punct
    {
        #region Properties
        public double X { get; set; }
        public double Y { get; set; }
        public Color Color { get; set; }
        #endregion
        #region Constructors
        public Punct() : this(0, 0)
        {
        }

        public Punct(double x, double y)
        {
            X = x;
            Y = y;
            Color = Color.Negru;
            Console.WriteLine($"Am creat un obiect de tip Punct ({X}, {Y}).");
        }

        public Punct(double x) : this(x, 0)
        {
        }
        #endregion
        #region Overrides
        public override string ToString()
        {
            return $"[({X},{ Y}) , {Color}]";
        }
        #endregion
        #region Methods
        public double CalculareDistantaPanaLaOrigine()
        {
            return Math.Sqrt(X * X + Y * Y);
        }

        public double CalculareDistantaPuncte(Punct to)
        {
            return Math.Sqrt(Math.Pow(this.X - to.X, 2) + Math.Pow(this.Y - to.Y, 2));
        }
        public void MoveBy(double dx, double dy)
        {
            X += dx;
            Y += dy;
        }
        // se da x,y si A(alfa) se cere x2,y2.
        public void RotateBy(double angle)
        {

        }
        #endregion
    }
}
