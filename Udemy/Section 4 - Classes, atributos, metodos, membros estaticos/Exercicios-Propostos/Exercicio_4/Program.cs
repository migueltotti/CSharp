using System.Globalization;

namespace Exercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual eh a cotacao do dolar? ");
            double cotacao = double.Parse(Console.ReadLine());
            Console.Write("Quantos dolares voce vai comprar? ");
            double qtde = double.Parse(Console.ReadLine());

            Console.WriteLine("Valor a ser pago em reais = " + ConversorDeMoeda.Conversao(cotacao, qtde).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
