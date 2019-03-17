using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04_02
{
    public abstract class Product
    {
        public ProductStatus Status;
        private string _name;
        private string _code;
        private int _qty;
        private DateTime _manufacturedDate;
        private DateTime _bestBefore;


        public Product(string n, string c, int count, DateTime manDate, DateTime exDate)
        {
            Name = n;
            Code = c;
            Qty = count;
            _manufacturedDate = manDate;
            _bestBefore = exDate;
            Status = ProductStatus.Recieved;
        }

        protected Product(string n, string c, int count)
        {
            _name = n;
            _code = c;
            _qty = count;
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name can't be epmty");
                }
                _name = value;
            }
        }


        public string Code
        {
            get { return _code; }
            set { _code = value; }
        }


        public int Qty
        {
            get { return _qty; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Qty can't be negative");
                }
                _qty = value;
            }
        }


        public DateTime ManufacturedDate
        {
            get { return _manufacturedDate; }
            set
            {
                if (value > DateTime.Today)
                {
                    throw new ArgumentOutOfRangeException("The prodcut can't be crated as manufactured in future");
                }
                _manufacturedDate = value;
            }
        }

        public DateTime BestBefore
        {
            get { return _bestBefore; }
            set
            {
                if (value < DateTime.Today)
                {
                    throw new ArgumentOutOfRangeException("The product period of using has expired");
                }
                _bestBefore = value;
            }
        }



    }
}
