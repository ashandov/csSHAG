using System;
namespace Lesson05.Properties.CastingOperatorReloading
{

    abstract class Figure
    {
        public abstract void Draw();
    }

    abstract class Quadrangle : Figure { }
    class Square : Quadrangle
    {
        public int Lenght { get; set; }
        public static explicit operator Square(Rectangle rec)
        {
            return new Square { Lenght = rec.Height };
        }
        public static explicit operator int(Square sq)
        {
            return sq.Lenght;
        }

        public static implicit operator Square(int val)
        {
            return new Square { Lenght = val };
        }
        public override string ToString()
        {
            return $"Square: Lenght={Lenght}";
        }
        public override void Draw()
        {
            for (int i = 0; i < Lenght; i++, Console.WriteLine())
            {
                for (int j = 0; j < Lenght; j++)
                { Console.Write("*"); }
            }

            Console.WriteLine();
        }
    }
    class Rectangle : Quadrangle
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public static implicit operator Rectangle(Square square)
        {
            return new Rectangle { Width = square.Lenght * 2, Height = square.Lenght };
        }
        public override void Draw()
        {

            for (int i = 0; i < Height; i++, Console.WriteLine())
            {
                for (int j = 0; j < Width; j++)
                { Console.Write("*"); }
            }

            Console.WriteLine();
        }
        public override string ToString()
        {
            return $"Rectangle: Width:{Width},Height:{Height}";
        }
    }
}



