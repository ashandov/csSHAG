using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04_01
{
	public abstract class GiometricFigure
	{
		public double a;

		public GiometricFigure(double sideA)
		{
			a = sideA;
		}
		
		public abstract double FigureArea();
		public abstract double FigurePerimetr();

	}
}
