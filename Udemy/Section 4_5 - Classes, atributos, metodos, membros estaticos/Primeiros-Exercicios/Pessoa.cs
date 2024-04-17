using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primeiros_Exercicios
{
    internal class Pessoa
    {
        public string nome = string.Empty;
        public int idade = 0;

        public static void VerificarMaisVelho(Pessoa p1, Pessoa p2)
        {
            if(p1.idade > p2.idade)
            {
                Console.WriteLine($"Pessoa mais velha: {p1.nome}");
            }
            else
            {
                Console.WriteLine($"Pessoa mais velha: {p2.nome}");
            }
        }
    }
}
