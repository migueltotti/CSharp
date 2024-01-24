namespace Construtores_e_Destrutores
{

    public class Jogador
    {
        public int energia;
        public bool vivo;
        public string nome;

        // Metodo Construtor: inicializa o objeto quando instanciado da classe
        // sempre que um novo objeto eh criado/instanciado esse metodo eh chamado para inicializar as propriedades
        // podemos criar mais de um metodo construtor dependendo da quantidade de argumentos (parametros) de entrada para a instanciacao do objeto

        // Metodo Construtor deve ter o MESMO NOME DA CLASSE

        public Jogador()
        {
            energia = 100;
            vivo = true;
            nome = "Jogador";
        }
        public Jogador(string n)
        {
            energia = 100;
            vivo = true;
            nome = n;
        }
        public Jogador(string n, int e)
        {
            energia = e;
            vivo = true;
            nome = n;
        }
        public Jogador(string n, int e, bool v)
        {
            energia = e;
            vivo = v;
            nome = n;
        }
        // cada metodo construtor aui possuem argumentos diferentes de entrada, cada opcao de uso dos argumentos na hora da instanciacao gera um resultado diferente

        // Metodo Destrutor: vai ser chamado sempre que um objeto da classe for destruido, deletado
        // deve ter o MESMO NOME DA CLASSE e deve ser antecedido por um '~'(tio)

        public void info()
        {
            // metodo para mostrar as informacoes dos objetos
            Console.WriteLine("Nome Jogador...: {0}", nome);
            Console.WriteLine("Energia Jogador: {0}", energia);
            Console.WriteLine("Vivo Jogador...: {0}\n", vivo);
        }

        ~Jogador()
        {
            Console.WriteLine("Jogador {0} foi destruido!", nome);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;

            Console.Write("Digite o nome do jogador 1: ");
            nome = Console.ReadLine();

            Jogador j1 = new Jogador();
            Jogador j2 = new Jogador(nome);
            Jogador j3 = new Jogador("Isadora", 30);
            Jogador j4 = new Jogador("Bruno", 10, false);

            //j1.energia = 50;
            //Console.WriteLine("Energia do jogador 1: {0}", j1.energia);
            //Console.WriteLine("Nome: {0}", j1.nome);
            //Console.WriteLine("Energia do jogador 2: {0}", j2.energia);
            //Console.WriteLine("Nome: {0}", j2.nome);

            j1.info();
            j2.info();
            j3.info();
            j4.info();

        }
    }
}
