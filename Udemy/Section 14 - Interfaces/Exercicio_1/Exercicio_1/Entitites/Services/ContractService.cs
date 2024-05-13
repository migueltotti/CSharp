using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1.Entitites.Services
{
    internal class ContractService
    {
        public OnlinePaymentService PaymentService { get; set; }

        public ContractService(OnlinePaymentService paymentService)
        {
            PaymentService = paymentService;
        }

        public void processContract(Contract contract, int months)
        {
            contract.Installments = new List<Installment>();
            DateTime date = contract.Date;
            double interest;
            double paymentfee;
            double amount_per_month = contract.TotalValue / months;

            for (int i = 1; i <= months; i++)
            {
                interest = PaymentService.interest(amount_per_month, i);
                paymentfee = PaymentService.paymentFee(interest);

                date = date.AddMonths(1);

                contract.Installments.Add(new Installment(date, paymentfee));
            }
        }
    }
}
