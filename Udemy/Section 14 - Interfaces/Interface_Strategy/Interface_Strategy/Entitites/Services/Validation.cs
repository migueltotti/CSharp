using Interface_Strategy.Entitites.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Strategy.Entitites.Services
{
    internal class Validation
    {
        public List<NewUserValidation> UserValidations { get; private set; }

        public Validation() 
        {
            UserValidations = new List<NewUserValidation>();
            UserValidations.Add(new IdValidation());
            UserValidations.Add(new NameValidation());
            UserValidations.Add(new SalaryValidation());
        }

        public Validation(List<NewUserValidation> userValidations)
        {
            UserValidations = userValidations;
        }

        public User validation(User u)
        {
            UserValidations.ForEach(v => v.validation(u));

            return u;
        }
    }
}
