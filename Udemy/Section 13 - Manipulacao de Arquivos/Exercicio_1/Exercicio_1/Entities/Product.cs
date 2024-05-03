using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1.Entities
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Product() { }

        public Product(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public double totalValue()
        {
            return Price * Quantity;
        }

        public override string ToString()
        {
            return Name + "," + totalValue().ToString("F2", System.Globalization.CultureInfo.InvariantCulture);
        }
    }
}
