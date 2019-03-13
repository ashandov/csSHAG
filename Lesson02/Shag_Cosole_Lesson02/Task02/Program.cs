using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ar = new int[8] { 2, 0, -5, 2, -2, 24, -31, 0 };
            int x;
            for (int i = ar.Length - 1; i>0; i--)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (ar[j] > ar[i])
                    {
                        x = ar[i];
                        ar[i] = ar[j];
                        ar[j] = x;
                    }
                }
            }
                for (int i = 0; i < ar.Length - 1; i++)
                {
                    Console.Write(ar[i] + " ");
                }
            }
        }
    }

