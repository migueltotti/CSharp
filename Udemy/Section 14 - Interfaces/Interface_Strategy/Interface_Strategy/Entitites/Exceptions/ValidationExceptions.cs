using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Strategy.Entitites.Exceptions
{
    internal class ValidationExceptions : ApplicationException
    {
        public ValidationExceptions(string message) : base(message)
        {
        }
    }
}
