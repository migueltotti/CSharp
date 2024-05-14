using Exercicio_Resolvido.Entities;

namespace Exercicio_Resolvido
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            // path data
            string path;

            // products data
            string[] data;
            string name;
            double price;

            try
            {
                Console.Write("Enter full file path: ");
                path = Console.ReadLine();

                using (StreamReader sr = File.OpenText(path))
                {
                    while(!sr.EndOfStream)
                    {
                        data = sr.ReadLine().Split(",");
                        name = data[0];
                        price = double.Parse(data[1], System.Globalization.CultureInfo.InvariantCulture);

                        products.Add(new Product(name, price));
                    }

                    //var average = products.Average(x => x.Price);
                    var average = products.Select(x => x.Price).DefaultIfEmpty(0.0).Average();
                    Console.WriteLine("Average price: " + average.ToString("F2", System.Globalization.CultureInfo.InvariantCulture));

                    var names_products = products.Where(x => x.Price < average).Select(x => x.Name).OrderDescending();
                    foreach(string names in names_products)
                    {
                        Console.WriteLine(names);
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
