using System.Globalization;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preco: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            int qtde = int.Parse(Console.ReadLine());

            Produto p2 = new Produto(nome, preco, qtde);

            p2.= nome;

            //Produto p = new Produto(nome, preco);

            Produto p2 = new Produto {
                nome = "TV",
                preco = 600.00,
                qtde = 9
            }; 

            Console.WriteLine("\nDados do produto: " + p2 + "\n");

            Console.Write("Digite o numero de produtos a ser adicionado ao estoque: ");
            qtde = int.Parse(Console.ReadLine());
            p2.AdicionarProdutos(qtde);

            Console.WriteLine("\nDados atualizados: " + p2 + "\n");

            Console.Write("Digite o numero de produtos a ser removidos ao estoque: ");
            qtde = int.Parse(Console.ReadLine());
            p2.RemoverProdutos(qtde);

            Console.WriteLine("\nDados atualizados: " + p2 + "\n");
            */

            Produto p3 = new Produto("Tv", 400, 5);

            p3.nome = "CGFSW";

            Console.WriteLine(p3.nome);
            Console.WriteLine(p3.preco);
            Console.WriteLine(p3.quantidade);
        }
    }
}
