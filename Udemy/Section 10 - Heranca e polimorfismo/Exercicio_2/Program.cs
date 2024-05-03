using System.Globalization;

using Exercicio_2.Entities;

namespace Exercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            int number_products;

            // products data:
            string type_product;
            string name;
            double price;

            double customfee;

            DateTime manufacturedate;

            Console.Write("Enter the number of products: ");
            number_products = int.Parse(Console.ReadLine());
            
            for(int i = 1; i <= number_products; i++)
            {
                Console.WriteLine($"Product #{i} data:");

                Console.Write("Common, used or imported (c/u/i)? ");
                type_product = Console.ReadLine();

                Console.Write("Name: ");
                name = Console.ReadLine();

                Console.Write("Price: ");
                price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (type_product == "u")
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    manufacturedate = DateTime.Parse(Console.ReadLine());

                    list.Add(new UsedProduct(name, price, manufacturedate));
                }
                else if(type_product == "i")
                {
                    Console.Write("Custom fee: ");
                    customfee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new ImportedProduct(name, price, customfee));
                }
                else
                {
                    list.Add(new Product(name, price));
                }
            }

            Console.WriteLine("\nPRICE TAGS:");

            foreach (Product items in list)
            {
                Console.WriteLine(items.PriceTag());
            }

        }
    }
}
