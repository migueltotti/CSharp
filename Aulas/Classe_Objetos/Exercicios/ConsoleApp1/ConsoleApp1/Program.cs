namespace ConsoleApp1
{
    class Retangulo
    {
        public int altura;
        public int largura;

        public Retangulo(int altura, int largura)
        {
            this.altura = altura;
            this.largura = largura;
        }

        public void Mostrar()
        {
            Console.WriteLine("Altura: {0}\nLargura: {1}", altura, largura);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // vetor de objetos
            Retangulo[] vetor = new Retangulo[3];

            for(int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine("Retangulo {0}", i+1);
                vetor[i] = LeRetangulo();
            }

            Console.WriteLine("-----------------------\n");

            for(int i = 0;i < vetor.Length; i++)
            {
                Console.WriteLine("Retangulo {0}", i + 1);
                vetor[i].Mostrar();
            }
        }

        public static Retangulo LeRetangulo()
        {
            Retangulo r;
            int altura, largura;

            Console.Write("Digite o valor da altura: ");
            altura = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor da largura: ");
            largura = int.Parse(Console.ReadLine());

            r = new Retangulo(altura, largura);

            return r;
        }
    }
}
