using System;
namespace Lesson06
{
    public class StudentCard
    {
        public StudentCard()
        {
        }
        public int Number { get; set; }
        public string Series { get; set; }
        public override string ToString()
        {
            return $"Number: {Number}\nSeries: {Series}";
        }
    }
}
