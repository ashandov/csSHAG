using System;

namespace NameOfExample
{
    class NameOfExample
    {
        public string Name { get; set; }
        public NameOfExample(string name)
        {
            if (name == null)
            {
                throw new ArgumentException(nameof(name));
            }
            Name = name;
        }
    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            try
            {
                NameOfExample example = new NameOfExample(null);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
