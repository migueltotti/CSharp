using Exercicio_1.Entities;
using Exercicio_1.Entities.Enums;
using System.Globalization;

namespace Exercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Worker worker;
            string dptoname;
            string wkrname;
            string wkrlevel;
            double basesalary;
            int num_contracts;

            DateTime date;
            double value_hour;
            int hour;

            //string[] date_income;
            string monthAndYear;
            int year;
            int month;

            Console.Write("Enter department's name: ");
            dptoname = Console.ReadLine();

            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            wkrname = Console.ReadLine();

            Console.Write("Level (Junior/MidLevel/Senior): ");
            wkrlevel = Console.ReadLine();

            Console.Write("Base salary: ");
            basesalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            worker = new Worker()
            {
                Name = wkrname,
                Level = Enum.Parse<WorkerLevel>(wkrlevel),
                BaseSalary = basesalary,
                Department = new Department(dptoname)
            };

            Console.Write("How many contracts to this worker? ");
            num_contracts = int.Parse(Console.ReadLine());

            for(int i = 0; i < num_contracts; i++)
            {
                Console.WriteLine("Enter #" + (i + 1) + " contract data:");
                Console.Write("Date (DD/MM/YYYY): ");
                date = DateTime.Parse(Console.ReadLine());

                Console.Write("Valeu per hour: ");
                value_hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Duration (hours): ");
                hour = int.Parse(Console.ReadLine());

                worker.AddContract(new HourContract()
                {
                    Date = date,
                    ValeuPerHour = value_hour,
                    Hours = hour
                });
            }

            Console.Write("\nEnter month and year to calculate income (MM/YYYY): ");
            //date_income = Console.ReadLine().Split("/");
            monthAndYear = Console.ReadLine();
            month = int.Parse(monthAndYear.Substring(0, 2));
            year = int.Parse(monthAndYear.Substring(3, 4));

            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Department: " + worker.Department.Name);
            //Console.WriteLine("Income for {0}/{1}: {3}", date_income[0], date_income[1], worker.Income(int.Parse(date_income[1]), int.Parse(date_income[0])).ToString("F2"));
            Console.WriteLine("Income for {0}: {1}", monthAndYear, worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
