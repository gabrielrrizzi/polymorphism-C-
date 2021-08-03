using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaPolimorfismo.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufatureDate { get; set; }

        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price, DateTime manufaturedate) : base(name, price)
        {
            ManufatureDate = manufaturedate;
        }

        public override string PriceTag()
        {
            return Name
                + " (used) $ "
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + "(Manufature date:"
                + ManufatureDate.ToString("dd/MM/yyyy")
                + ")";
        }



    }
}
