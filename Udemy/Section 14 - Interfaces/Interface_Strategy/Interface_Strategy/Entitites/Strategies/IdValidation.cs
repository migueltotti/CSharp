using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interface_Strategy.Entitites.Exceptions;

namespace Interface_Strategy.Entitites.Strategies
{
    internal class IdValidation : NewUserValidation
    {
        public void validation(User u)
        {

            if(u.Id <= 0 || u.Id > 9999)
            {
                //Console.WriteLine("Id does not match the format! (0001 - 9999)");
                //return;
                throw new ValidationExceptions("Id does not match the format! (0001 - 9999)");
            }
        }
    }
}
