using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task06_01
{
    public class Round : GiometricFigure
    {
        private double _radius;
        private double _diameter;
        public Round(double radius)
        {
            _diameter = 2 * radius;
        }
        public double Radius
        {
            get
            {
                return _radius;
            }
            set
            {
                _radius = value;
            }
        }
        public double Diametr
        {
            get
            {
                return _diameter;
            }

        }
        public override double FigureArea
        {
            get
            {
                return 2 * (Math.PI * (Radius * Radius));

            }
        }
        public override double FigurePerimetr
        {
            get
            {
                return 2 * Math.PI * Radius;
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
