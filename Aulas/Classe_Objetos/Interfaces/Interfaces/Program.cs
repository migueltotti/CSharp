namespace Interfaces
{
    // Interfaces: apenas implementam metodos/ protopitos dos metodos
    // classes podem usar (herdar) mais de uma interface
    // e as classes devem obrigatoriamente implementar membros de interfaces herdadas, semelhante a classe abstract com membros abstract
    // nao podem ter construtores ou destrutores, n pode definir membros static nem definir propriedades (variaves)
    public interface Veiculo
    {
        void Ligar();
        void Desligar();
        void Info();
    }

    public interface Combate
    {
        void Disparar(int qtde);
    }

    class Carro : Veiculo, Combate // carro esta usando as interfaces Veiculo e Combate, e obrigatoriamente necessitamos implementar os metodos das interfaces usadas
    {
        public string cor;
        public bool ligado;
        public int municao;
        public Carro() { }

        public Carro(string cor) 
        {
            this.municao = 100;
            this.cor = cor;
        }

        public void Ligar()
        {
            this.ligado = true;
        }

        public void Desligar()
        {
            this.ligado = false;
        }

        // metodos de interfaces usadas devem ser obrigatoriamente implementados com o mesmo nome e os mesmos paramentros
        public void Disparar(int qtde)
        {
            this.municao -= qtde;
        }

        public void Info() 
        {
            Console.WriteLine("Carro ligado.....: {0}", this.ligado);
            Console.WriteLine("Cor do carro.....: {0}", this.cor);
            Console.WriteLine("Municao do carro.: {0}\n", this.municao);
        }

    }



    internal class Program
    {
        static void Main(string[] args)
        {
            Carro car1 = new Carro("amarelo");
            car1.Info();
            Console.ReadKey();
            
            car1.Ligar();
            car1.Disparar(2);
            car1.Info();
        }
    }
}
