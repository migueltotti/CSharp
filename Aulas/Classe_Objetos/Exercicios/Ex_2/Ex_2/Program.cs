namespace Ex_2
{
    class Porta
    {
        public string cor;

        public Porta(string cor)
        {
            this.cor = cor;
        }

        public void Mostrar()
        {
            Console.WriteLine("Eu sou uma porta, minha cor eh {0}", cor);
        }
    }

    class Habitacao
    {
        public int area;
        public Porta porta;

        public Habitacao(int area, Porta porta)
        {
            this.area = area;
            this.porta = porta;
        }

        public void Mostrar()
        {
            Console.WriteLine("Eu sou uma habitacao, minha area eh {0} m2, e a cor da minha porta eh {1}", area, porta.cor);
        }

    }

    class Apartamento : Habitacao
    {
        public Apartamento(Porta porta):base(50, porta) 
        { 

        }
    }

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

    class Morador : Pessoa
    {
        public Habitacao habt;

        public Morador(string nome, int idade, Habitacao habt):base(nome, idade)
        {
            this.habt = habt;
        }

        public void Mostrar()
        {
            Console.WriteLine("Nome: {0}", nome);
            Console.WriteLine("Idade: {0}", idade);
            Console.WriteLine("Area: {0}", habt.area);
            Console.WriteLine("Cor porta: {0}", habt.porta.cor);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Morador m1 = new Morador("Miguel", 18, new Apartamento(new Porta("amarelo")));
            // Morador eh instanciado gerando um objeto de porta e necessita de 3 parametros
            // 'nome' - como 'Morador' eh derivado de 'Pessoa' esse nome vem da classe 'Pessoa'
            // 'idade' mesma coisa de nome
            // 'Habitacao habt' - dentro de morador existe um objeto de 'Habitacao' e ja que 'Apartamento' eh seu derivado podemos instancia-lo e usar ele no lugar
            // para instanciar 'Apartamento' o parametro de apenas um objeto de 'Porta' eh preciso, pois a area ja eh definida como 50
            // para instanciar 'Porta' precisamos apenas da cor 

            m1.Cumprimentar();
            m1.Mostrar();
        }
    }
}
