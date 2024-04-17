namespace Exercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();

            Console.Write("Nome: ");
            f.nome = Console.ReadLine();
            Console.Write("Salario bruto: ");
            f.salario_bruto = double.Parse(Console.ReadLine());
            Console.Write("Imposto: ");
            f.imposto = double.Parse(Console.ReadLine());

            Console.WriteLine("\nFuncionario: " + f);

            Console.Write("\nDigite a porcentagem para aumentar o salario: ");
            double porcentagem = double.Parse(Console.ReadLine());
            f.AumentarSalario(porcentagem);

            Console.WriteLine("\nDados atualizados: " + f);
        }
    }
}
