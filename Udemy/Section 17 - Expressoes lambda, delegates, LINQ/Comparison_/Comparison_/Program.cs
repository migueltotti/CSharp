using Comparison_.Entities;

namespace Comparison_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            products.Add(new Product("TV", 900.00));
            products.Add(new Product("Notebook", 1200.00));
            products.Add(new Product("Tablet", 400.00));

            Comparison<Product> comp = (p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());

            //products.Sort(CompareProducts);
            //products.Sort(comp);
            products.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()));

            foreach (Product product in products)
            {
                Console.WriteLine(product);
            }
        }

        static int CompareProducts(Product product1, Product product2)
        {
            return product1.Name.ToUpper().CompareTo(product2.Name.ToUpper());
        }

        static int CompareProductsD(Product product1, Product product2)
        {
            int ret = 0;

            if(product1.Name.ToUpper().CompareTo(product2.Name.ToUpper()) > 0)
            {
                ret = - 1;
            }
            else if (product1.Name.ToUpper().CompareTo(product2.Name.ToUpper()) < 0)
            {
                ret = 1;
            }
            else if (product1.Name.ToUpper().CompareTo(product2.Name.ToUpper()) == 0)
            {
                ret = 0;
            }

            return ret;
        }

        static int CompareProductsC(Product product1, Product product2)
        {
            int ret = 0;

            if (product1.Name.ToUpper().CompareTo(product2.Name.ToUpper()) > 0)
            {
                ret = 1;
            }
            else if (product1.Name.ToUpper().CompareTo(product2.Name.ToUpper()) < 0)
            {
                ret = -1;
            }
            else if (product1.Name.ToUpper().CompareTo(product2.Name.ToUpper()) == 0)
            {
                ret = 0;
            }

            return ret;
        }
    }
}
