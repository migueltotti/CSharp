using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_resolvido_1.Entities
{
    internal class User
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }

        public User(string name, DateTime date)
        {
            Name = name;
            Date = date;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if (!(obj is User))
            {
                return false;
            }

            User other = obj as User;

            return Name.Equals(other.Name);
        }
    }
}
