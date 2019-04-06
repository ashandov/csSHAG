using System;

namespace CatchHierarchy
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] a = new int[5];
            int n = 0;
            try
            {
                for (int i = -3; i <= 3; i++)
                {
                    try
                    {
                        a[n] = 100 / i;
                        Console.WriteLine(a[n]);
                        n++;
                    }
                    catch (DivideByZeroException ex)
                    {
                        Console.WriteLine("Internal catch");
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("External catch");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
