using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task05_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction f = new Fraction(3, 4);
            int a = 10;
            Fraction f1 = f * a;
            Console.WriteLine(f1);
            Fraction f2 = a * f;
            Console.WriteLine(f2);
            Console.WriteLine(f1 == f2);
            double d = 1.5;
            Fraction f3 = f + d;
            Console.WriteLine(f3);
        }
    }
}
