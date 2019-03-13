using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            int f = 1;
            //impossible to use numeric values as conditions, only bool values should be used
            //if (f)
            //{
            //    Console.WriteLine(f);
            //}
            //if (f > 0)
            //{
            //    Console.WriteLine(f);//1
            //}
            //else
            //{
            //    Console.WriteLine("Test");
            //}

            //int MAX = 10;
            //Console.Write("Guess number from 1 to {0}\n", MAX);
            //int userNumber = Convert.ToInt32(Console.ReadLine());
            //Random r = new Random();
            //double PcNumber = Math.Round(r.NextDouble() * MAX);
            //Console.WriteLine("Right number is {0}, and u've specified {1}.\n",PcNumber,userNumber);
            //if (PcNumber == userNumber)
            //{
            //    Console.WriteLine("Congratulations");
            //}

            int num = 1, price;
            switch (num)
            {
                case 1:
                case 2://if case is empty, compiler go to the next case until he meet case with some expression or default case
                case 3:
                case 4: price = 25;
                    break;//conditions must provide with "break" or "return" either compiler will return an error of compiling 
                case 5:
                case 6:
                case 7:
                case 8:
                    price = 23;
                    break;
                default: price = 0;
                    break;
            }
            Console.WriteLine(price);
            
            //ternaty operator
            int myInt = 0;
            int anotherInt = myInt != 0 ? 1 : 1234;
            Console.WriteLine(anotherInt.ToString());

        }
    }
}
