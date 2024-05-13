using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Interface_Strategy.Entitites
{
    internal class User
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public double Salary { get; private set; }

        public User(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public override string ToString()
        {
            return "Id: " + Id.ToString()
                + "Name: " + Name
                + "Salary: " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
