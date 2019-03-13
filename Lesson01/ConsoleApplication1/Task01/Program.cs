using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Program
    {
        static Arguments args = new Arguments(new int[3]);
        static void IntParsing(string s, ref int r)
        {
            if (!Int32.TryParse(s, out r))
            {
                Console.WriteLine("Incorrect value was intputted for the argument.");
            }
        }
           static Arguments CallInput()
           {
               string argVal;
               Console.WriteLine("Enter 3 even numbers");
               for (int i = 0; i < 3; i++)
               {
                   argVal = Console.ReadLine();
                   IntParsing(argVal, ref args.GetArray()[i]);
               }
               return args;
           }
        static void Main(string[] args)
           {
             int S1,S2,S3;
             
            Arguments ar=CallInput();
            if ((ar.A > 0) && (ar.B > 0) && (ar.С>0))
            {
                S1 = ar.A* ar.B;
                S2 = ar.С * ar.С;

                if (ar.A / ar.С > 0 && ar.B / ar.С > 0)
                {
                    S3 = (ar.A / ar.С) * (ar.B / ar.С);
                    Console.WriteLine("{0} could be fitted in the rectangle." + Environment.NewLine + "Remaining area is {1}", S3, S1 -S3*S2);
                }

                else 
                {
                    Console.WriteLine("0 rectangles could be fitted in the rectangle.");
                }
                }
            else
            {
                Console.WriteLine("Arguments should be greater than 0");
            }
   

        }

        }
     class Arguments
    {
        
        private int [] array;
        public Arguments(int[] ar)
        {
            if (ar != null)
            {
                array = new int[3];
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = ar[i];
                }
            }
        }  
         public int A
        {
            get
            {
                return array[0];
            }
            set
            {
                array[0]=value;
            }
        }
         public int B
        {
            get
            {
                return array[1];
            }
            set
            {
                array[1] = value;
            }
        }
         public int С
        {
            get
            {
                return array[2];
            }
            set
            {
                array[2] = value;
            }
        }
         public int[] GetArray()
         {
            return array;
         }
         
       
    }
    }


