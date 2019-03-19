using System;
namespace Lesson05.Properties
{
    public class Vector
    {
        public Vector(Point begin, Point end)
        {
            X = end.X - begin.X;
            Y = end.Y - begin.Y;
        }
        public Vector()
        {

        }
        public int X { get; set; }
        public int Y { get; set; }

        public static Vector operator +(Vector v1, Vector v2)
        {
            return new Vector { X = v1.X + v2.X, Y = v1.Y + v2.Y };
        }

        public static Vector operator -(Vector v1, Vector v2)
        {
            return new Vector { X = v1.X - v2.X, Y = v1.Y - v2.Y };
        }
        public static Vector operator *(Vector v1, int n)
        {
            v1.X *= n;
            v1.Y *= n;
            return v1;
        }
        public override string ToString()
        {
            return $"Vector: X={X},Y={Y}";
        }
    }
}
