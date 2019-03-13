using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04_01
{
    class Program
    {
        static void Main(string[] args)
        {
            CompoundShape combinedFigure = new CompoundShape(new GiometricFigure[4]);
            combinedFigure.giometricFigures[0] = new Rectangle(3, 4);
            combinedFigure.giometricFigures[1] = new Trapeze(3, 4, 1.5);
            combinedFigure.giometricFigures[2] = new Ellipse(2, 5);
            combinedFigure.giometricFigures[3] = new Parallelogram(7, 2.4);
            Console.WriteLine(combinedFigure.CompoundSapeArea());
        }
    }
}
