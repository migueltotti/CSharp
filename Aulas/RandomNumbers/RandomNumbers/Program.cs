using System;

namespace RandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int x = random.Next(1, 7); // 1 ate 6
            // vai gerar um valor inteiro aleatorio entre 0 e coisa pra kct kkk
            // colocar dois valores dentro dos parenteses vai limitar o intervalo de valores aleatorios
            double y = random.NextDouble();
            // vai gerar um valor double aleatorio entre 0 e 1

            Console.WriteLine(x);
            Console.WriteLine(y);
        }
    }
}
