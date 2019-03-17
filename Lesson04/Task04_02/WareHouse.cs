using System;
using System.Collections.Generic;

namespace Task04_02
{
	public class WareHouse
	{
		private List<Product> products;
		private uint _freeSpace;

		public WareHouse(uint capacity)
		{
			Capacity = capacity;
			products = new List<Product>();
		}
		public uint Capacity { get; set; }
		public uint FreeSpace
		{
			get
			{
				return (uint)(Capacity - products.Count);
			}
			set
			{
				_freeSpace = value;
			}
		}
		public uint Count
		{
			get
			{
				return (uint)products.Count;
			}
		}
		public List<Product> ListOfProducts
		{
			get
			{
				return products;
			}
		}

		public void RemoveFromWarehouse(Product item, string code)
		{
			if (item == null || code == null)
			{
				throw new ArgumentNullException("Item can't be null and item should have code");
			}
			foreach (var element in products)
			{
				if (element == item && element.Code == item.Code && item.Status == ProductStatus.Recieved)
				{
					item.Status = ProductStatus.Expired;
					break;
				}
			}
			Console.WriteLine("No such product at the warehouse");
		}

		public void Sell(Product item, string code)
		{
			if (item == null || code == null)
			{
				throw new ArgumentNullException("Item can't be null and item should have code");
			}
			foreach (var element in products)
			{
				if (element == item && element.Code == item.Code && item.Status == ProductStatus.Recieved)
				{
					item.Status = ProductStatus.Sold;
					break;
				}
			}
			Console.WriteLine("No such product at the warehouse");
		}

		public void TakeToWarehouse(Product item)
		{
			if (item == null)
			{
				throw new ArgumentNullException("No item to take to warehouse");
			}
			if (products.Count >= Capacity)
			{
				Console.WriteLine("No empty space at the warehouse");
				return;
			}
			item.Status = ProductStatus.Recieved;
			foreach (var product in products)
			{
				if (product == null)
				{
					products.Add(item);
					Console.WriteLine($"{item.Name} has been taken to warehouse");
					return;
				}
			}
			products.Add(item);
			Console.WriteLine($"{item.Name} has been taken to warehouse");


		}

		public void Transfer(Product item, string code)
		{
			if (item == null)
			{
				throw new ArgumentNullException("Item can't be null");
			}
			foreach (var element in products)
			{
				if (element == item && element.Code == item.Code && item.Status == ProductStatus.Recieved)
				{
					item.Status = ProductStatus.Transffered;
					break;
				}
			}
			Console.WriteLine("No such product at the warehouse");

		}
		public void Revision()
		{
			int removedCount = 0;
			for (int i = 0; i < products.Count; i++) { 

				if (products[i].Status != ProductStatus.Recieved)
				{
					products.Remove(products[i]);
					removedCount++;

				}
			}
			Console.WriteLine($"{removedCount} has been removed from warehouse during revision");
		}
		public void CheckExpirationDate()
		{
			int removedCount = 0;
			foreach (var item in products)
			{
				if (item.BestBefore >=DateTime.Today && item.BestBefore!=null)
				{
					item.Status = ProductStatus.Expired;
				}
			}
			Console.WriteLine($"{removedCount} has been expired");
		}
		public Product GetProduct(string name,string code)
		{
			if(String.IsNullOrEmpty(name)|| String.IsNullOrEmpty(code))
			{
				throw new ArgumentNullException("Required product should have hame and code, not null");
			}
			foreach (var item in products)
			{
				if (item.Name  ==name && item.Code == code)
				{
					return item;
				}
			}
			
			Console.WriteLine("Product wasn't found");
			return new MilkProducts("","",0);
		}
		public void ShowProductStatus()
		{
			foreach(Product product in products)
			{
				Console.WriteLine($"Poduct:\"{product.Code} {product.Name}\"");
				Console.WriteLine($"Poduct:\"{product.Status}\"");
				Console.WriteLine();
				
			}
		}


	}


}

