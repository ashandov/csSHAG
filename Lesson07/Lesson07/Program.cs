using System;
using Lesson07.Properties;

namespace Lesson07
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers:");
            int number, number2, result = 0;

            try
            {
                number = int.Parse("re");
                number2 = int.Parse("323");
                result = number2 / number;
                Console.WriteLine($"Result of division: {result}");

            }
            //should be the last of all catch blocks
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (MyException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Resorce cleaning");
            }
        }
    }
}