using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task07
{
	class Program
	{
		static void Main(string[] args)
		{
			
			try
			{
				Money m = new Money(6,50);
                Money m1 = new Money(5, 150);
				
				Money m2 = new Money(0,0);
				m2 = m1 + m;
				Console.WriteLine(m2);
				//Console.WriteLine(--m);
			}
			catch(Bankrupt ex)
			{
				Console.WriteLine(ex.Message);
			}
			catch (ArgumentOutOfRangeException ex)
			{
				Console.WriteLine(ex.Message);
			}
			catch(Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
	}
}
