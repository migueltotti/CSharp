namespace Classe_Abstract
{
    // Classe Abstract - classe de referencia, pode servir como base para outras bases que vao herda-la
    // NAO PODEM SER INSTANCIADAS
    // classes abstratas podem ou n ter metodos abstratos
    // metodos abstratos nao possuem conteudos, apenas o cabecalho do metodo, dai cada classe derivada cria seu proprio corpo do metodo abstrato

    abstract class Veiculo
    {
        protected int velMax;
        protected int velAtual;
        protected bool ligado;

        // esse metodo construtor serve para inicializar objetos instanciados de classes derivadas de 'Veiculo'
        public Veiculo()
        {
            ligado = false;
            velAtual = 0;
        }
        // como 'SetLigado()' nao eh abstrato, somos obrigados a implementar seu corpo, sua funcao
        public void SetLigado(bool ligado)
        {
            this.ligado = ligado;
        }

        public int GetVelAtual()
        {
            return velAtual;
        }

        // metodos abstratos implicam uma obrigatoriedade de IMPLEMENTA-LOS em todas as classes derivadas 
        abstract public void Aceleracao(int mult);
    }

    // para herdarmos uma classe abstrata nao podemos escrever 'public' antes da classe derivada
    class Carro : Veiculo
    {
        public Carro()
        {
            velMax = 120;
        }

        public override void Aceleracao(int mult)
        {
            velAtual += 10 * mult;
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {

            Carro carro1 = new Carro();

            carro1.Aceleracao(3);
            carro1.Aceleracao(-2);

            Console.WriteLine(carro1.GetVelAtual());

        }
    }
}
