using System;
using System.Reflection;

namespace UserAttribute
{
    class MainClass
    {
        public static void Main(string[] args)
        {   

            Console.WriteLine("\tArttributes of class Employee:");
             foreach(var attr in typeof(Employee).GetCustomAttributes())
             {
                Console.WriteLine(attr);
             }
            Console.WriteLine("\tAttributes of members of class Employee:");
            foreach (MemberInfo info in typeof(Employee).GetMembers())
            {
                foreach(var attr in info.GetCustomAttributes(true))
                {
                    Console.WriteLine(attr);
                }
            }
        }

    }
}
