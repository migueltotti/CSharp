using Exercicio_1.Entitites;
using Exercicio_1.Entitites.Services;

namespace Exercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // contract data
            Contract contract;

            int number;
            DateTime date;
            double value;
            int months;

            // PaymentService
            ContractService contractService = new ContractService(new PaypalService());

            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            number = int.Parse(Console.ReadLine());

            Console.Write("Date (dd/MM/yyyy): ");
            date = DateTime.Parse(Console.ReadLine());

            Console.Write("Contract value: ");
            value = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);

            Console.Write("Enter number of installments: ");
            months = int.Parse(Console.ReadLine());

            contract = new Contract(number, date, value);
            contractService.processContract(contract, months);

            Console.WriteLine("Installments:");
            foreach(Installment installment in contract.Installments)
            {
                Console.WriteLine(installment);
            }
        }
    }
}
