using Interface_Strategy.Entitites.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Interface_Strategy.Entitites.Strategies
{
    internal class SalaryValidation : NewUserValidation
    {
        public void validation(User u)
        {
            if (u.Salary <= 0)
            {
                throw new ValidationExceptions("Salary cannot be negative! ( 0 <= salary )");
            }
        }
    }
}
