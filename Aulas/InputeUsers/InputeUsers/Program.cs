using System;
using System.Collections.Specialized;

namespace InputeUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu nome e um valor: ");

            string a = Console.ReadLine();
            int b = Convert.ToInt32(Console.ReadLine());
            // a funcao Console.ReadLine(); recebe uma string digitada pelo usuario
            // logo precisamos converter 'string' para 'int' para que a variavel 'a' receba o valor numero digitado

            Console.WriteLine("O nome digitado pelo User foi: " + a);
            Console.WriteLine("O numero digitado pelo User foi: " + b);

        }   
    }
}
