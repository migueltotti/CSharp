using Heranca.Entities;

namespace Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*BusinessAccount account = new BusinessAccount(1080, "Bob Brown", 100.0, 500);

            Console.WriteLine(account.Balance);

            // Erro pois seu modificador de acesso 'protected' permite a alteracao do valor apenas para classes do mesmo namespace
            //account.Balance = 200;*/

            Account acc = new Account(1001, "Alex", 0.00);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.00, 500);

            // UPCASTING

            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Bob", 0.00, 200);
            Account acc3 = new SavingsAccount(1004, "Ana", 0.00, 0.01);

            // DOWCASTING - Casting Perigoso!!

            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100.0);
            //acc2.Loan ??? nao existem, pois acc2 eh Account e nao BusinesAccount 

            //BusinessAccount acc5 = (BusinessAccount)acc3;
            // o compilador nao apresenta erro ao fazer um casting de uma subclasse para outra da mesma Superclasse, porem o erro acontece quando o programa rodar!!
            // para solucionar esse problema precisamos usar a palavra 'is'
            if(acc3 is BusinessAccount)
            {
                BusinessAccount acc5 = (BusinessAccount)acc3;
                acc5.Loan(200);
                Console.WriteLine("Loan!");
            }

            if(acc3 is SavingsAccount)
            {
                SavingsAccount acc5 = (SavingsAccount)acc3;
                acc5.UpdateBalance();
                Console.WriteLine("Update!");
            }
        }
    }
}
