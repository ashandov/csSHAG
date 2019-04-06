using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task06_01
{
    public class Triangle : GiometricFigure, ISimpleNAngleFigure
    {
        private double _sideA;
        private double _sideB;
        private double _sideC;
        private double _height;
        private double _diagonal1;
        private double _diagonal2;
        private double _angle;
        private double _base;
        public Triangle(double sideA, double sideB, double sideC, double h, double ang)
        {
            if (sideA < sideB && sideB > sideC)
            {
                _base = SideB;
            }
            else if (sideA > sideC && sideA > sideB)
            {
                _base = SideA;
            }
            else
            {
                _base = SideC;
            }
            Diagonal1 = 0;
            Diagonal2 = 0;

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
            Height = h;
            AngleBetweenSides = ang;
            CheckSidesValidation(sideA, SideB, SideC);

        }


        public Triangle(double sideA, double sideB, double sideC) : this(sideA, sideB, sideC, 0, 0)
        {
            CheckSidesValidation(sideA, SideB, SideC);
        }

        public Triangle(double sideB, double heinght) : this(0, sideB, 0, heinght, 0)
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
                Console.WriteLine("Triangle can't have a diagonal");
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
                Console.WriteLine("Triangle can't have a diagonal");
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
                if (Height != 0)
                {
                    return ((1 / 2) * (SideA * Height));
                }
                else if (AngleBetweenSides != 0)
                {
                    if (AngleBetweenSides == 90)
                    {
                        return ((1 / 2) * (SideA * SideB));
                    }
                    else
                    {
                        return ((1 / 2) * ((SideA * SideB * Math.Sin(AngleBetweenSides))));
                    }
                }
                else
                {
                    return SideA * SideB * SideC;
                }
            }
        }


        public override double FigurePerimetr
        {
            get
            {

                return SideA + SideB + SideC;
            }

        }

        public override void CheckInput(double value)
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Input value can't be negative");
            }
        }
        public void CheckSidesValidation(double side1, double side2, double side3)
        {
            if (side1 + side2 < side3)
            {
                throw new ArgumentOutOfRangeException("Input value can't be negative");
            }
            if (side2 + side3 < side1)
            {
                throw new ArgumentOutOfRangeException("Input value can't be negative");
            }
            if (side1 + side3 < side2)
            {
                throw new ArgumentOutOfRangeException("Input value can't be negative");
            }
        }
        public void Draw()
        {
            for (int i = 0; i < SideA; i++)
            {

                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
            }
        }



    }
}
