using System.Globalization;

namespace Exercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numConta = 0;
            string NomeTitular = string.Empty;
            double DepositoInicial = 0.00;
            //string escolhaDepositoInicial = "";

            Console.Write("Entre com o numero da conta: ");
            numConta = int.Parse(Console.ReadLine());
            Console.Write("Entre com o titular da conta: ");
            NomeTitular = Console.ReadLine();
            Console.Write("Havera deposito inicial (s/n): ");
            if(Console.ReadLine() == "s")
            {
                Console.Write("Entre o valor do deposito inicial: ");
                DepositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            ContaBancaria Conta1 = new ContaBancaria(numConta, NomeTitular, DepositoInicial);

            Console.WriteLine("\nDados da conta:");
            Console.WriteLine(Conta1);

            Console.Write("\nEntre com um valor pra deposito: ");
            Conta1.Deposito(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(Conta1);

            Console.Write("\nEntre com um valor pra saque: ");
            Conta1.Saque(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(Conta1);
        }
    }
}
