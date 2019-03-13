using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
     class Program
    {
        static void Main(string[] args)
        {
            //digit
            Decimal devined = decimal.One;
            Console.WriteLine(devined);
            decimal devisor = 3;
            devined = devined / devisor;
            Console.WriteLine(devined);
            Console.WriteLine(Math.Round(devined * devisor));

            double doubleDevined = 1;
            Console.WriteLine(doubleDevined);
            System.Double doubleDevisor = 3;
            doubleDevined = doubleDevined / doubleDevisor;
            Console.WriteLine(doubleDevined);
            Console.WriteLine(doubleDevined * doubleDevisor);

            //symbol

            Console.WriteLine(Char.IsControl('\t'));
            Console.WriteLine(Char.IsControl('5'));

            Console.WriteLine(Char.IsDigit('t'));
            Console.WriteLine(Char.IsDigit('5'));

            Console.WriteLine(Char.IsLetter('t'));
            Console.WriteLine(Char.IsLetter('3'));

            Console.WriteLine(Char.IsLower('t'));

            Console.WriteLine(Char.IsUpper('F'));

            Console.WriteLine(Char.IsNumber('4'));

            Console.WriteLine(Char.IsSeparator('.'));

            Console.WriteLine(Char.IsSymbol('>'));

            Console.WriteLine(Char.IsWhiteSpace(' '));

            Console.WriteLine(Char.ToUpper('t'));

            Console.WriteLine(Char.ToLower('F'));

            //nullable
            //double d = null;
            string s = null;

            int? intnull = null;
            intnull = 20;
            bool? flag = true;
            flag = null;

            Nullable<int> nullint = null;
            nullint = nullint ?? 54;
            Console.WriteLine(Environment.NewLine + nullint);
            Nullable<bool> fl = null;
            bool b = fl ?? true;
            Console.WriteLine(Environment.NewLine + b);
            fl = true;

            //literals 
            Console.WriteLine((10d).GetType());
            Console.WriteLine(Environment.NewLine + (10F).GetType());
            Console.WriteLine(Environment.NewLine + (10m).GetType());
            Console.WriteLine(Environment.NewLine + (10).GetType());
            Console.WriteLine(Environment.NewLine + (10L).GetType());
            Console.WriteLine(Environment.NewLine + (10UL).GetType());
            Console.WriteLine(Environment.NewLine + (0xFF));
            Console.WriteLine(Environment.NewLine);

            //string literals
            Console.WriteLine(@"I love eat hotdogs \n n pizzas");
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("I love eat hotdogs \n n pizzas");
        }
    }
}
