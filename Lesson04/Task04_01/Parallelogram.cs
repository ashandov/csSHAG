using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04_01
{
	public class Parallelogram : GiometricFigure
	{
		public double b;
		public double height;
		public double diagonal1;
		public double diagonal2;
		public int angle;
		public Parallelogram(double sideA,double sideB,double h,double d1,double d2,int ang):base(sideA)
		{
			b = sideB;
			height = h;
			diagonal1 = d1;
			diagonal2 = d2;
			angle = ang;
		}
		public Parallelogram(double d1, double d2, int ang) : this(0, 0, 0, d1, d2, ang)
		{

		}
		public Parallelogram(double sideA, double h) : this(sideA, 0, h, 0, 0, 0)
		{

		}
		
		public override double FigureArea()
		{
			if (height != 0)
			{
				return a * height;
			}
			else if (diagonal1 != 0 && diagonal2 != 0 && angle != 0)
			{
				return (diagonal2 * diagonal1 * Math.Sin(angle)) / 2;
			}
			else
			{
				return a * b * Math.Sin(angle);
			}
			
		}

		public override double FigurePerimetr()
		{
			return 2*(a + b);
		}
	}
}
