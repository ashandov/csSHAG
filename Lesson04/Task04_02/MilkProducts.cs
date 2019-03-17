using System;
namespace Task04_02
{
    public class MilkProducts : Food
    {
        public MilkProducts(string n, string c, int count, DateTime manDate, DateTime exDate) : base(n, c, count, manDate, exDate)
        {
            
        }
		public MilkProducts(string n, string c, int count) : base(n, c, count)
		{

		}

	}
}
