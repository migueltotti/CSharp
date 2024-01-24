namespace Classes_Objetos
{

    public class Jogador
    {
        // variaveis / propriedades
        public int energia=100;
        public bool vivo=true;

        public int Soma(int x, int y)
        {
            return x + y;
        }

    }
        
    internal class Program
    {
        static void Main(string[] args)
        {
            // Classe - Tipo de dado composto por membros: propriedades(objetos) e funcoes(metodos)
            // na classe nos instanciamos os obejtos e ela eh a base deles, ela que define as regras dos objetos
            // os objetos sao independentes de outro objetos


            // sintaxe padrao das classes:
            /*
            [ModificadorCLasse] class NOME_DA_CLASSE {
             * 
                // Variaveis / Propriedades
                [EspecificadorAcesso] tipo NOME_PROPRIEDADE;

                // Metodos
                [EspecificadorAcesso] tipo NOME_METODO([arg1, ...]){
                
                       // corpo do metodo
                }
             }


            *ModificadorClasse*: defini a visibilidade da classe
                - public: Publica, sem restricao de visualizacao
                         |-> A nao utilizacao de um modificador de classe impoem que a classe sera sempre 'public'
                - abstract: Classe-Base para outras classes, nao pode ser instanciados objetos dessa classe (objetos nao podem ser gerados atravez desta classe)
                - sealed: Clase nao pode ser herdada
                - static: Classe nao permite a instanciacao de objetos e seus membros devem ser static

            *EspecificadorAcesso*: Onde um mebro da classe pode ser acessado
                - public: Sem restricao  de acesso
                        |-> A nao utilizacao de um Especificador de Acesso impoem que sera sempre 'public'
                - private: So podem ser acessados pela propria classe
                - protected: POdem ser acessador na propria classe e nas classes derivadas
                - abstract: Os metodos nao tem implementacao, somente cabecalhos
                - sealed: O metodo nao pode ser redefinido
                - virtual: O metodo pode ser redefinidio em uma classe derivada
                - static: O metodo pode ser chamado mesmo sem a instanciacao de um objeto
            
            */


            // Criando um Objeto a partir de uma classe, Instanciacao de um objeto
            Jogador j1 = new Jogador();
            Jogador j2 = new Jogador();
            Jogador j3 = new Jogador();
            // new vai alocar um espaco na memoria do tamanho da classe 'Jogador' para um novo objeto


            // acessando uma propriedade (variavel) de objetos
            Console.WriteLine("Energia do jogador 1: {0}", j1.energia);

            // alterando uma propriedade (variavel) de objetos
            j1.energia = 50;
            j2.energia = 90;

            Console.WriteLine("Energia modificada do jogador 1: {0}", j1.energia);
            Console.WriteLine("Energia do jogador 2: {0}", j2.energia);

            // utilizando metodos a partir de objetos e classes
            j3.energia = j3.Soma(1, 2);
            Console.WriteLine("Energia do jogador 3: {0}", j3.energia);

        }
    }
}
