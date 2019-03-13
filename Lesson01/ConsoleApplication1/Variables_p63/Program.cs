using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables_p63
{
    class Program
    {
        static void Main(string[] args)
        {

           
            int SomeVar;//acceptably
            int _someVar;//acceptably
            int _SomeVar;//acceptably
            int someVar3;//acceptably
            //int 3somevar;//unacceptably

            int @int = 3;
            Console.WriteLine(@int);
            //Pascal case convention
            double SupplierPrice = 3.13;
            double SuplementaryPrice = SupplierPrice * 0.2;
            double SellingPrice = SupplierPrice + SuplementaryPrice;

            //Camel case convention
            double supplierPrice = 3.13;
            double suplementaryPrice = supplierPrice * 0.2;
            double sellingPrice = supplierPrice + suplementaryPrice;

            { //начало внутреннего блока
                //тело внутреннего блока
            } //конец внутреннего блока
        }
    }
}
