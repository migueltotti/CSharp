namespace Heranca.Entities
{
    internal class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }

        public BusinessAccount() 
        {
        }

        public BusinessAccount(int number, string holder, double balance, double loanlimit) : base(number, holder, balance)
        {
            LoanLimit = loanlimit;
        }

        public override void Withdraw(double amount)
        {
            base.Withdraw(amount);
            Balance -= 2;
        }

        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }
        }
    }
}
