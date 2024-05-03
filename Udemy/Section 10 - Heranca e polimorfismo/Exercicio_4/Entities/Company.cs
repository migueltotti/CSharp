using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio_4.Entities
{
    internal class Company : Taxpayer
    {
        public int NumberOfEmployees { get; set; }  

        public Company() { }

        public Company(int numberemployees, string name, double income) : base(name, income)
        {
            NumberOfEmployees = numberemployees;
        }

        public override double Tax()
        {
            double tax;

            if(NumberOfEmployees > 10)
            {
                tax = Income * 0.14;
            }
            else
            {
                tax = Income * 0.16;
            }

            return tax;
        }
    }
}
