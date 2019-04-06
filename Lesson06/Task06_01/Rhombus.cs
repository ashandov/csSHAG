using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task06_01
{
    public class Rhombus : GiometricFigure, ISimpleNAngleFigure
    {

        private double _sideA;
        private double _height;
        private double _diagonal1;
        private double _diagonal2;
        private double _angle;
        private double _base;
        public Rhombus(double sideA, double h, double d1, double d2)
        {
            SideA = sideA;
            Height = h;
            _base = sideA;
            Diagonal1 = d1;
            Diagonal2 = d2;
        }
        public Rhombus(double sideA, double h) : this(sideA, 0, h, 0)
        { }

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
                if (Height != 0)
                {
                    return (SideA * Height) / 2;
                }
                else
                {

                    return (Diagonal1 * Diagonal2) / 2;
                }
            }
        }


        public override double FigurePerimetr
        {
            get
            {
                return 4 * SideA;
            }

        }

        public override void CheckInput(double value)
        {
            if (value < 0)
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
                    Console.Write("");
                }
                Console.WriteLine("*");
            }
        }
    }
}
