using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson08
{
	class Student
	{
		public string LastName { get; set; }
		public string FirstName { get; set; }
		public DateTime BirthDate { get; set; }
		public override string ToString()
		{
			return $"Surname: {LastName}, Name: {FirstName}, Born: {BirthDate.ToLongDateString()}";
		}
	}
}
