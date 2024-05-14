using Exercicio_1.Entities;
using System.Net.Http.Headers;

namespace Exercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employees> employees = new List<Employees>();

            string path;
            double salary_base;

            // employees data
            string[] data;
            string name;
            string email;
            double salary;

            try
            {
                Console.Write("Enter full file path: ");
                path = Console.ReadLine();

                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        data = sr.ReadLine().Split(",");
                        name = data[0];
                        email = data[1];
                        salary = double.Parse(data[2], System.Globalization.CultureInfo.InvariantCulture);

                        employees.Add(new Employees(name, email, salary));
                    }

                    Console.Write("Enter salary: ");
                    salary_base = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);

                    Console.WriteLine("Email of people whose salary is more than " + salary_base.ToString("F2", System.Globalization.CultureInfo.InvariantCulture) + ":");
                    var emails = employees.Where(x => x.Salary > 2000.00).Select(x => x.Email).Order();
                    foreach(string item in emails)
                    {
                        Console.WriteLine(item);
                    }

                    var sum_salary = employees.Where(x => x.Name[0] == 'M').Select(x => x.Salary).DefaultIfEmpty(0.0).Sum();
                    Console.WriteLine("Sum of salary of people whose name starts with 'M': " + sum_salary.ToString("F2", System.Globalization.CultureInfo.InvariantCulture));

                }

            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
