using System;
namespace Lesson05.Properties
{
    public class Point
    {
        public Point()
        {
        }
        public int X { get; set; }
        public int Y { get; set; }
        public override bool Equals(object obj)
        {
            return this.ToString() == obj.ToString();
        }
        public override string ToString()
        {
            return $"Point: X={X}, Y={Y}";
        }
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        public static bool operator ==(Point p1, Point p2)
        {
            return p1.Equals(p2);
        }
        public static bool operator !=(Point p1, Point p2)
        {
            return !(p1 == p2);
        }
        public static bool operator >(Point p1, Point p2)
        {
            return Math.Sqrt(p1.X * p1.X + p1.Y * p1.Y) > Math.Sqrt(p2.X * p2.X + p2.Y * p2.Y);
        }
        public static bool operator <(Point p1, Point p2)
        {
            return Math.Sqrt(p1.X * p1.X + p1.Y * p1.Y) < Math.Sqrt(p2.X * p2.X + p2.Y * p2.Y);
        }

    }
}
