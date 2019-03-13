using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04_01
{
	public class Round : GiometricFigure
	{
		public double diameter;
		public Round(double radius):base(radius)
		{
			diameter = 2 * radius;
		}
		public override double FigureArea()
		{
			return 2 * (Math.PI * (a * a));
		}

		public override double FigurePerimetr()
		{
			return 2 * Math.PI * a;
		}
	}
}
