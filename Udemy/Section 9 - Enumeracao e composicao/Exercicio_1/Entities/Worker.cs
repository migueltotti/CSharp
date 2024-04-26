using Exercicio_1.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1.Entities
{
    internal class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        
        // cada trabalhador esta ligado a um departamento
        public Department Department { get; set; }  

        // cada trabalhador pode ter varios contratos
        // vamos instanciar a lista para q ela n seja nula ao instanciar um objeto Worker
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker()
        {
        }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double total = BaseSalary;

            foreach (HourContract contract in Contracts)
            {
                if(contract.Date.Month == month && contract.Date.Year == year)
                {
                    total += contract.TotalValue();
                }
            }

            return total;
        }
    }
}
