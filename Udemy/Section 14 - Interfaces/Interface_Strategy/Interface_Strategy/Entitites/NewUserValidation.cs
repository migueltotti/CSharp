using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interface_Strategy.Entitites.Exceptions;

namespace Interface_Strategy.Entitites
{
    internal interface NewUserValidation
    {
        public void validation(User source);
    }
}
