using Restricao_Generics.Entities;
using Restricao_Generics.Services;

namespace Restricao_Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            CalculationService calculationService = new CalculationService();
            int n;
            string[] vect;

            // Products data
            string name;
            double price;

            Console.Write("Enter N: ");
            n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                vect = Console.ReadLine().Split(",");
                name = vect[0];
                price = double.Parse(vect[1], System.Globalization.CultureInfo.InvariantCulture);

                products.Add(new Product(name, price));
            }

            Console.WriteLine("Most expensive:");
            Console.WriteLine(calculationService.Max(products));
        }
    }
}
