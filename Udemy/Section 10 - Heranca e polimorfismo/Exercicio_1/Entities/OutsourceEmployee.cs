using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1.Entities
{
    internal class OutsourceEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsourceEmployee()
        {
        }
        public OutsourceEmployee(string name, int hours, double valuePerHour, double additionalcharge) : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalcharge;
        }

        public override double Payment()
        {
            return base.Payment() + (AdditionalCharge * 1.1);
        }
    }
}
