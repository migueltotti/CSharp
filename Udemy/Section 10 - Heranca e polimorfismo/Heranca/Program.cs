using Heranca.Entities;
using System.Collections.Generic;

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

            /*
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
                //BusinessAccount acc5 = (BusinessAccount)acc3;
                BusinessAccount acc5 = acc3 as BusinessAccount;
                acc5.Loan(200);
                Console.WriteLine("Loan!");
            }

            if(acc3 is SavingsAccount)
            {
                //SavingsAccount acc5 = (SavingsAccount)acc3;
                SavingsAccount acc5 = acc3 as SavingsAccount;
                acc5.UpdateBalance();
                Console.WriteLine("Update!");
            }
            

            // Sobreposicao de metodos
            Account acc1 = new Account(1001, "Alex", 500);
            Account acc2 = new SavingsAccount(1002, "Isadora", 500, 0.01);
            Account acc3 = new BusinessAccount(1003, "Miguel", 500, 100);

            acc1.Withdraw(10); // desconta mais 5 
            acc2.Withdraw(10); // nao desconta 5
            acc3.Withdraw(10); // desconta os 5 da superclasse mais 2 reais da propria subclasse

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);
            Console.WriteLine(acc3.Balance);
            */

            List<Account> list = new List<Account>();

            list.Add(new SavingsAccount(1001, "Miguel", 500, 0.01));
            list.Add(new BusinessAccount(1002, "Isadora", 500, 400));
            list.Add(new SavingsAccount(1003, "Frank", 500, 0.01));
            list.Add(new BusinessAccount(1004, "Kiki", 500, 500));

            double sum = 0.0;

            foreach (Account items in list)
            {
                sum += items.Balance;
            }

            Console.WriteLine("Total balance: " + sum);

            foreach (Account items in list)
            {
                items.Withdraw(10);

                Console.WriteLine("Updated balance for account " 
                    + items.Number
                    + ": "
                    + items.Balance
                    );
            }
        }
    }
}
