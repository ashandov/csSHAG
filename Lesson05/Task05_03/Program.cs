using System;
using Task_05_03;

namespace Task05_03
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Complex z = new Complex(1, 1);
            Complex z2 = new Complex(1, 1);
            if (z2 == z)
            {
                Console.WriteLine("True");
            }
            Complex z1;
            z1 = z - (z * z * z - 1) / (3 * z * z);
            Console.WriteLine("z1 = {0}", z1);
        }
    }
}
