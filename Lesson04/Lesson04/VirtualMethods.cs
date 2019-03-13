using System;
namespace Lesson04_Virtual
{
    public class Human
    {
        private string _firstName;
        private string _lastName;
        private DateTime _birthDate;

        public Human(string name, string lastName, DateTime birthday)
        {
            _firstName = name;
            this._lastName = lastName;
            _birthDate = birthday;
        }
        public void Print()
        {
            Console.WriteLine($"\nLast Name: {_lastName} \nName: {_firstName} \nBirth Date: {_birthDate.ToShortDateString()}");
        }
    }
    public class Employee : Human
    {
        private double _salary;

        public Employee(double salary, string firstName, string lastName, DateTime birthday) : base(firstName, lastName, birthday)
        {
            _salary = salary;
        }
        public new void Print()
        {
            Console.WriteLine($"Salary: {_salary}$");
        }
    }

}
