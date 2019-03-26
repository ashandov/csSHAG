using System;
namespace Lesson06
{
    public class Student : IComparable
    {
        public Student()
        {
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public StudentCard StudentCard { get; set; }

        public int CompareTo(object obj)
        {
            if (obj is Student)
            {
                return LastName.CompareTo((obj as Student).LastName);
            }
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"First Name :{FirstName}\nLast Name: {LastName}\nBirth Date: {BirthDate.ToLongDateString()}\nStudent card: {StudentCard}/n";
        }
    }
}
