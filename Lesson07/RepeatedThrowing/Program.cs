using System;

namespace RepeatedThrowing
{
    class MainClass
    {
        static int DevisionNumbers(int n1, int n2)
        {
            try
            {
                return n1 / n2;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return 0;
            }

        }
        public static void Main(string[] args)
        {
            int number1, number2, result = 0;
            try
            {
                number1 = int.Parse("vfds");
                number2 = int.Parse("434");
                result = DevisionNumbers(number1, number2);
                Console.WriteLine("Result of the division" + result);

            }
            catch (Exception ex)
            {
                //Console.WriteLine("Inner Exception Message:");
                //Console.WriteLine(ex.InnerException.Message);
                Console.WriteLine(ex.Message);
            }
        }
    }
}

