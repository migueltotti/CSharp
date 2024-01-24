namespace Ex_basico
{
    //Crie uma classe para representar uma pessoa, com os atributos privados de nome, data de nascimento e altura.
    //Crie os métodos públicos necessários para sets e gets
    //e também um método para imprimir todos dados de uma pessoa.
    //Crie um método para calcular a idade da pessoa.

    public class Pessoa
    {
        private string nome, nascimento;
        private int idade;

        public Pessoa()
        {
            nome = string.Empty;
            nascimento = string.Empty;
            idade = 0;
        }

        // Metodos - Get
        public string GetNome()
        {
            return nome;
        }
        public string GetNascimento()
        {
            return nascimento;
        }
        public int GetIdade()
        {
            int[] nasc = new int[8];
            int dias = 0, meses = 0, anos = 0;
            // projeto feito no dia: 19/01/2023

            nasc[0] = int.Parse(nascimento.Substring(0, 2)); // dia
            nasc[1] = int.Parse(nascimento.Substring(3, 2)); // mes
            nasc[2] = int.Parse(nascimento.Substring(6, 4)); // ano

            while (nasc[0] != 19 || nasc[1] != 01 || nasc[2] != 2024)
            {
                dias++;
                nasc[0]++;

                if(dias == 30)
                {
                    meses++;
                    dias -= 30;
                }
                if(meses == 12)
                {
                    anos++;
                    meses -= 12;
                }

                if(nasc[0] == 30)
                {
                    nasc[1]++;
                    nasc[0] -= 30;
                }
                if (nasc[1] == 12)
                {
                    nasc[2]++;
                    nasc[1] -= 12;
                }

            }

            idade = anos;

            return idade;
        }

        // Metodos - Set
        public void SetNome(string nome)
        {
            this.nome = nome;
        }
        public void SetNascimento(string nascimento)
        {
            this.nascimento = nascimento;
        }

        public void Info()
        {
            Console.WriteLine("Nome da pessoa..............: {0}", GetNome());
            Console.WriteLine("Data de Nascimento da pessoa: {0}", GetNascimento());
            Console.WriteLine("Idade da pessoa.............: {0} anos", GetIdade());
            Console.WriteLine("-----------------------\n");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Pessoa p1 = new Pessoa();

            Console.Write("Digite seu nome..............: ");
            p1.SetNome(Console.ReadLine());
            Console.Write("Digite sua data de nascimento: ");
            p1.SetNascimento(Console.ReadLine());

            Console.WriteLine("--------------------\n");
            p1.Info();

        }
    }
}
