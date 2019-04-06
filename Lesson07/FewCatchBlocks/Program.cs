using System;

namespace FewCatchBlocks
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            do
            {
                try
                {
                    Console.WriteLine("Enter value");
                    string str = "dss";
                    if (String.IsNullOrEmpty(str))
                    {
                        return;
                    }
                    int number = Convert.ToInt32(str);

                    if (number <= 0)
                    {
                        throw new ArgumentOutOfRangeException("Number is <=0");
                    }
                    double log = Math.Log(number);
                    //Console.WriteLine($"ln({number}){log}\n100/ln({number}) = {100 / (int)log}»)");
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Exception {ex.Message}");
                }
            }
            while (true);
        }
    }
}
