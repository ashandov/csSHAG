using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task06_01
{
    public class CompoundShape
    {
        public ISimpleNAngleFigure[] giometricFigures;
        public CompoundShape(params ISimpleNAngleFigure[] figures)
        {
            giometricFigures = figures;
        }
        public virtual double CompoundSapeArea()
        {
            double square = 0;
            foreach (ISimpleNAngleFigure figure in giometricFigures)
            {
                if (figure != null)
                {
                    square += figure.FigureArea;
                }
            }
            return square;
        }
        public ISimpleNAngleFigure this[int index]
        {
            get
            {
                return giometricFigures[index];
            }
            set
            {
                giometricFigures[index] = value;
            }

        }
    }
}
