using System;
namespace Task04_02
{
    public  class CleaningChemicals : BodyChemicals
	{ 
		public CleaningChemicals(string n, string c, int count, DateTime manDate, DateTime exDate, bool poisonous) : base(n, c, count, manDate, exDate, poisonous)
		{
		}
	}
}
