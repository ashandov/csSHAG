using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04_01
{
    public class Rhombus : GiometricFigure
    {
        public double b;
        public double height;
        public double diagonal1;
        public double diagonal2;
        public Rhombus(double sideA, double sideB, double h, double d1, double d2) : base(sideA)
        {
            b = sideB;
            height = h;
            diagonal1 = d1;
            diagonal2 = d2;
        }
        public Rhombus(double sideA, double h) : this(sideA, 0, h, 0, 0)
        { }



        public override double FigureArea()
        {

            if (height != 0)
            {
                return (a * height) / 2;
            }
            else
            {
                return (diagonal1 * diagonal2) / 2;
            }
        }

        public override double FigurePerimetr()
        {
            return 4 * a;
        }
    }
}
