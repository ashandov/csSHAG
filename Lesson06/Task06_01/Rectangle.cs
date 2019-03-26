using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task06_01
{
    public class Rectangle : GiometricFigure,ISimpleNAngleFigure
    {

		private double _sideA;
		private double _sideB;
		private double _height;
		private double _diagonal1;
		private double _angle;
		private double _base;
		public Rectangle(double sideaA, double sideB,double diag1)
        {
			SideA = sideaA;
			SideB = sideB;
			Diagonal1 = diag1;
			_angle = 90;
			if (sideaA < sideB)
			{
				_base = SideB;
			}
			else
			{
				_base = SideA;
			}

        }
		public double SideA
		{
			get
			{
				return _sideA;
			}
			set
			{
				CheckInput(value);
				_sideA = value;
			}

		}
		public double SideB
		{
			get
			{
				return _sideB;
			}
			set
			{
				CheckInput(value);
				_sideB = value;
			}

		}
		public double Height
		{
			get
			{
				return _height;
			}
			set
			{
				CheckInput(value);
				_height = value;
			}

		}
		public double Diagonal1
		{
			get
			{
				return _diagonal1;
			}
			set
			{
				CheckInput(value);
				_diagonal1 = value;
			}

		}

		public double AngleBetweenSides
		{
			get
			{
				return _angle;
			}
			set
			{
				CheckInput(value);
				_angle = value;
			}
		}

		public double SidesLenght
		{
			get
			{
				return FigurePerimetr;
			}
		}

		public double Base
		{
			get
			{
				return _base;
			}
		}
		public int SidesCount
		{
			get
			{
				return 4;
			}
		}
		public double FigureArea
        {
            get
            {
                return SideA * SideB;
            }
        }

        public double FigurePerimetr
        {
            get
            {
                return 2 * (SideA + SideB);
            }
        }

		public override void CheckInput(double value)
		{
			if (value < 0)
			{
				throw new ArgumentOutOfRangeException("Input value can't be negative");
			}
		}
	}
}
