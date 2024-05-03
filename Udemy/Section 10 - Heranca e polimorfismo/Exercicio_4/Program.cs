using Exercicio_4.Entities;
using System.Globalization;

namespace Exercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Taxpayer> list = new List<Taxpayer>();

            int number_taxpayers;

            // taxpayers data:
            string type;
            string name;
            double anual_income;

            double health_spending;

            int number_employees;

            Console.Write("Enter the number of tax payers: ");
            number_taxpayers = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number_taxpayers; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");

                Console.Write("Individual or company (i/c)? ");
                type = Console.ReadLine();

                Console.Write("Name: ");
                name = Console.ReadLine();

                Console.Write("Anual income: ");
                anual_income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(type == "i")
                {
                    Console.Write("Health expenditures: ");
                    health_spending = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Individual(health_spending, name, anual_income));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    number_employees = int.Parse(Console.ReadLine());

                    list.Add(new Company(number_employees, name, anual_income));
                }
            }

            Console.WriteLine("\nTAXES PAID: ");

            double sum = 0.0;

            foreach (Taxpayer items in list)
            {
                Console.WriteLine(items);

                sum += items.Tax();
            }

            Console.WriteLine("\nTOTAL TAXES: $ " + sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
