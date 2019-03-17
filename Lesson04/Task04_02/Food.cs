using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04_02
{
    public abstract class Food : Product
    {

        public Food(string n, string c, int count, DateTime manDate, DateTime exDate) : base(n, c, count, manDate, exDate)
        {
        }
		public Food(string n, string c, int count) : base(n, c, count)
		{
		}
		private decimal _protein;

        public decimal Protein
        {
            get
            {
                return _protein;
            }
            set
            {
                CheckInputValueForPFC(value);
                _protein = value;
            }

        }
        private decimal _fat;

        public decimal Fat
        {
            get
            {
                return _fat;
            }
            set
            {
                CheckInputValueForPFC(value);
                _fat = value;
            }

        }
        private decimal _carbs;

        public decimal Carbs
        {
            get
            {
                return _carbs;
            }
            set
            {
                CheckInputValueForPFC(value);
                _carbs = value;
            }

        }
        public void GetPFCForTheProduct()
        {
            Console.WriteLine($"Proteins: {Protein} \tFats: {Fat},\tCarbs: {Carbs}");
        }
        private void CheckInputValueForPFC(decimal val)
        {
            if (val > 100)
            {
                throw new ArgumentOutOfRangeException("Value can't be more than 100 on 100 gramm portion");
            }
        }
    }
}
