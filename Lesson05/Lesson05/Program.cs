using System;
using Lesson05.Properties;
using Lesson05.Properties.CastingOperatorReloading;

namespace Lesson05
{
    class Cpoint
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
    struct Spoint
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Vector vector1 = new Vector(new Point { X = 2, Y = 5 }, new Point { X = 3, Y = 8 });
            //Vector vector2 = new Vector(new Point { X = 0, Y = 7 }, new Point { X = -3, Y = 4 });
            //Console.WriteLine(vector1 + vector2);
            //Console.WriteLine(vector1 - vector2);
            //Console.WriteLine(vector1 * 2);
            //Console.WriteLine(vector1 *= 2);

            //Cpoint cp = new Cpoint { X = 10, Y = 10 };
            //Cpoint cp1 = new Cpoint { X = 10, Y = 10 };
            //Cpoint cp2 = cp1;
            //Console.WriteLine(ReferenceEquals(cp, cp1));
            //Spoint Sp = new Spoint { X = 10, Y = 10 };
            //Console.WriteLine(ReferenceEquals(Sp, Sp));
            //Console.WriteLine(Equals(cp, cp1));
            //Spoint sp1 = new Spoint { X = 10, Y = 10 };
            //Console.WriteLine(Equals(Sp, sp1));
            //Console.WriteLine("--------------------------");

            //Point p1 = new Point { X = 10, Y = 10 };
            //Point p2 = new Point { X = 20, Y = 20 };
            //Console.WriteLine(p1 == p2);
            //Console.WriteLine(p1 != p2);
            //Console.WriteLine(p1 < p2);
            //Console.WriteLine(p1 > p2);


            //Rectangle rectangle = new Rectangle { Height = 14, Width = 7 };
            //Square square = new Square { Lenght = 5 };
            //Rectangle rec = square;
            //Console.WriteLine($"Explicit cast square {square} to rectangle.\n{rec}\n");
            //rec.Draw();
            //Square sq = (Square)rectangle;
            //Console.WriteLine($"Implicit cast rectangle {rectangle} to square.\n{sq}\n");
            //sq.Draw();
            //Console.WriteLine("Enter integer value");
            //int number = Int32.Parse(Console.ReadLine());
            //Console.WriteLine($"Explicit cast integer value {number} to square.\n{sq}\n");
            //Square squareInt = number;
            //squareInt.Draw();
            //number = (int)square;
            //Console.WriteLine($"Implicit cast square value {square} to integer value.\n{number}\n");

            Shop onliner = new Shop(4);
            onliner[0] = new Laptop { Vendor = "MacBook Pro 15 2018", Price = 2750 };
            onliner[1] = new Laptop { Vendor = "Asus Zenbook 2018", Price = 1750 };
            onliner[2] = new Laptop { Vendor = "Xiomi Pro 15 2018", Price = 2250 };

            try
            {
                for (int i = 0; i < onliner.Lenght; i++)
                {
                    Console.WriteLine(onliner[i]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }



    }

}


