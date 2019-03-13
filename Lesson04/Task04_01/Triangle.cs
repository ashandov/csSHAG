using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04_01
{
	public class Triangle : GiometricFigure
	{
		public double b;
		public double c;
		public double hightness;
		public int angle;
		public Triangle(double sideaA ,double sideB,double sideC,double h,int ang) :base(sideaA)
		{
			b = sideB;
			c = sideC;
			hightness = h;
			angle = ang;
		}
		public Triangle(double sideaA, double sideB, double sideC):this(sideaA,sideB,sideC,0,0)
		{

		}
		public Triangle(double sideaB,double h) : this(0, sideaB,0,h,0)
		{
			
		}
		public Triangle(double sideaA,  int angle) : this(sideaA, 0, 0,0, angle)
		{

		}



		public override double FigureArea()
		{
			if(hightness != 0)
			{
				return ((1 / 2) * (a * hightness));
			}
			else if (angle != 0)
			{
				if (angle == 90)
				{
					return ((1 / 2) * (a * b));
				}
				else
				{
					return ((1 / 2) * (a * b*Math.Sin(angle)));
				}
			}
			else
			{
				return a * b * c;
			}
				
		}

		public override double FigurePerimetr()
		{
			return a + b + c;
		}
	}
}
