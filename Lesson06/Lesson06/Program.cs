using System;

namespace Lesson06
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Auditory auditory = new Auditory();
            Console.WriteLine("\n-------------List of students-------------\n");
            foreach (var student in auditory)
            {
                Console.WriteLine(student);
            }
            auditory.Sort();
            //Indexer index = new IndexerClass();
            //Console.WriteLine("\t\tValues outut:\n");
            //Console.WriteLine("Using of integer indexator");
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(index[i]);
            //}
            //Console.WriteLine("Using os the string indexator:");
            //foreach (string s in Enum.GetNames(typeof(Numbers)))
            //{
            //    Console.WriteLine(index[s]);
            //}
        }
        interface Indexer
        {
            string this[int index]
            {
                get;
                set;
            }

            string this[string index]
            {
                get;
            }
        }
        enum Numbers
        {
            one, two, three, four, five,
        }
        class IndexerClass : Indexer
        {
            string[] names = new string[5];
            public IndexerClass()
            {
                this[0] = "Bob";
                this[1] = "Candice";
                this[2] = "Jimmy";
                this[3] = "Joey";
                this[4] = "Nicole";
            }
            public string this[int index]
            {
                get
                {
                    return names[index];
                }
                set
                {
                    names[index] = value;
                }
            }
            public string this[string index]
            {
                get
                {
                    if (Enum.IsDefined(typeof(Numbers), index))
                    {
                        return names[(int)Enum.Parse(typeof(Numbers), index)];
                    }
                    else
                    {
                        return "";
                    }
                }
            }
        }

    }
}
