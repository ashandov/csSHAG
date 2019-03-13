using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (string s in args)
            {
                Console.WriteLine(s);
            }
            //string str1 = "Simple string";
            //char[] chrArr = { 'S', 'i', 'm', 'p', 'l', 'e', ' ', 's', 't', 'r', 'i', 'n', 'g' };
            //string str2 = new string(chrArr);
            //string str3 = new string(chrArr, 8, 4);
            //string str4 = new string('$', 10);

            //Console.WriteLine(str1);
            //Console.WriteLine(str2);
            //Console.WriteLine(str3);
            //Console.WriteLine(str4);

            //Console.WriteLine("Managing symbol :\\");

            ////verbatim strings
            //string strPath1 = "D:\\Dev";
            //string strPath2 = @"D:\Dev";

            //Console.WriteLine(strPath1);
            //Console.WriteLine(strPath2);

            //string smplstr = "Simple string";
            //char[] chArr1 = new char[6];
            //Console.WriteLine("Reversing of the string with indexator");
            //Console.WriteLine();
            //for (int i = smplstr.Length - 1; i >=0; i--)
            //{
            //    Console.Write(smplstr[i]);
            //}
            //Console.WriteLine();
           
            //Console.WriteLine("\nCopying of the string into array of characters");
            //Console.WriteLine(smplstr);
            //smplstr.CopyTo(5, chArr1,0,6);
            //string str5 = new string(chArr1);
            //Console.WriteLine(str5);

            ////comparing strings
            //string stri1 = "Simple string";
            //string stri2 = "String";
            //string stri3 = "string";
            //string[] striArr = { "Step", "stepping", "runing", "eating", "Playing" };
            //Console.WriteLine("\"" + stri1 + "\"equal \"" + stri2 + "\":" + stri1.Equals(stri2));
            //Console.WriteLine("\"" + stri2 + "\"== \"String\":" + (stri2=="String"));
            //Console.WriteLine("\"" + stri2 + "\"CompareTo(\""+stri3+"\"):"+stri2.CompareTo(stri3));
            //Console.WriteLine("Comparing with case ignoring");
            //Console.WriteLine("\"" + stri1 + "\"equal \"" + stri2 + "\":" + stri1.Equals(stri2,StringComparison.CurrentCultureIgnoreCase));
            //Console.WriteLine("Words wich starts with: \"Step\":");
            //foreach (string s in striArr)
            //    if(s.StartsWith("step",StringComparison.CurrentCultureIgnoreCase))
            //    Console.Write(s+" ");
            //Console.WriteLine();
            //Console.WriteLine("words wich ends with \"ing\"");
            //foreach (string s in striArr)
            //    if (s.EndsWith("ing", StringComparison.CurrentCultureIgnoreCase))
            //        Console.Write(s + " ");
            //Console.WriteLine();

            //string stri4 = "PolimorphismInheritanceUIncapsulation";
            //string stri5 = "ABCDEFGHIJKLMNOP";
            //Console.WriteLine("First occurence of the the \'h\' symbol :"+stri4.IndexOf('h'));
            //Console.WriteLine("First occurence of the substring \"Inheritance\":"+stri4.IndexOf("Inheritance"));
            //Console.WriteLine("Last occurence of the the \'I\' symbol :" + stri4.LastIndexOf('I'));
            //Console.WriteLine("Last occurence of any character in the substring: "+stri4.LastIndexOfAny(stri5.ToCharArray()));
            //Console.WriteLine("Substring which starts from 5th to 10th character:"+stri5.Substring(5,10));


            //string strin1 ="Initial string";
            //Console.WriteLine(strin1);
            //strin1 += " (but in another place of memory)";
            //Console.WriteLine(strin1);

            //stringbuilder
            StringBuilder sb = new StringBuilder();
            //sb="hello"; Error
            sb.Append("Hello");
            string s1 = sb.ToString();
            for (int i = 0; i < s1.Length; i++)
            {
                Console.WriteLine(i + ":" + s1[i]);
            }// addition of the string to the current string
            sb.AppendLine();
            s1 = sb.ToString();
            for (int i = 0; i < s1.Length; i++)
            {
                Console.WriteLine(i + ":" + s1[i]);
            }//addition of the empty line to the current string
            sb.AppendLine();
            s1 = sb.ToString();
            for (int i = 0; i < s1.Length; i++)
            {
                Console.WriteLine(i + ":" + s1[i]);
            }
            sb.Append("world");
            s1 = sb.ToString();
            for (int i = 0; i < s1.Length; i++)
            {
                Console.WriteLine(i + ":" + s1[i]);
            }
            Console.WriteLine("\n \tInitial string");
            Console.WriteLine(sb);
            Console.WriteLine("Max quantity of the characters: "+sb.Capacity);
            Console.WriteLine("Lenght of the current object: "+sb.Length);
            Console.WriteLine("\n \tInserting of the string");
            sb.Insert(7, "abracadabra");
           
            Console.WriteLine(sb);
            Console.WriteLine("Max quantity of the characters: " + sb.Capacity);

            Console.WriteLine("Replacing of 'a' character to 'z'");
            sb.Replace('a', 'z');
            Console.WriteLine(sb);

            Console.WriteLine("\n \tDeleting of 10 chars from 3rd");
            sb.Remove(3, 10);
            Console.WriteLine(sb);
            Console.WriteLine("Max quantity of the characters: " + sb.Capacity);
            Console.WriteLine("Lenght of the current object: " + sb.Length);




        }
    }
}
