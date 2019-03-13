using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shag_Cosole_Lesson02
{
    class Arrays
    {
        static void Main(string[] args)
        {
            //float[,] fl = new float[2, 3];

            //int[,] myArray = new int[2,3] {{2,4,2},{4,5,1}};
            //int[,] myArray1 = new int[,] { { 2, 4, 2 }, { 4, 5, 1 } };
            //int[,] myArray2 = { { 2, 3 }, { 4, 5 } };

            //myArray2[1, 0] = 4;
            //Console.WriteLine(myArray2[1, 0].ToString());

            //int[, ,] myArray3 = new int[2, 3, 4] { {{3,4,5,3},{5,3,1,5},{2,4,5,1}},
            //                                       {{3,6,2,6},{6,1,6,1},{4,12,634,23}}};

            int[] myArr1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            PrintArray("Array \"myArr1\"", myArr1);
            int[] temparr = (int[])myArr1.Clone();
            Array.Reverse(myArr1, 3, 4);
            PrintArray("Array \"myArr1\" after reverse", myArr1);
            myArr1 = temparr;
            PrintArray("Array aftre recovery", myArr1);
            int[] myArr2 = new int[20];
            PrintArray("Array before copying", myArr2);
            myArr1.CopyTo(myArr2, 5);
            PrintArray("Array after copying", myArr2);
            Array.Clear(myArr2, 0, myArr2.GetLength(myArr2.Rank - 1));
            PrintArray("Array after cleaning", myArr2);
            Array.Resize<int>(ref myArr2, 5);
            PrintArray("Array after resizing", myArr2);
            myArr2 = new[] { 1, 5, 3, 2, 8, 9, 6, 10, 7, 4 };
            PrintArray("Not sorted array", myArr2);
            Array.Sort(myArr2);
            PrintArray("Sorted array", myArr2);
            Console.WriteLine("Number 5 is on {0} position", Array.BinarySearch(myArr2, 5));
            Console.WriteLine("Max element of the array is {0}", myArr2.Max());
            Console.WriteLine("Min element of the array is {0}", myArr2.Min());
            Console.WriteLine("Average value of the array is {0}", myArr2.Average());

            int[,] myArray3 = { { 1, 2, 5 }, { 8, 3, 1 } };
            Console.WriteLine("The rank of the array myArray3 is {0}", myArray3.Rank);

            //jagged arrays
            int[][] jagar = new int[2][];
            jagar[0] = new int[] { 1, 2 };
            jagar[1] = new int[] { 3, 4, 5, 7 };
            Console.WriteLine(jagar[1][2]);

            int size = 5;
            int[][] jagar2 = new int[size][];
            for (int i = 0; i < jagar2.Length; i++)
            {
                jagar2[i] = new int[i + 1];
            }
            for (int i = 0; i < jagar2.Length; i++)
            {
                for (int j = 0; j < jagar2[i].Length; j++)
                {
                    jagar2[i][j] = i + j + 1;
                    Console.Write(jagar2[i][j] + " ");
                }
                Console.WriteLine();

            }
            int[] myArray4 = { 1, 2, 62, 41 };
            foreach (int a in myArray4)
            {
                Console.Write(a + " ");
            }
            //foreach (int a in myArray4)
            //{
            //    a = 52;//compiling error
            //}
            int[] myArray5 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[,] myArray6 = { { 1, 2, 3, 4, 5 }, { 8, 6, 7, 8, 9 } };
            int[][] myArray7 = new int[3][]
            {   new int [5]{1,22,3,4,5},
                new int[2]{1,3},
                new int [1]{1}
            };
            Console.WriteLine();
            Console.WriteLine("One dimentional array:");
            foreach (int i in myArray5)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Two dimentional array:");
            foreach (int i in myArray6)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Jagged array:");
            foreach (int[] i in myArray7)
            {
                foreach (int x in i)
                {
                    Console.Write(x + " ");
                }
                Console.WriteLine();
            }
        }
        static void PrintArray(string text, int[] ar)
        {
            Console.Write(text+": ");
            Console.WriteLine();
            for (int i=0;i<ar.Length-1;i++)
            {
                Console.WriteLine("ar[{0}]={1}",i+1,ar[i]);
            }
            Console.WriteLine();
        }
    }
}
