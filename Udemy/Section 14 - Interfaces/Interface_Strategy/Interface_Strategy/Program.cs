using Interface_Strategy.Entitites;
using Interface_Strategy.Entitites.Exceptions;
using Interface_Strategy.Entitites.Services;
using System.Globalization;

namespace Interface_Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User newuser;
            Validation validation = new Validation();

            // users data
            string id;
            string name;
            string salary;

            try
            {
                Console.WriteLine("Enter user's data: ");

                Console.Write("id: ");
                id = Console.ReadLine();

                Console.Write("name: ");
                name = Console.ReadLine();

                Console.Write("salary: ");
                salary = Console.ReadLine();

                newuser = validation.validation(new User(int.Parse(id), name, double.Parse(salary)));

                Console.WriteLine(newuser);
            }
            catch (ValidationExceptions ex)
            {
                Console.WriteLine("\n An error occured!");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
