using Exercicio_1.Entitites;
using Exercicio_1.Entitites.Exceptions;
using System.Globalization;

namespace Exercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc;

            // account data:
            int number;
            string name;
            double initial_balance;
            double withdraw_limit;

            double amount;

            try
            {
                Console.WriteLine("Enter accout data:");

                Console.Write("Number: ");
                number = int.Parse(Console.ReadLine());

                Console.Write("Holder: ");
                name = Console.ReadLine();

                Console.Write("Inicial balance: ");
                initial_balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Withdraw limit: ");
                withdraw_limit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                acc = new Account(number, name, initial_balance, withdraw_limit);

                Console.Write("\nEnter amount for withdraw: ");
                amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                acc.Withdraw(amount);

                Console.WriteLine("New balance: " + acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch (DomainException e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }
        }
    }
}
