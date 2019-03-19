using System;
namespace Lesson05.Properties
{
    public class Laptop
    {
        public string Vendor { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return $"Laptop: \n\tVendor:{Vendor}\n\tPrice:{Price}";
        }
    }
    public class Shop
    {
        private Laptop[] laptopsarr;
        public Shop(int lenght)
        {
            laptopsarr = new Laptop[lenght];
        }
        public Laptop this[int index]
        {
            get
            {
                if (index >= 0 && index < laptopsarr.Length)
                {
                    return laptopsarr[index];
                }
                throw new IndexOutOfRangeException();
            }
            set
            {
                if (index > 0 && index < laptopsarr.Length)
                {
                    laptopsarr[index] = value;
                }
            }
        }
        public int Lenght
        {
            get
            {
                return laptopsarr.Length;
            }
        }
    }
}
