using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04_01
{
    public class Ellipse : GiometricFigure
    {
        public double b;
        public Ellipse(double sideA, double sideB) : base(sideA)
        {
            b = sideB;
        }
        public override double FigureArea()
        {
            return Math.PI * a * b;
        }

        public override double FigurePerimetr()
        {
            return 4 * ((Math.PI * a * b - (a - b)) / (a + b));
        }
    }
}
