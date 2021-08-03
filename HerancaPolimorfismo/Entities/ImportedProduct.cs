using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaPolimorfismo.Entities
{
    class ImportedProduct : Product
    {
        public double CustomFee { get; set; }

        public ImportedProduct()
        {
        }
        public ImportedProduct(string name, double price, double customfee) : base(name, price)
        {
            CustomFee = customfee;
        }
        public double TotalPrice()
        {
            return Price + CustomFee;
        }

        public override string PriceTag()
        {
            return Name
                + " $ "
                + TotalPrice().ToString("F2", CultureInfo.InvariantCulture)
                + "( Custom fee: $ "
                + CustomFee.ToString("F2", CultureInfo.InvariantCulture)
                + ")";

        }



    }


}
