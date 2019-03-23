using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_05_03
{
	public class Complex
	{
		int a, b;
		public Complex(int a, int b)
		{
			this.a = a;
			this.b = b;
		}
		public Complex()
		{ }
		public override string ToString()
		{
			return $"{a}+{b}i";
		}
		public override bool Equals(object obj)
		{
			return this.ToString() == obj.ToString();
		}
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}
		public static bool operator ==(Complex complex1, Complex complex2)
		{
			return complex1.Equals(complex2);
		}
		public static bool operator !=(Complex complex1, Complex complex2)
		{
			return (!complex1.Equals(complex2));
		}
		public static Complex operator +(Complex complex,int number)
		{
			return new Complex { a = complex.a + number, b = complex.b + number };
		}
		public static Complex operator -(Complex complex, int number)
		{
			return new Complex { a = complex.a - number, b = complex.b - number };
		}
		public static Complex operator *(int number, Complex complex)
		{
			return new Complex { a = complex.a*number, b = complex.b* number };
		}
		public static Complex operator +(Complex complex1, Complex complex2)
		{
			return new Complex { a = complex1.a + complex2.a, b = complex1.b + complex2.b };
		}
		public static Complex operator -(Complex complex1, Complex complex2)
		{
			return new Complex { a = complex1.a - complex2.a, b = complex1.b - complex2.b };
		}
		public static Complex operator *(Complex complex1, Complex complex2)
		{
			return new Complex { a = (complex1.a * complex2.a) - (complex1.b * complex2.b), b = (complex1.b * complex2.a) + (complex1.a * complex2.b) };
		}
		public static Complex operator /(Complex complex1, Complex complex2)
		{
			return new Complex
			{
				a = (((complex1.a * complex2.a) - (complex1.b * complex2.b)) / (complex2.a * complex2.a + complex2.b * complex2.b)),
				b = (((complex1.b * complex2.a) - (complex1.a * complex2.b)) / (complex2.a * complex2.a + complex2.b * complex2.b))
			};
		}
	}
}
