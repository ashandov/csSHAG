using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04_01
{
	public class Rectangle : GiometricFigure
	{
		public double b;
		public Rectangle(double sideaA, double sideB):base(sideaA)
		{
			b = sideB;
		}

		public override double FigureArea()
		{
			return a * b;
		}

		public override double FigurePerimetr()
		{
			return 2*(a + b);
		}
	}
}
