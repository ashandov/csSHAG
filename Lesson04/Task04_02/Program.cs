using System;

namespace Task04_02
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            WareHouse wareHouse = new WareHouse(3);
            wareHouse.TakeToWarehouse(new MilkProducts("Milk", "01", 0, DateTime.Parse("13.02.2019"), DateTime.Parse("16.03.2019")));
            wareHouse.TakeToWarehouse(new MeatProduct("Pork", "02", 0, DateTime.Parse("15.03.2019"), DateTime.Parse("17.03.2019")));
            wareHouse.TakeToWarehouse(new CleaningChemicals("Mr. Proper", "03", 0, DateTime.Parse("13.02.2019"), DateTime.Parse("13.06.2019"), true));
            wareHouse.TakeToWarehouse(new BodyChemicals("Shamptoo shampoo", "04", 0, DateTime.Parse("13.02.2019"), DateTime.Parse("13.06.2019"), false));
            wareHouse.TakeToWarehouse(new Technique("Apple watch series 04", "05", 0, DateTime.Parse("13.02.2019"), DateTime.Parse("13.06.2022")));
            wareHouse.TakeToWarehouse(new MilkProducts("Cottage Cheese", "06", 0, DateTime.Parse("13.02.2019"), DateTime.Parse("16.03.2019")));
            wareHouse.TakeToWarehouse(new MeatProduct("Turkey", "07", 0, DateTime.Parse("15.03.2019"), DateTime.Parse("22.03.2019")));
            Console.WriteLine(wareHouse.Count);
            Console.WriteLine(wareHouse.FreeSpace);
            wareHouse.ShowProductStatus();
            Product product = wareHouse.GetProduct("Shamptoo shampoo", "04");
            wareHouse.Sell(product, product.Code);
            product = wareHouse.GetProduct("Apple watch series 04", "05");
            wareHouse.Transfer(product, product.Code);
            product = wareHouse.GetProduct("Mr. Proper", "03");
            wareHouse.RemoveFromWarehouse(product, product.Code);
            wareHouse.ShowProductStatus();
            wareHouse.CheckExpirationDate();
            wareHouse.ShowProductStatus();
            wareHouse.Revision();

        }

    }
}
