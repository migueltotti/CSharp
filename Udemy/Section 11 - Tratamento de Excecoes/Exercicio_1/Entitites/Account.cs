using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using Exercicio_1.Entitites.Exceptions;

namespace Exercicio_1.Entitites
{
    internal class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; private set; }
        public double WithdrawLimit { get; set; }

        public Account() { }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if(WithdrawLimit < amount)
            {
                // exception
                throw new DomainException("The amount exceeds the withdraw limit");
            }
            if (Balance < amount || Balance <= 0)
            {
                // exception
                throw new DomainException("Not enough balance");
            }

            Balance -= amount;
        }
    }
}
