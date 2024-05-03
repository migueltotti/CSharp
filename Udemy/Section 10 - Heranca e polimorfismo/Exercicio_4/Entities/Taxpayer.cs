using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_4.Entities
{
    internal abstract class Taxpayer
    {
        public string Name { get; set; }
        public double Income { get; set; }  

        public Taxpayer()
        {
        }

        protected Taxpayer(string name, double income)
        {
            Name = name;
            Income = income;
        }

        public abstract double Tax();

        public override string ToString()
        {
            return Name + ": $ " + Tax().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
