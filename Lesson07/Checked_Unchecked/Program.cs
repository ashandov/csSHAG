using System;

namespace Checked_Unchecked
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            byte b = 255;
            try
            {
                checked
                {
                    b++;
                }
                Console.WriteLine(b);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);

            }
            try
            {
                unchecked
                {
                    b++;
                }
                Console.WriteLine(b);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);

            }
        }
    }
}
