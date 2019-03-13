using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04_01
{
	public class Square : GiometricFigure
	{
		public Square(double sideA) :base(sideA)
		{

		}

		public override double FigureArea()
		{
			return Math.Pow(a, 2);
		}

		public override double FigurePerimetr()
		{
			return 4*a;
		}
	}
}
