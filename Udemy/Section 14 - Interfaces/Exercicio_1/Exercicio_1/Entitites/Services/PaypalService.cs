using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1.Entitites.Services
{
    internal class PaypalService : OnlinePaymentService
    {
        public double paymentFee(double amount)
        {
            return (amount * 0.02) + amount;
        }
        public double interest(double amount, int month)
        {
            return ((amount * 0.01) * month) + amount;
        }
    }
}
