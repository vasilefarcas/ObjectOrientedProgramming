using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _22_03_2022;
namespace _05_04_2022
{
    public class Rectangle : IEquatable<Rectangle>
    {
        public Punct TopLeft { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }

        public Rectangle(Punct topleft, int height, int width)
        {
            TopLeft = topleft;
            Height = height;
            Width = width;
        }
        public Rectangle() : this(new Punct(0, 0), 0, 0) { }
        public override string ToString()
        {
            return $"Rectangle [{TopLeft.X},{TopLeft.Y}], {TopLeft.Color}, Width= {Width}, Height= {Height}.";
        }
        public override bool Equals(object? obj) => Equals(obj as Rectangle);
        public bool Equals(Rectangle? other)
        {
            if (other == null)
                return false;
            if (Object.ReferenceEquals(this, other))
                return true;
            if (this.GetType() != other.GetType())
                return false;
            return other.TopLeft.X == TopLeft.X &&
                other.TopLeft.Y == TopLeft.Y &&
                other.Width == Width &&
                other.Height == Height;
            return true;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(TopLeft.X, TopLeft.Y, Width, Height);
        }
    }
}
