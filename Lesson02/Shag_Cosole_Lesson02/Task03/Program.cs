using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    class Program
    {
		static int x=-1;
		public static void GetInt()
		{
			while ((!Int32.TryParse(Console.ReadLine(), out x)))
			{		
				Console.WriteLine("Incorrect value, try again.");
				Console.WriteLine("Enter any value from 0 to 5");
			}
			if (x < 0)
			{
				Console.WriteLine("Incorrect value, try again.");
				Console.WriteLine("Enter any value from 0 to 5");
				GetInt();
			}
		}
        static void Main(string[] args)
        {
            int[] ar = new int[8];							   
            Random r = new Random();
            for (int i = 0; i < ar.Length - 1; i++)
            {
                ar[i] = r.Next(0,5);
            }
            Console.WriteLine("Enter any value from 0 to 5");
			int c = -1;
			int l = 0;
			
            GetInt();
            Console.WriteLine();
            Console.WriteLine("Initial array:");
            for (int i = 0; i < ar.Length - 1; i++)
            {
                if (ar[i] == x)
                {
                    c++;
                }
                Console.Write(ar[i]+" ");
            }
            Console.WriteLine();
            if (c == 0)
            {
                Console.WriteLine("Entered value doesn't meet in current array");
            }
            else
            {
                Console.WriteLine("Entered value has met {0} time(s) in the array",c+1);
            }
            
        }
    }
}
