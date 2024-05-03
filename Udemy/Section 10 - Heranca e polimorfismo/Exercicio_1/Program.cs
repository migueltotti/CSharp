using Exercicio_1.Entities;

namespace Exercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            int number_employees;

            // Data employees:
            string outsorced;
            string name;
            int hours;
            double valuehour;

            double addcharge;

            Console.Write("Enter the number of employees: ");
            number_employees = int.Parse(Console.ReadLine());

            for(int i = 1; i <= number_employees; i++)
            {
                Console.WriteLine($"Employee #{i} data:");

                Console.Write("Outsourced (y/n)? ");
                outsorced = Console.ReadLine();

                Console.Write("Name: ");
                name = Console.ReadLine();

                Console.Write("Hours: ");
                hours = int.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                valuehour = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);

                if (outsorced == "y")
                {
                    Console.Write("Additional charge: ");
                    addcharge = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);

                    employees.Add(new OutsourceEmployee(name, hours, valuehour, addcharge));
                }
                else
                {
                    employees.Add(new Employee(name, hours, valuehour));
                }

            }

            Console.WriteLine("\nPAYMENTS:");

            foreach(Employee items in employees)
            {
                Console.WriteLine(items.Name + " - $ " + items.Payment().ToString("F2", System.Globalization.CultureInfo.InvariantCulture));
            }
        }
    }
}
