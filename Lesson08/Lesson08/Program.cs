using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson08
{
	class Program
	{
		static string FullName(Student student)
		{
			return$"{student.LastName}\t{student.FirstName}";
		}
		static bool OnlySpring(Student student)
		{
			return student.BirthDate.Month >= 3 && student.BirthDate.Month <= 5;
		}
		static void Main(string[] args)
		{
			List<Student> students = new List<Student>
			{
				new Student
				{
					FirstName="Jack",
					LastName="Pinch",
					BirthDate=new DateTime(1997,3,12)
				},
				new Student
				{
					FirstName="Melissa",
					LastName="Bumstead",
					BirthDate=new DateTime(199,2,21)
				},
				new Student
				{
					FirstName="Joe",
					LastName="Tribiani",
					BirthDate=new DateTime(1996,7,10)
				}
			};
			Console.WriteLine("Born in spring");
			List<Student> studentsBornInSpring = students.FindAll(OnlySpring);
			foreach (Student item in studentsBornInSpring)
			{
				Console.WriteLine(item);
			}
			//Console.WriteLine("List of students");
			//IEnumerable<string> studs = students.Select(FullName);
			//foreach(string item in studs)
			//{
			//	Console.WriteLine();
			//}
			//ExampleClass example = new ExampleClass();
			//AddDelegate<int> addDelegate = example.AddInt;
			//Console.WriteLine($"The sum of integer: {addDelegate(4,3)}");
			//AddDelegate<double> addDouble = example.AddDouble ;
			//Console.WriteLine($"The sum of double: {addDouble(4.3, 3.6)}");
			//AddDelegate<char> addChar = ExampleClass.AddChar;
			//Console.WriteLine($"The sum of integer: {addDelegate('s','h')}");



		}
	}
}
