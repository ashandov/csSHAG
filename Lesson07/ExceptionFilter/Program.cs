using System;

namespace ExceptionFilter
{
    class MainClass
    {
        static int DivisionNumbers(int n1, int n2)
        {
            int result = 0;
            try
            {
                result = n1 / n2;
            }
            catch (DivideByZeroException ex)
            {
                throw new Exception("Checking exception filters");
            }
            return result;

        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers");
            int number1, number2, result = 0;
            try
            {
                number1 = int.Parse("2ds");
                number2 = int.Parse("4");
                result = DivisionNumbers(number1, number2);
                Console.WriteLine(result);
            }
            catch (Exception ex) when (ex.InnerException != null)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
