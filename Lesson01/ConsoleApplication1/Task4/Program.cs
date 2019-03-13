using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            Console.WriteLine("Enter natural even number:");
            if (!Int32.TryParse(Console.ReadLine(), out N))
            {
                Console.WriteLine("Incorrect value was intputted.");
            } 
            if (N > 0)
            {
                while (N % 10 != 0) 
                {
                    Console.Write(N%10);
                    N /= 10;
                }
            }
            else
            {
                Console.WriteLine("Argument should be greater than 0");
            }
            Console.WriteLine();
        }
    }
}
