using System;

namespace OperadoresAritimeticos
{
    class Program
    {
        static void Main(string[] args)
        {

            // Operacoes aritimeticas

            double num = 1;

            num++; // num = num + 1; == 2
            num--; // num = num - 1; == 1
            num += 2; // num = num + 2; == 3
            num *= 2; // num = num * 2; == 6
            num /= 2; // num = num / 2; == 3

            Console.WriteLine(num);

            // Metodos Matematicos

            double x = 3.14;
            double y = 5;

            double a = Math.Pow(x, 3); // exponeciacao
            double b = Math.Sqrt(x); // Raiz Quadrada
            double c = Math.Abs(x); // Valor Absoluto (modulo)
            double d = Math.Round(x); // Arredonda o valor para o mais proximo
            double e = Math.Ceiling(x); // Arredonda para cima o valor
            double f = Math.Floor(x); // Arredonda para baixo o valor
            double g = Math.Max(x, y); // Armazena o maior dos dois valores
            double h = Math.Min(x, y); // Armazena o menor dos dois valores

            Console.WriteLine(h);
        }
    }
}
