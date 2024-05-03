using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio_2.Entities
{
    internal class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customsfee) : base(name, price)
        {
            CustomsFee = customsfee;
        }

        public override string PriceTag()
        {
            return base.PriceTag() + "(Customs fee: $ " + CustomsFee.ToString("F2", CultureInfo.InvariantCulture) + ")";
        }

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }
    }
}
