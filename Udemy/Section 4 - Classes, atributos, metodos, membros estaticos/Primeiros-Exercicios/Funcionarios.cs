using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primeiros_Exercicios
{
    internal class Funcionario
    {
        public string nome = String.Empty;
        public float salario = 0f;


        public static void SalarioMedio(Funcionario f1, Funcionario f2)
        {
            float media = (float)(f1.salario + f2.salario) / 2;

            Console.WriteLine("Salario medio: " + media.ToString("F2"));
        }
    }
}
