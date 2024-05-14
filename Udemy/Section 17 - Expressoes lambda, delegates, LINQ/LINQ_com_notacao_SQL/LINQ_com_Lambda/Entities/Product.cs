using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_com_notacao_SQL.Entities
{
    internal class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Category Category { get; set; }

        public Product()
        {
        }
        public Product(int iD, string name, double price, Category category)
        {
            ID = iD;
            Name = name;
            Price = price;
            Category = category;
        }

        public override string ToString()
        {
            return ID
                + ", "
                + Name
                + ", "
                + Price.ToString("F2", System.Globalization.CultureInfo.InvariantCulture)
                + ", "
                + Category.Name
                + ", "
                + Category.Tier;
        }
    }
}
