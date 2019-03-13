using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cycles
{
    class Program
    {
        static void Main(string[] args)
        {

            //cycle fot
            //int counter = 0;
            //string str = "кабак";
            //for (int i = 0, j = str.Length - 1; i < j; i++, j--)
            //{
            //    if (str[i] == str[j])
            //        counter++;
            //}
            //if (counter == str.Length / 2)
            //{
            //    Console.WriteLine("String is palindrome");
            //}
            //else
            //{
            //    Console.WriteLine("String isn't palindrome");
            //}

            Random r = new Random();
            //while (true)
            //{
            //    Console.WriteLine(r.Next());    
            //}

            //counter = 0;
            //int number;
            //int ssum = 0;

            //while (ssum < 100)
            //{
            //    ssum += r.Next(0,20);
            //    counter++;
            //}
            //Console.WriteLine("Sum {0} values  between 0 and 20 is euqal: {1}",counter,ssum);

            ////do while
            //int sum = 0;
            //Console.WriteLine("Enter any number:");
            //number = Convert.ToInt32(Console.ReadLine());
            //int temp = number;
            //do
            //{
            //    sum += number % 10;
            //    number /= 10;
            //}
            //while(number>0);
            //Console.WriteLine(sum);

            //foreach
            int[] arrd = new int[10];
            for (int i = 0; i < arrd.Length; i++)
            {
                arrd[i] = r.Next(100);
            }
            for (int i = 0; i < arrd.Length; i++)
            {
                Console.Write(arrd[i]+" ");
            }
            long sumarr = 0;
            int minarrd = arrd[0];
            int maxarrd = arrd[0];
            foreach (int val in arrd)
            {
                sumarr += val;
                if (val < minarrd)
                {
                    minarrd=val;
                }
                else if (val > maxarrd)
                {
                    maxarrd = val;
                }
            }
            Console.WriteLine("\nMax element of the array is {0}, min element of the array is {1}. The sum of the array elements; {2}",maxarrd,minarrd,sumarr);

            //break
         int k = 0;
         while (true)
         {
             if (++k % 6 == 0)
             {
                 Console.Write(k.ToString()+" ");
             }
             if (k == 100)
             {
                 Console.WriteLine(Environment.NewLine);
                 break;
             }
         }
         for (int i = 1; i < 20; i++)
         {
             if (i % 2 != 0)
             {
                 continue;
             }
             Console.Write(i.ToString()+" ");
         }
         Console.WriteLine(Environment.NewLine);
         double sr_zp = 0;
         double zp = 0;
         int kol = 0;
            do
            {
                Console.WriteLine("Enter amount of the salary more than 500$.\n (for ending enter negative value): \n");
                zp=Convert.ToDouble(Console.ReadLine());
                if (zp < 0)
                {
                    break;
                }
                if (zp < 500)
                {
                    continue;
                }
                else
                {
                    sr_zp += zp;
                    kol++;
                }

            }
            while(true);
            if (kol > 0)
            {
                sr_zp /= kol;
            }
            Console.WriteLine("Average salary is equal:{0}",sr_zp);

            //goto
            //Label1:
            //if (true)
            //{
            //    goto Label1;
            //}
            int level = Int32.Parse(Console.ReadLine());
            switch (level)
            {
                case 0:
                    Console.WriteLine("Lelel 0");
                    break;
                case 1:
                    goto case 2;
                case 2:
                    Console.WriteLine("Level from 1 to 2");
                    goto default;
                default:
                    Console.WriteLine("Default");
                    break;
            }
        }
    }
}
