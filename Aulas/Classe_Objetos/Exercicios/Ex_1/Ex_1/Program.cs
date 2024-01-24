namespace Ex_1
{

    class Pessoa
    {
        public string nome;
        public int idade;

        public Pessoa(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
        }

        public void Cumprimentar()
        {
            Console.WriteLine("Ola, eu sou {0}", nome);
        }

        public void DizerIdade()
        {
            Console.WriteLine("Eu tenho {0} anos", idade);
        }

    }

    class Aluno : Pessoa 
    { 
        public Aluno(string nome, int idade):base(nome, idade)
        {

        }
        
        public void IrParaEscola()
        {
            Console.WriteLine("O aluno {0} está indo para escola.", nome);
        }

    }

    class Professor : Pessoa
    {
        public Professor(string nome, int idade):base(nome, idade)
        {

        }

        public void Explicar(string assunto)
        {
            Console.WriteLine(assunto);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa("Miguel", 18);

            p1.Cumprimentar();
            p1.DizerIdade();
            Console.WriteLine();

            Aluno a1 = new Aluno("Joao", 21);

            a1.IrParaEscola();
            a1.Cumprimentar();
            a1.DizerIdade();
            Console.WriteLine();

            Professor pr1 = new Professor("Marcelo", 30);

            pr1.Cumprimentar();
            pr1.DizerIdade();
            pr1.Explicar("Programacao Orientada a Objetos!");
        }
    }
}
