using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Пример использованияинструментов класса Console";
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            int lenght = ("Input Encoding: " +Console.InputEncoding.ToString()).Length + 1;
            Console.SetWindowSize(lenght, 8);
            Console.SetBufferSize(lenght, 8);
            Console.WriteLine("Input Encoding: " + Console.InputEncoding.ToString());
            Console.WriteLine("Output Encoding: " + Console.OutputEncoding.ToString());
            Console.ResetColor();
            Console.WriteLine("Is NUMLOCK turned on" + Console.NumberLock.ToString());
            Console.WriteLine("Is CAPSLOCK turned on" + Console.CapsLock.ToString());
            Console.Write("Enter a simple message.\nYour message is:"+Console.ReadLine()+Environment.NewLine);
        }
    }
}
