using System.Net.Http.Headers;

namespace Heranca
{
    public class Veiculo // Classe Base
    {
        private int rodas;
        public int velMax;
        private bool ligado;

        public Veiculo(int rodas)
        {
            this.rodas = rodas;
        }

        public void Ligar()
        {
            ligado = true;
        }

        public void Desligar()
        {
            ligado = false;
        }

        public string GetLigado()
        {
            // utilizacao do operador ternario '?' (forma simples do if)
            // 'condicao_analise' ? condicao_verdadeira : condicao_falsa
            return (ligado ? "Ligado" : "Desligado");
        }

        public string SetLigado(int n)
        {
            if (n == 1)
            {
                Ligar();
            }
            else
            {
                Desligar();
            }

            return GetLigado();

        }

        public int GetRodas()
        {
            return rodas;
        }

        public void SetRodas(int rodas)
        {
            if (rodas < 0)
            {
                this.rodas = 0;
            }
            else if (rodas > 40)
            {
                this.rodas = 40;
            }
            else
            {
                this.rodas = rodas;
            }
        }
    }

    // Heranca: uma classe vai herdar/receber todas as informacoes, propriedades e metodos da outra classe (classe pai/base)
    // Classe_Filho : Classe_Pai
    // 'Classe_Filho' herdou tudo da 'Classe_Pai'
    public class Carro : Veiculo // Classe Derivada
    {
        public string nome;
        public string cor;

        // para realizar metodos de construcao de classes pai/base em classes filhos nos precisamos colocar ':base()' no final do metodo construtor da classe filho
        // nesse caso abaixo nos usamos essa forma pois a propriedade rodas da classe 'Veiculo' eh privada e precisamos chamar o metodo de construcao da classe 'Veiculo' junto com o da classe 'Carro' para obter a informacao para a propriedade rodas
        public Carro(string nome, string cor):base(4)
        {
            Desligar();
            velMax = 120;
            this.nome = nome;
            this.cor = cor;
        }
    }

    // Cadeira de heranca: 'CarroCombate' herda 'Carro' que herda 'Veiculo'
    // CarroCombate eh uma heranca de carro
    // nesse caso CarroCombate eh filho e Carro eh pai
    public class CarroCombate : Carro
    {
        public int municao;

        // para efetuar o metodo construtivo de 'CarroCombate' devemos tambem chamar o metodo constutivo de 'Carro' ja que essa classe eh Pai/Base da 'CarroCombate'
        public CarroCombate():base("Carro de Combate", "verde")
        {
            municao = 100;
            SetRodas(6);
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Carro c1 = new Carro("Marea", "Amarelo");
            CarroCombate cc1 = new CarroCombate();

            Console.WriteLine("Nome do carro...: {0}", c1.nome);
            Console.WriteLine("Cor do carro....: {0}", c1.cor);
            // precisamos usar o metodo 'GetRodas()' pois a propriedade rodas eh 'private'
            Console.WriteLine("Qtde de rodas...: {0}", c1.GetRodas());
            Console.WriteLine("Velociade Maxima: {0}", c1.velMax);
            Console.WriteLine("Carro {0}\n", c1.GetLigado());

            Console.Write("Digite 1 para ligar e 0 para desligar: ");
            int escolha = int.Parse(Console.ReadLine());
            Console.WriteLine("Carro {0}\n", c1.SetLigado(escolha));

            Console.WriteLine("--------------------------\n");
            Console.WriteLine("Nome do carro...: {0}", cc1.nome);
            Console.WriteLine("Cor do carro....: {0}", cc1.cor);
            Console.WriteLine("Qtde de rodas...: {0}", cc1.GetRodas());
            Console.WriteLine("Velociade Maxima: {0}", cc1.velMax);
            Console.WriteLine("Carro {0}", cc1.GetLigado());
            Console.WriteLine("Municao.........: {0}\n", cc1.municao);
           

        }
    }
}
