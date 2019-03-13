using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
	class Program
	{
		static void TryParse(ref int x)
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
				TryParse(ref x);
			}
		}
		

		static void Main(string[] args)
		{
			int n = 0, m = 0, o = -1, p = -1;
			Console.WriteLine("Enter number of the rows in the array:");
			TryParse( ref m);
			Console.WriteLine("Enter number of the columns in the array:");
			TryParse( ref n);
			Random r = new Random();

			if (n >= 0 && m >= 0)
			{
				int[,] ar = new int[m, n];
				for (int i = 0; i <= m - 1; i++)
				{
					for (int j = 0; j <= n - 1; j++)
					{
						ar[i, j] = r.Next(-5, 23);
						Console.Write(ar[i, j] + " ");
					}
					Console.WriteLine();
				}
				Console.WriteLine("Enter the first number of the column which u would like to swap");
				TryParse(ref o);
				o -= 1;
				Console.WriteLine("Enter the second number of the column which u would like to swap");
				TryParse( ref p);
				p -= 1;
				if (o <= n && o >= 0 && p <= n && p >= 0)
				{
					if (!(o == p))
					{
						int[] array = new int[m + 1];
						for (int i = 0; i <= m - 1; i++)
						{
							array[i] = ar[i, o];
							ar[i, o] = ar[i, p];
							ar[i, p] = array[i];
						}
					}
					for (int i = 0; i <= m - 1; i++)
					{
						for (int j = 0; j <= n - 1; j++)
						{
							Console.Write(ar[i, j] + " ");
						}
						Console.WriteLine();
					}
				}
				else
				{
					Console.WriteLine("Numbers of the columns to swap are incorrect");
				}

			}
			else
			{
				Console.WriteLine("Each of the dimension of the array couldn't be less than 1");
			}



		}
	}


}
