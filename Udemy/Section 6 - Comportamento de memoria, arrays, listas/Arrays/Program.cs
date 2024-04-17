
namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Array de structs

            /*int n = int.Parse(Console.ReadLine());

            double[] alturas = new double[n];
            double soma = 0;

            for(int i = 0; i < n; i++)
            {
                alturas[i] = double.Parse(Console.ReadLine());
                soma += alturas[i];
            }

            //Console.WriteLine($"Media das alturas: {soma/n}");
            Console.WriteLine("Media das alturas: " + (soma/n).ToString("F2"));*/

            // Array de Objetos

            int n = int.Parse(Console.ReadLine());

            Product[] array = new Product[n];
            double soma_precos = 0;

            // para utilizar array de objetos eh preciso instanciar cada uma das posicoes do vetor
            // quando isntanciado o array seram gerados apeas 'variaveis' da classe, e depois temos q instanciar cada varaivel

            string nome;
            double preco;

            for (int i = 0; i < n; i++)
            {
                nome = Console.ReadLine();
                preco = double.Parse(Console.ReadLine());

                // instanciando um objeto com os valores nome e preco para a posicao i do vetor
                array[i] = new Product { Nome = nome , Preco = preco };

                soma_precos += array[i].Preco;
            }

            Console.WriteLine("Media dos precos: " + (soma_precos/n).ToString("F2"));
        }
    }
}
