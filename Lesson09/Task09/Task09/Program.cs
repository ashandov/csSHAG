using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Soap;
using System.Xml.Serialization;

namespace Task09
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            Bill.FormatingCalculated = true;
            Bill bill = new Bill(30,5);
            bill.DelayDays = 5;
            bill.Days = 7;

            SoapFormatter soapFormat = new SoapFormatter();
            try
            {
                using (Stream fStream = File.Create("Bill.soap"))
                {
                    soapFormat.Serialize(fStream, bill);
                }
                Bill b;
                using (Stream fStream = File.OpenRead("Bill.soap"))
                {
                    b = (Bill)soapFormat.Deserialize(fStream);

                }

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }
    }
}