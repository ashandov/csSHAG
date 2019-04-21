using System;
using System.Runtime.Serialization;

namespace Serialization
{
    [Serializable]
    public class Person
    {
        public string Name { get; set; }
        //public int Age { get; set; }
        public DateTime DateBirth { get; set; }
        //private int _identNumber;

        [NonSerialized]
        private const string Planet = "Earth";
        //public Person(int number)
        //{
        //    //_identNumber = number;
        //}
        public Person()
        {

        }
        [OnSerializing]
        private void OnSerialization(StreamingContext streamContext)
        {
            Name = Name.ToUpper();
            DateBirth.ToUniversalTime();
        }
        [OnDeserialized]
        private void OnDeserialization(StreamingContext streamContext)
        {
            Name = Name.ToLower();
            DateBirth.ToLocalTime();
        }
        //public override string ToString()
        //{
        //    return $"Name: {Name}, Age: {Age}, Identification number: {_identNumber}, Planet: {Planet}";
        //}
        public override string ToString()
        {
            return $"Name: {Name}, Birth date: {DateBirth}";
        }
    }
}
