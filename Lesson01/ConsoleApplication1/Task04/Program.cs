using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal d = 10000;
            decimal r; 
            if(!Decimal.TryParse(Console.ReadLine(), out r))
            {
                Console.WriteLine("Only decimal value could be inputted");
            }
            if (r <=25 && r > 0)
            {
                int k = 0;
                do
                {
                    d += d * r / 100;
                    k++;
                }
                while (d <= 11000);
                Console.WriteLine("After {0} month amount of the deposit will exceed 1100."+Environment.NewLine+"Amount of the deposit will make up {1} dollars."+Environment.NewLine,k.ToString(),d);   
            }
            else
            {
                Console.WriteLine("Value of the r argument should be less then 25 and greater then 0");
            }
             
        }
    }
}
