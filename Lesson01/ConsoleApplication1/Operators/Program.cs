using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x = 9; int y = 4;
            //Console.WriteLine(x- ++y);
            //Console.WriteLine(y);
            //Console.WriteLine();
            //Console.WriteLine(x - y--);
            //Console.WriteLine(y);

            //logic
            //bool FirstOperand = false, SecondOperand = false;
            //Console.WriteLine(FirstOperand && SecondOperand);
            //SecondOperand = true;
            //Console.WriteLine(FirstOperand & SecondOperand);
            //FirstOperand = true;
            //Console.WriteLine(FirstOperand & SecondOperand);

            //int a = 0;
            //Console.WriteLine(2 > 7 && 5 != 8);
            //Console.WriteLine(2!=4 && 2!=5);
            //Console.WriteLine(8<10 && 8<20);
            //Console.WriteLine(false==true);
            //Console.WriteLine("---------------------------------");
            //Console.WriteLine(2>7 && 2/a!=5);

            ////bit operators
            //int a1 = 10;
            //int b = 1;
            //int result = a1 >> b;//division of the first operand a1 on 2 in pow, wich is equal by second operand b
            //Console.WriteLine(result);
            //result = a1 << b;//multiplication of the first operand a1 on 2 in pow, wich is equal by second operand b
            //Console.WriteLine(result);

            //priority 
            int a = 10; int b = 1;
            int result = a + b * 2;
            Console.WriteLine(result);
            result = (a + b) * 2;
            Console.WriteLine(result); //22
            result = a + b - 4 * -2;
            Console.WriteLine(result); //19
            result = (a + (b - 4)) * -2;
            Console.WriteLine(result); //-14

        }
    }
}
