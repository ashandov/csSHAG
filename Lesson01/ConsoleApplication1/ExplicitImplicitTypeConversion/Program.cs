using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitImplicitTypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            float y = 6.5F;
            float b = x + y;
            float x1 = 6.5F;
            int y1 = 4;
            int A = y1 + (int)x1;
            int w = (int)y;

            Console.WriteLine("Enter some number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entered value is:{0}", n);

            Console.WriteLine("Enter some number: ");
            int n1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Entered value is:{0}", n1);

           


        }
    }
}
