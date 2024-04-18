using System.Collections.Generic;

namespace Exercico_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            int num_employees = 0, id_employee = 0;
            double percent_incrise = 0.00;
            Employee? emp;
            // ? permite que emp seja nulo

            // variables for class Employees
            int id;
            string name;
            double salary;

            Console.Write("How many employees will be registered? ");
            num_employees = int.Parse(Console.ReadLine());

            for(int i = 0; i < num_employees; i++)
            {
                Console.WriteLine("Employee #" + (i+1));

                Console.Write("Id: ");
                id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                name = Console.ReadLine();
                Console.Write("Salary: ");
                salary = double.Parse(Console.ReadLine());

                list.Add(new Employee { 
                    Id = id, 
                    Name = name, 
                    Salary = salary 
                });

                Console.WriteLine();
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            id_employee = int.Parse(Console.ReadLine());

            emp = list.Find(x => x.Id == id_employee);

            if(emp != null)
            {
                Console.Write("Enter the percentage: ");
                percent_incrise = double.Parse(Console.ReadLine());

                emp.IncreaseSalary(percent_incrise);
            }
            else
            {
                Console.WriteLine("This id doesnt exist!");
            }

            Console.WriteLine("");

            Console.WriteLine("Updated list of employees:");

            foreach(Employee item in list)
            {
                Console.WriteLine(item);
            }



        }
    }
}
