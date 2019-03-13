using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04_01
{
    public class Trapeze : GiometricFigure
    {
        public double b;
        public double c;
        public double d;
        public double height;
        public Trapeze(double sideA, double sideB, double sideC, double sideD, double h) : base(sideA)
        {
            b = sideB;
            c = sideC;
            d = sideD;
            height = h;
        }
        public Trapeze(double sideA, double sideB, double sideC, double sideD) : this(sideA, sideB, sideC, sideD, 0)
        { }
        public Trapeze(double sideA, double sideB, double h) : this(sideA, sideB, 0, 0, h)
        { }

        public override double FigureArea()
        {
            return ((a + b) / 2) * height;
        }

        public override double FigurePerimetr()
        {
            return a + b + c + d;
        }
    }
}
