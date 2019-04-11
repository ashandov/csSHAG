using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson08
{
	public delegate T AddDelegate<T>(T x, T y);
	public class ExampleClass
	{
		public int AddInt(int x,int y)
		{
			return x + y;
		}
		public double AddDouble(double x, double y)
		{
			return x + y;
		}

		public static char AddChar(char x, char y)
		{
			return (char)(x + y);
		}
	}
}
