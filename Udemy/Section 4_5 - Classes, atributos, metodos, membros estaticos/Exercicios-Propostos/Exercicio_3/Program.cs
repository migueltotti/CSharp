using System.Globalization;

namespace Exercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno();

            Console.Write("Nome do aluno: ");
            a.nome = Console.ReadLine();
            Console.WriteLine("Digite as tres notas do aluno: ");
            a.nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("NOTA FINAL = " + a.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));

            if (a.NotaFinal() >= 60)
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM " + (Math.Abs(a.NotaFinal() - 60)).ToString("F2", CultureInfo.InvariantCulture) + " PONTOS");
            }
        }
    }
}
