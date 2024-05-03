using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_4.Entities
{
    internal class Individual : Taxpayer
    {
        public double HealthSpending { get; set; }  

        public Individual() { }

        public Individual(double healthspending, string name, double income) : base(name, income)
        {
            HealthSpending = healthspending;
        }

        public override double Tax()
        {
            double tax = 0;

            if (Income < 20000.00)
            {
                if (HealthSpending > 0)
                {
                    tax = (Income * 0.15) - (HealthSpending * 0.5);
                }
                else
                {
                    tax = Income * 0.15;
                }
            }
            else
            {
                if (HealthSpending > 0)
                {
                    tax = (Income * 0.25) - (HealthSpending * 0.5);
                }
                else
                {
                    tax = Income * 0.25;
                }
            }

            return tax;
        }
    }
}
