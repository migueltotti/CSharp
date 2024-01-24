namespace Classe_Static
{
    // Class Static: nao podem instanciar objetos, seus metodos so podem ser acessados diretamente pela classe e NAO POSSUEM METODOS CONSTRUTORES
    // todos os seus membros devem ser static (variaveis e metodos)
    // classes NAO static podem ter membros static

    // Outra caracteristica:
    // Uma classe static eh fixa na memoria, eh acessivel e seus valores sao os mesmos para todas as outras classes static que a utilizarem e a modificarem
    static public class Jogador
    {
        static public int energia;
        static public bool vivo;
        static public string nome;

        static public void Iniciar(string n)
        {
            energia = 100;
            vivo = true;
            nome = n;
        }

        static public void Info()
        {
            Console.WriteLine("Nome Jogador...: {0}", nome);
            Console.WriteLine("Energia Jogador: {0}", energia);
            Console.WriteLine("Vivo Jogador...: {0}\n", vivo);
        }
    }

    public class Inimigo
    {
        // propriedades/variaves static so podem sofrer alteracao diretamente da classe e nao pelo objeto instanciado
        // qualquer alteracao feita na propriedade 'static alerta' alterara essa propriedade para todos os objetos desta classe
        static public bool alerta, vivo;
        public string nome;

        public Inimigo(string n)
        {
            alerta = false;
            nome = n;
            vivo = true;
        }

        // Metodos static so podem ser chamados diretamente pela classe e nao pelos objetos
        static public /*void*/ bool Matar()
        {
            //vivo = false;
            return false;
        }

        public void Info()
        {
            Console.WriteLine("Nome..: {0}", nome);
            Console.WriteLine("Alerta: {0}", alerta);
            Console.WriteLine("Vivo..: {0}", vivo);
            Console.WriteLine("--------------------\n");
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Jogador.Iniciar("Miguel");
            Jogador.Info();
            Jogador.energia = 100;

            Inimigo i1 = new Inimigo("MALUCO");
            Inimigo i2 = new Inimigo("DOIDO");
            Inimigo i3 = new Inimigo("FLORZINHA");

            i1.Info();
            i2.Info();
            i3.Info();

            Console.WriteLine("\n*Humado a vista*\n");
            Inimigo.alerta = true;

            i1.Info();
            i2.Info();
            i3.Info();

            Console.WriteLine("\n*Humano atirou em todos os Inimigos*\n");
            //Inimigo.Matar();
            Inimigo.vivo = Inimigo.Matar();

            i1.Info();
            i2.Info();
            i3.Info();

        }
    }
}
