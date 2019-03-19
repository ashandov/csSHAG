using System;

namespace Task05
{
    public struct Coefficient
    {
        public int a, b;
        public string str;
    }


    class MainClass
    {
        public static void Main(string[] args)
        {
            Coefficient coef = new Coefficient();
            Parse("32,323", ref coef.a, ref coef.b);
            Console.WriteLine(coef.a);
            Console.WriteLine(coef.b);
        }
        public static void Parse(string s, ref int a, ref int b)
        {
            if (String.IsNullOrEmpty(s))
            {
                ThrowException();
            }
            int spaceIndex = s.IndexOf(' ');
            if (CheckIndexValue(spaceIndex))
            {
                spaceIndex = s.IndexOf(',');
            }
            if (CheckIndexValue(spaceIndex))
            {
                ThrowException();
            }
            string aValue = String.Empty;
            string bValue = string.Empty;
            aValue = s.Substring(0, spaceIndex);
            bValue = s.Substring(spaceIndex + 1, s.Length - 1 - spaceIndex);
            IntParse(aValue, ref a);
            IntParse(bValue, ref b);

        }
        private static void ThrowException()
        {
            throw new ArgumentOutOfRangeException("Ivalid parametr");
        }

        private static void IntParse(string s, ref int val)
        {
            if (!(Int32.TryParse(s, out val)))
            {
                ThrowException();
            }
        }
        private static bool CheckIndexValue(int index)
        {
            if (index == -1)
            {
                return true;
            }
            else { return false; }
        }
    }
}



