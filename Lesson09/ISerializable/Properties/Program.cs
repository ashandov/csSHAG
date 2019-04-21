using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Xml.Serialization;

namespace Serialization
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // List<Person> persons = new List<Person>()
            //{
            //    new Person(97635){Name="Lenny",Age=28},
            //    new Person(97215){Name="Jack",Age=35},
            //    new Person(96335){Name="Lora",Age=22},
            //};
            Person p = new Person() { Name="Jack",DateBirth=new DateTime(1994,2,7)};
            //BinaryFormatter binFormat = new BinaryFormatter();
            SoapFormatter soapFormat = new SoapFormatter(); 
            //mlSerializer xmlFormat = new XmlSerializer(typeof(List<Person>)); 
            try
            {
                using (Stream fStream = File.Create("test.soap"))
                {
                    //binFormat.Serialize(fStream, p);
                    //xmlFormat.Serialize(fStream, persons);
                    soapFormat.Serialize(fStream,p);
                }
                Console.WriteLine("Serialization OK!\n");
                Person p1 = null;
                //List<Person> desirializedPersons = new List<Person>();
                using(Stream fStream = File.OpenRead("test.soap"))
                {
                    p1=(Person)soapFormat.Deserialize(fStream);
                    //desirializedPersons = (List<Person>)xmlFormat.Deserialize(fStream);
                }
                Console.WriteLine(p1);
                //foreach(Person person in desirializedPersons)
                //{
                //    Console.WriteLine(person);
                //}

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
