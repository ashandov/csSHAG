using System;
using System.Collections;
using System.Collections.Generic;
namespace Lesson06
{
    public class Auditory
    {
        Student[] students = { new Student { FirstName = "Jack", LastName = "Lenght", BirthDate = new DateTime(1987, 02, 05), StudentCard = new StudentCard { Number = 1234, Series = "AA" } },
             new Student { FirstName = "Alice", LastName = "Sparks", BirthDate = new DateTime(1988, 02, 05), StudentCard = new StudentCard { Number = 2424, Series = "AB" } },
             new Student { FirstName = "Viktor", LastName = "Mart", BirthDate = new DateTime(1987, 03, 21), StudentCard = new StudentCard { Number = 9234, Series = "XA" } },
             new Student { FirstName = "Fill", LastName = "Hill", BirthDate = new DateTime(1986, 02, 23), StudentCard = new StudentCard { Number = 5343, Series = "RT" } } };
        public Auditory()
        {
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < students.Length; i++)
            {
                yield return students[i];
            }
        }

        public void Sort()
        {
            Array.Sort(students);
        }
    }
}
