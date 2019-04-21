using System;
using System.Text.RegularExpressions;

namespace RegularExpressions
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string emailPattern = @"^[a-z0-9_-]+@[a-z0-9_-]+\.[a-z0-9_-]+\.[a-z]{2}";
                                //@"^([a-z0-9_-]+\.)*
                                //[a-z0-9_-]+@[a-z0-9_-]+
                                //(\.[a-z0-9_-]+)*
                                //\.[a-z]{2,6}$";
            Console.WriteLine("Write email:");
            string email = Console.ReadLine();
            Regex regex = new Regex(emailPattern);
            Console.WriteLine(regex.IsMatch(email) ? "Email confirmed.":"Incorrect email");
            string phonePattern = @"^\+\d+{ 2}\(\d{ 3}\)
                                \d{ 3}-\d{ 2}-\d{ 2}$";
            Console.WriteLine("Enter phone:");
            string phone = Console.ReadLine();
            regex = new Regex(phonePattern);
            Console.WriteLine(regex.IsMatch(phone)? "Data recieved.":"Incorrect data!");
            Console.WriteLine("\nReplacement of words matching a pattern.");
            string text = "I like Java. Java forever.";
            string textPattern = "Java";
            Console.WriteLine(text);
            Console.WriteLine(Regex.Replace(text,textPattern,"C#"));
        }
    }
}
