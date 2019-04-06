using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task06_01
{
    public class Trapeze : GiometricFigure, ISimpleNAngleFigure
    {

        private double _sideA;
        private double _sideB;
        private double _sideC;
        private double _sideD;
        private double _height;
        private double _diagonal1;
        private double _diagonal2;
        private double _angle;
        private double _base;
        public Trapeze(double sideA, double sideB, double sideC, double h, double d1, double d2, int ang)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
            Height = h;
            if (SideA < SideB)
            {
                _base = SideB;
            }
            else
            {
                _base = SideA;
            }
            Diagonal1 = d1;
            Diagonal2 = d2;
            AngleBetweenSides = ang;
        }
        public Trapeze(double sideA, double sideB, double sideC, double sideD) : this(sideA, sideB, sideC, sideD, 0, 0, 0)
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

        public double SideC
        {
            get
            {
                return _sideC;
            }
            set
            {
                CheckInput(value);
                _sideC = value;
            }

        }
        public double SideD
        {
            get
            {
                return _sideD;
            }
            set
            {
                CheckInput(value);
                _sideD = value;
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
        public double Diagonal2
        {
            get
            {
                return _diagonal2;
            }
            set
            {
                CheckInput(value);
                _diagonal2 = value;
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
                return ((SideA + SideB) / 2) * SideC;
            }
        }

        public override double FigurePerimetr
        {
            get
            {
                return SideA + SideB + SideC + SideD;
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
            for (int j = (int)SideA; j > i; j--)
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
                    Console.WriteLine();
                }

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

