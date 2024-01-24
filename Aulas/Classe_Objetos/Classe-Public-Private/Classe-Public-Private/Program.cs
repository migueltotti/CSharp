namespace Classe_Public_Private
{

    public class Jogador
    {
        // EspecificacoesAcesso 'private' para propriedades servem para "proteger" alguma informacao
        // eh impossivel acessa-la ou altera-lade fora da classe
        // Apenas dentro da classe ou com metodos dentro da classe, acessar ou modificar uma propriedade private eh possivel
        private string nome;
        private int energia;

        public Jogador(string nome)
        {
            this.nome = nome;
            energia = 100;
        }

        // metodo 'GetEnergia()' permite acessar o valor da propriedade private 
        public int GetEnergia()
        {
            return energia;
        }
        // metodo 'GetNome()' permite acessar o valor da propriedade private
        public string GetNome()
        {
            return nome;
        }

        // metodo 'SetEnergia()' permite a alteracao do valor da proriedade private
        public void SetEnergia(int e)
        {
            if (e < 0)
            {
                if((energia + e) < 0) // ERRO: energia negativa
                {
                    energia = 0;
                }
                else
                {
                    energia += e;
                }
            }
            else if (e > 0)
            {
                if((energia + e) > 100)// ERRO: energia ultrapassou o limite
                {
                    energia = 100;
                }
                else
                {
                    energia += e;
                }
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Jogador j1 = new Jogador("miguel");

            j1.SetEnergia(-30);
            j1.SetEnergia(-30);
            j1.SetEnergia(-30);
            j1.SetEnergia(40);

            Console.WriteLine("Nome...: {0}", j1.GetNome());
            Console.WriteLine("energia: {0}", j1.GetEnergia());
        }
    }
}
