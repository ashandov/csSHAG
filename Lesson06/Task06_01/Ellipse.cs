using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task06_01
{
    public class Ellipse : GiometricFigure
    {
        private double _sideA;
        private double _sideB;
        public Ellipse(double sideA, double sideB)
        {

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
		public override double FigureArea
        {
            get
            {
                return Math.PI * SideA * SideB;
            }
        }
		



		public override double FigurePerimetr
        {
            get
            {
                return 4 * ((Math.PI * SideA * SideB - (SideA - SideB)) / (SideA + SideB));
            }
        }

		public override void CheckInput(double value)
		{
			if (value < 0)
			{
				throw new IndexOutOfRangeException("Inputed value can't be negative");
			}
		}
	}
}
