using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        enum EnumName { elem1, elem2, elem3, elem4 }
        public enum DaysOfWeek { Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday}
        enum TransportType { Semitrailer,Coupling,Refrigerator,OpenSideTruck,Tank} //type of transport
        enum Discount { Default,Incentive=2,Patron=5,VIP=15}

        enum DistanceEnum :ulong 
        {
            Sun=0,
            Mercury = 57900000,
            Venus = 108200000,
            Earth = 149600000,
            Mars = 227900000,
            Jupiter = 7783000000,
            Saturn = 1427000000, 
            Uranus = 2870000000,
            Neptune = 4496000000,
            Pluto = 5946000000
        
        }

        enum CommodityType //type of goods
        {
            FrozenFood,Food,DomesticChemistry,BuildingMaterials,Petrol
        }


        static void Main(string[] args)
        {

            //TransportType car = TransportType.Refrigerator;
            //Console.WriteLine(NextDay(DaysOfWeek.Friday));

            Console.WriteLine("Enter nubmer from 1 to 5:");
            int i = Int32.Parse(Console.ReadLine());
            if (i > 0 && i < 6)
            {
                CommodityType commodity = (CommodityType)Enum.GetValues(typeof(CommodityType)).GetValue(i - 1);
                TransportType transport = TransportType.Semitrailer;
                switch (commodity)
                {
                    case CommodityType.FrozenFood:
                        transport=TransportType.Refrigerator;
                        break;
                    case CommodityType.DomesticChemistry:
                        transport=TransportType.Coupling    ;
                        break;
                    case CommodityType.Food:
                        transport=TransportType.Semitrailer;
                        break;
                    case CommodityType.BuildingMaterials:
                        transport = TransportType.OpenSideTruck;
                        break;
                }
                Console.WriteLine("For that kind of product {0} is more suitable transport",transport);
            }
            else 
            {
                Console.WriteLine("Input error"); 
            }
            string moon = "Moon";
            if (!Enum.IsDefined(typeof(DistanceEnum), moon))
            {
                Console.WriteLine("Current value doen't exist in current enumeration");
            }
            else
            {
                Console.WriteLine("Current value is exist");
            }
            Console.WriteLine("\n \tFormatted output all of the constants values from the enumeration :");
            foreach (DistanceEnum item in Enum.GetValues(typeof(DistanceEnum)))
            {
                Console.WriteLine("{0,-10}{1,-10}{2,20}",
                    Enum.Format(typeof(DistanceEnum), item, "G"),//output the string witn constant name
                    Enum.Format(typeof(DistanceEnum), item, "D"),//output as decimal value
                    Enum.Format(typeof(DistanceEnum), item, "X"));//outup as hexadecimal value 
            }
            Console.WriteLine("\n \tAll the constant values from the specified enumeration.");
            foreach (string s in Enum.GetNames(typeof(DistanceEnum)))
            {
                Console.WriteLine(s);
            }
            ulong number = 227900000;
            Console.WriteLine("Name of the constant which have {0} from the specified enumeration:",number);
            Console.WriteLine(Enum.GetName(typeof(DistanceEnum),number));
        }
        public static DaysOfWeek NextDay(DaysOfWeek day)
        {
            return (day < DaysOfWeek.Sunday) ? ++day: DaysOfWeek.Monday;
        }
              
    }
}
