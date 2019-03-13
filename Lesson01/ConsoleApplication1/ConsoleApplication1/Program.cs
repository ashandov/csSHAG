using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            if(name=="")
                Console.WriteLine("Hello world");
            else
            {
                Console.WriteLine("Hi,{0}!",name);
            }
            Console.ReadKey();
        }
    }
}
