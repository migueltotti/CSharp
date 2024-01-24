namespace Membros_Protected
{
    // membros 'protected' - sao como membros 'private' com o diferencial de serem visiveis por classes filho
    // classes que herdam a classe Veiculo tem acesso a propriedade ligado
    // diferente das propriedades private que so tem acesso a aquela classe e mais nenhuma 
    public class Veiculo // classe - base
    {
        public int velAtual;
        private int velMax;
        protected bool ligado;

        public Veiculo(int velMax)
        {
            velAtual = 0;
            this.velMax = velMax;
            ligado = false;
        }

        public bool GetLigado()
        {
            return ligado;
        }

        public int GetVelMax()
        {
            return velMax;
        }
    }

    public class Carro : Veiculo
    {
        public string nome;
        // para inserir um valor recebido pelo user no metodo construtor da classe base basta criar um outro parametro no metodo construtor da classe filho e colocar depois como parametro do ':base(nome_variavel)'
        public Carro(string nome, int vM) : base(vM)
        {
            this.nome = nome;
            ligado = true;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro("Civic", 210);

            Console.WriteLine("Nome: {0}", carro.nome);
            Console.WriteLine("VelMAx: {0}", carro.GetVelMax());
            Console.WriteLine("Ligado: {0}", carro.GetLigado());

        }
    }
}
