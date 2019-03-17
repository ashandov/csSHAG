using System;
using System.Collections.Generic;
namespace Task04_02
{
    public class MeatProduct : Food
    {

        public MeatProduct(string n, string c, int count, DateTime manDate, DateTime exDate) : base(n, c, count, manDate, exDate)
        {

        }
		public MeatProduct(string n, string c, int count) : base(n, c, count, DateTime.MinValue, DateTime.MaxValue)
		{

		}
	}
}
