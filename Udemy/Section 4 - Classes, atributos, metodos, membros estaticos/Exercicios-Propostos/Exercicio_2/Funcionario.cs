using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_2
{
    internal class Funcionario
    {
        public string nome;
        public double salario_bruto;
        public double imposto;

        public double SalarioLiquido()
        {
            return salario_bruto - imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            salario_bruto = (salario_bruto * (porcentagem/100)) + salario_bruto;
        }

        public override string ToString()
        {
            return nome + ", $" + SalarioLiquido();
        }
    }
}
