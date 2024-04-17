using System;

namespace Primeiros_Exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Exercicio 1:
             * 
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa: ");

            Console.Write("Nome: ");
            p1.nome = Console.ReadLine();
            Console.Write("Idade: ");
            p1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa: ");

            Console.Write("Nome: ");
            p2.nome = Console.ReadLine();
            Console.Write("Idade: ");
            p2.idade = int.Parse(Console.ReadLine());

            Pessoa.VerificarMaisVelho(p1, p2);
            */

            Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionario: ");

            Console.Write("Nome: ");
            f1.nome = Console.ReadLine();
            Console.Write("Salario: ");
            f1.salario = float.Parse(Console.ReadLine());

            Console.WriteLine("Dados do segundo funcionario: ");

            Console.Write("Nome: ");
            f2.nome = Console.ReadLine();
            Console.Write("Salario: ");
            f2.salario = float.Parse(Console.ReadLine());

            Funcionario.SalarioMedio(f1, f2);
        }
    }
}
