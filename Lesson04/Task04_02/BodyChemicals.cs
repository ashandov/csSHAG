using System;
namespace Task04_02
{
    public  class BodyChemicals : HouseholdsChemicals
    {
        public BodyChemicals(string n, string c, int count, DateTime manDate, DateTime exDate, bool poisonous) : base(n, c, count, manDate, exDate, poisonous)
        {
        }
    }
}
