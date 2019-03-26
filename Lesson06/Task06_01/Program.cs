using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task06_01
{
    class Program
    {
        static void Main(string[] args)
        {
            CompoundShape combinedFigure = new CompoundShape(new ISimpleNAngleFigure[5]);
            combinedFigure[0] = new Rectangle(2.5,3.6,1.5);
            combinedFigure[1] = new Trapeze(3, 4, 1.5,6);
            //combinedFigure[2] = new Ellipse(2, 5);
            combinedFigure[3] = new Parallelogram(7, 2.4);
			combinedFigure[4] = new Triangle(5,7,9);
			Console.WriteLine(combinedFigure.CompoundSapeArea());
        }
    }
}
