using System;

namespace Task04_02
{
    public abstract class HouseholdsChemicals : Product
    {
        public bool isPoisonous;
        public HouseholdsChemicals(string n, string c, int count, DateTime manDate, DateTime exDate, bool poisonous) : base(n, c, count, manDate, exDate)
        {
            isPoisonous = poisonous;
        }
		public HouseholdsChemicals(string n, string c, int count, bool poisonous) : base(n, c, count, DateTime.MinValue, DateTime.MaxValue)
		{
			isPoisonous = poisonous;
		}
	}
}
