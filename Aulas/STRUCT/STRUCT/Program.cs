namespace STRUCT
{
    // Struct: tipo de dado abstrato, permite o armazenamento de diferentes tipos de dados
    // struct eh tratada com valeu e a classe como referencia, isso quer dizer q os membros da struct sao acessados diretamente enquanto os membros da classe sao acessador por referencia
    // structs nao podem ser herdadas ou herdar
    // structs podem ter construtores
    // utilizar STRUCT quando precisamos resolver coisas mais simples
    struct Carro
    {
        public string marca;
        public string modelo;
        public string cor;

        public Carro(string marca, string modelo, string cor) // construtor
        {
            this.marca = marca;
            this.modelo = modelo;
            this.cor = cor;
        }

        public void Info()
        {
            Console.WriteLine("Marca.: {0}", this.marca);
            Console.WriteLine("Modelo: {0}", this.modelo);
            Console.WriteLine("Cor...: {0}\n", this.cor);
            Console.WriteLine("-----------------------");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Carro c1, c2; // inicializando a strutura carro sem o construtor

            c1.marca = "Mitsubish";
            c1.modelo = "Evo";
            c1.cor = "Roxo";

            c2 = new Carro("Honda", "Civic", "Azul Escuro"); // inicializando o construtor da estrutura carro

            //c1.Info();
            //c2.Info();

            // Array de Structs
            Carro[] carros = new Carro[3];
            
            // inserindo valores dentros das posicoes do array da Struct Carro
            for(int i = 0; i < carros.Length; i++)
            {
                Console.WriteLine("Carro {0}", i+1);
                Console.Write("Marca: ");
                carros[i].marca = Console.ReadLine();
                Console.Write("Modelo: ");
                carros[i].modelo = Console.ReadLine();
                Console.Write("Cor: ");
                carros[i].cor = Console.ReadLine();

                Console.WriteLine("Carro adicionado!\n");
            }

            Console.WriteLine("-----------------------");

            for (int i = 0;i < carros.Length;i++)
            {
                carros[i].Info();
            }
        }
    }
}
