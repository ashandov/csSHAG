using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task05_04
{
    class Fraction
    {
        public double numerator;
        public double denomerator;

        public Fraction(double a, double b)
        {
            numerator = a;
            denomerator = b;
        }
        public Fraction()
        {

        }
        public override string ToString()
        {
            return $"{numerator}/{denomerator}";
        }

        public override bool Equals(object obj)
        {
            return this.ToString() == obj.ToString();
        }
        public static Fraction operator +(Fraction fraction, int number)
        {
            return new Fraction { numerator = (fraction.denomerator * number) + fraction.numerator };
        }
        public static Fraction operator +(Fraction fraction, double number)
        {

            string snumber = number.ToString();
            int index = snumber.IndexOf('.');
            string whole = snumber.Substring(0, index);
            string fractional = snumber.Substring(index + 1, snumber.Length - 1 - index);
            return new Fraction
            {
                numerator = ((Convert.ToInt32(whole))
            * Math.Pow(10, fractional.Length) + Convert.ToInt32(fractional)),
                denomerator = Math.Pow(10, fractional.Length)
            };
        }
        public static Fraction operator -(Fraction fraction, int number)
        {
            return new Fraction { numerator = -(fraction.denomerator - number) + ((number - 1) * fraction.denomerator) };
        }

        public static Fraction operator *(Fraction fraction, int number)
        {
            return new Fraction { numerator = fraction.numerator * number, denomerator = fraction.denomerator };
        }
        public static Fraction operator *(int number, Fraction fraction)
        {
            return new Fraction { numerator = fraction.numerator * number, denomerator = fraction.denomerator };
        }
        public static Fraction operator /(int number, Fraction fraction)
        {
            return new Fraction { denomerator = fraction.denomerator * number, numerator = fraction.numerator };
        }
        public static bool operator true(Fraction fraction)
        {
            return fraction.numerator < fraction.denomerator ? true : false;
        }
        public static bool operator false(Fraction fraction)
        {
            return fraction.numerator > fraction.denomerator ? true : false;
        }
        public static bool operator ==(Fraction fraction1, Fraction fraction2)
        {
            return fraction1.Equals(fraction2);
        }
        public static bool operator !=(Fraction fraction1, Fraction fraction2)
        {
            return (!(fraction1.Equals(fraction2)));
        }
        public static bool operator >(Fraction fraction1, Fraction fraction2)
        {
            if (fraction1.numerator / fraction1.denomerator > fraction2.numerator / fraction2.denomerator)
            {
                return true;
            }
            else { return false; }
        }
        public static bool operator <(Fraction fraction1, Fraction fraction2)
        {
            if (fraction1.numerator / fraction1.denomerator < fraction2.numerator / fraction2.denomerator)
            {
                return true;
            }
            else { return false; }
        }

    }
}
