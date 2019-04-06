using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task06_01
{
    public class Parallelogram : GiometricFigure, ISimpleNAngleFigure
    {
        private double _sideA;
        private double _sideB;
        private double _height;
        private double _diagonal1;
        private double _angle;
        private double _base;
        public Parallelogram(double sideA, double sideB, double h, double d1, int ang)
        {
            SideA = sideA;
            SideB = sideB;
            Height = h;
            _base = SideA;
            Diagonal1 = d1;
            AngleBetweenSides = ang;
        }
        public Parallelogram(double d1, double d2, int ang) : this(0, 0, 0, d1, ang)
        {

        }
        public Parallelogram(double sideA, double h) : this(sideA, 0, h, 0, 0)
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
        public double Height
        {
            get
            {
                return _height;
            }
            set
            {
                CheckInput(value);
                _height = value;
            }

        }
        public double Diagonal1
        {
            get
            {
                return _diagonal1;
            }
            set
            {
                CheckInput(value);
                _diagonal1 = value;
            }

        }

        public double AngleBetweenSides
        {
            get
            {
                return _angle;
            }
            set
            {
                CheckInput(value);
                _angle = value;
            }
        }

        public double SidesLenght
        {
            get
            {
                return FigurePerimetr;
            }
        }

        public double Base
        {
            get
            {
                return _base;
            }
        }
        public int SidesCount
        {
            get
            {
                return 4;
            }
        }


        public override double FigureArea
        {
            get
            {
                if (Height != 0)
                {
                    return SideA * Height;
                }
                else if (Diagonal1 != 0 && AngleBetweenSides != 0)
                {
                    return (Diagonal1 * Diagonal1 * Math.Sin(AngleBetweenSides)) / 2;
                }
                else
                {
                    return SideA * SideB * Math.Sin(AngleBetweenSides);
                }

            }
        }


        public override double FigurePerimetr
        {
            get
            {
                return 2 * (SideA + SideB);
            }

        }

        public override void CheckInput(double value)
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Input value can't be negative");
            }
        }
        public void DrawBySideA(int i)
        {
            Console.Write("   ");
            for (int j = 0; j < i; j++)
            {
                Console.Write(" ");
            }

        }
        public void DrawBySideB()
        {
            for (int k = 0; k < SideB; k++)
            {
                Console.Write("   *   ");
            }

        }
        public void Draw()
        {
            for (int i = 0; i < SideA; i++)
            {
                if (i == 0)
                {
                    DrawBySideB();
                }
                Console.WriteLine();
                DrawBySideA(i);

                Console.Write("*");
                for (int k = 0; k < SideB; k++)
                {
                    Console.Write("      ");
                }
                Console.Write("*");
                Console.WriteLine();

                if (i == (int)(SideA - 1))
                {
                    DrawBySideA(i);
                    DrawBySideB();
                }
            }
        }

    }
}
