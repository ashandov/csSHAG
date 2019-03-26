using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task06_01
{
    public abstract class GiometricFigure
    {

        public virtual double FigureArea
        {
            get;
        }
        public virtual double FigurePerimetr
        {
            get;
        }
        public abstract void CheckInput(double value);

    }
}