using Func.Entities;

namespace Func
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            //Func<Product, string> func = NameUpper;
            //Func<Product, string> func = x => x.Name.ToUpper();

            //List<string> list2 = list.Select(NameUpper).ToList();
            //List<string> list2 = list.Select(func).ToList();
            List<string> list2 = list.Select(x => x.Name.ToUpper()).ToList();


            foreach (string item in list2)
            {
                Console.WriteLine(item);
            }
        }

        static string NameUpper(Product p)
        {
            return p.Name.ToUpper();
        }
    }
}
