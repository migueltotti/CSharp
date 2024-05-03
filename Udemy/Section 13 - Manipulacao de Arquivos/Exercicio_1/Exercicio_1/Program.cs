using Exercicio_1.Entities;
using System.IO;

namespace Exercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            string sourcePath; // = @"C:\Users\User\Documents\C#\CSharp\Udemy\Section 13 - Manipulacao de Arquivos\Source_file";
            string outputFile = @"C:\Users\User\Documents\C#\CSharp\Udemy\Section 13 - Manipulacao de Arquivos\Source_file";

            string[] line = new string[3];

            // products data:
            string name;
            double price;
            int quantity;

            int i = 0;

            try
            {
                Console.Write("Enter the path of source file (.csv): ");
                sourcePath = Console.ReadLine();

                sourcePath = sourcePath.Replace(@"\", @"\\");
                int lenght = sourcePath.Length;
                sourcePath = sourcePath.Remove(lenght - 1, 1).Remove(0, 1);

                using (StreamReader sr = File.OpenText(sourcePath))
                {
                    while (!sr.EndOfStream)
                    {
                        line = sr.ReadLine().Split(",");

                        name = line[0];
                        price = double.Parse(line[1], System.Globalization.CultureInfo.InvariantCulture);
                        quantity = int.Parse(line[2]);

                        products.Add(new Product
                        {
                            Name = name,
                            Price = price,
                            Quantity = quantity
                        });

                        line[0] = "";
                        line[1] = "";
                        line[2] = "";
                    }

                    Directory.CreateDirectory(outputFile + @"\out");

                    using (StreamWriter sw = File.AppendText(outputFile + @"\out\summary.csv"))
                    {
                        foreach (Product item in products)
                        {
                            sw.WriteLine(item);
                        }
                    }
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred!");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (Directory.Exists(outputFile + @"\out\summary.csv"))
                {
                    Console.WriteLine("Directory: out\nFile: sumarry.csv\nCREATED!");
                }
            }
            
        }
    }
}
