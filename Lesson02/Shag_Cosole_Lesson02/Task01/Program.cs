using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            int?[] ar = new int?[8] { 2, 0, -5, 2, 0, 0, 0, 31 };
            //1st option by using new array
           int?[] ar1 = new int?[8];
			
            for (int i = 0,j=0; i < ar.Length; i++)
            {
					if (ar[i] != 0)
					{
						ar1[j++] = ar[i];
					}
					if (i == ar.Length)
					{
						while (j < ar.Length)
						{
							ar1[j++] = -1;
						}
					}
            }
            Console.WriteLine(Environment.NewLine + "First option. By using the new array:");
            for (int k = 0; k < ar1.Length; k++)
            {
                if (ar1[k] == null)
                {
                    ar1[k] = -1;
                }
                Console.Write(ar1[k] + " ");
            }
            //-------------------------------------------------------------------------------------------
            //2nd option, but order of the elements is changed
           
            for (int j = 0, h = ar.Length - 1; j < ar.Length - 1; j++)
            {
                if (ar[h] != null && ar[j] == null)
                {
                    ar[j] = ar[h];
                    ar[h] = null;
                    h--;
                }
            }
            Console.WriteLine(Environment.NewLine + "Second option. Without of using the new array, but with disordering of elements");
            for (int k = 0; k < ar.Length; k++)
                {
                    if (ar[k] == null)
                    {
                        ar[k] = -1;
                    }
                    Console.Write(ar[k] + " ");
                }
               
               
                //draft of other attempts
                //else if (ar[i] == null && ar[j] != null)
                //{
                //    ar[i] = ar[j];
                //    ar[j] = null;
                //    j++;
                //}
                //else if (ar[i] == null && ar[j] == null)
                //{
                //    i++;
                //}
                //for (int i = 0; i < ar.Length - 1; i++)
                //{
                //    if (ar[i] == null)
                //    {
                //        ar[i] = ar[i + 1];
                //        ar[i + 1] = null;
                //    }
                //if (ar[i] != null && ar[j] == null)
                //{
                //    if (i + 1 == null)
                //    {
                //        break;
                //    }
                //    ar[j] = ar[i];
                //    ar[i] = null;
                //}

            }
           
            //int j = 0;
            //for (int i = 0; i < ar.Length; i++,j++)
            //{
            //    if (ar[i] !=null)
            //    {
            //        ar1[j] = ar[i];
            //    }
            //    else
            //    {
            //        j--;   
            //    }
            //}
            //for (int i = 0; i < ar1.Length; i++)
            //{
            //    if (ar1[i] == null)
            //    {
            //        ar1[i] = -1;
            //    }
            //    Console.Write(ar1[i] + " ");
            //}
        }

    }


