using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04_01
{
    public class CompoundShape
    {
        public GiometricFigure[] giometricFigures;
        public CompoundShape(params GiometricFigure[] figures)
        {
            giometricFigures = figures;
        }
        public virtual double CompoundSapeArea()
        {
            double square = 0;
            foreach (GiometricFigure figure in giometricFigures)
            {
                if (figure != null)
                {
                    square += figure.FigureArea();
                }
            }
            return square;
        }

    }
}
