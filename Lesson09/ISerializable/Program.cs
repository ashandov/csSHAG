using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;


namespace Serialization
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Person person = new Person
            {
                Name = "Jack",
                DateBirth = new DateTime(1995, 11, 5)
            }; SoapFormatter soapFormat = new SoapFormatter();
            try
            {
                using (Stream fStream =
                File.Create("test.soap"))
                {
                    soapFormat.Serialize(fStream, person);
                }
                Console.WriteLine("SoapSerialize OK!\n");
                Person p = null;
                using (Stream fStream =
                File.OpenRead("test.soap"))
                {
                    p = (Person)soapFormat.Deserialize(fStream);
                }
               
                //Console.WriteLine(p);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
