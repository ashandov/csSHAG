using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    class Program
    {
        static int A, B;
        static void IntParsing(string s, ref int r)
        {
            if (!Int32.TryParse(s, out r))
            {
                Console.WriteLine("Incorrect value was intputted for the argument.");
            }
        }
        static void Main(string[] args)
        {
            string argVal;
            Console.WriteLine("Enter two natural even number:");
            argVal = Console.ReadLine();
            IntParsing(argVal, ref A);
            argVal = Console.ReadLine();
            IntParsing(argVal, ref B);
         

            if (A < B && A>0)
            {
                for (int i = A; i < B + 1; i++)
                {
                    for (int j = 0; j <= i - 1; j++)
                    {
                        Console.Write(i+" ");
                    }
                    Console.WriteLine(Environment.NewLine);
                }
            }
            else
            {
                Console.WriteLine("Arguments should be greater than 0");
            }
        }
    }
}
