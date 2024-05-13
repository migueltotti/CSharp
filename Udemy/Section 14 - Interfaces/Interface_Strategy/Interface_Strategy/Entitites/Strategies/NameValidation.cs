using Interface_Strategy.Entitites.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Strategy.Entitites.Strategies
{
    internal class NameValidation : NewUserValidation
    {
        public void validation(User u)
        {
            if (u.Name.Length <= 0 || u.Name.Length > 8)
            {
                throw new ValidationExceptions("Name does not match the format! ( 0 <= name <= 8");
            }
        }

    }
}
