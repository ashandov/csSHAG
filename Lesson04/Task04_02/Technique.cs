using System;
namespace Task04_02
{
    public  class Technique : Product
    {
        public Technique(string n, string c, int count, DateTime manDate, DateTime exDate) : base(n, c, count, manDate, exDate)
        {
        }
		public Technique(string n, string c, int count) : base(n, c, count)
		{
		}
	}
}
