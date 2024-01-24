namespace Ex_6
{
    // Para cada item, deve armazenar o código, nome, categoria e tamanho hipotético do arquivo em disco;
    // Para filmes deve ter também o nome do diretor, nome do ator principal e nome da atriz principal;
    // Para arquivos de música também deve ter o artista e o tamanho em segundos;
    // Arquivos de filme e música devem ter um método Play (ainda não implementado) e também um método RetrieveInformation, que vai (em uma futura versão) conectar com um servidor na Internet para buscar informações sobre a música ou o filme;
    // Use herança se necessário. Na função Main, crie arrays para cada tipo de objeto, e os alimente com pelo menos 3 arquivos de cada tipo.

    abstract class Catalogo
    {
        public int codigo;
        public string nome;
        public string categoria;
        public int tamanho_arq;

        public Catalogo() { }

        public Catalogo(int codigo, string nome, string categoria, int tamanho_arq)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.categoria = categoria;
            this.tamanho_arq = tamanho_arq;
        }

        public void Play()
        {

        }

        public void RetrieveInformation()
        {

        }

    }

    class Filmes : Catalogo
    {
        public string nome_diretor;
        public string ator_principal;
        public string atriz_principal;

        public Filmes() : base() 
        {
            nome_diretor = string.Empty;
            ator_principal = string.Empty;
            atriz_principal = string.Empty;
        }

        public Filmes(int codigo, string nome, string categoria, int tamanho_arq, string nome_diretor, string ator_principal, string atriz_principal) : base(codigo, nome, categoria, tamanho_arq) 
        { 
            this.nome_diretor = nome_diretor;
            this.ator_principal = ator_principal;       
            this.atriz_principal = atriz_principal;
        }

        public void GetFilmes()
        {
            Console.Write("Codigo..............: {0}\n", codigo);
            Console.Write("Nome................: {0}\n", nome);
            Console.Write("Categoria...........: {0}\n", categoria);
            Console.Write("Tamanho do Arquivo..: {0}\n", tamanho_arq);
            Console.Write("Nome Diretor........: {0}\n", nome_diretor);
            Console.Write("Nome Ator Principal.: {0}\n", ator_principal);
            Console.Write("Nome Atriz Principal: {0}\n", atriz_principal);
        }
    }

    class Musicas : Catalogo
    {
        public string artista;
        public int duracao_s;

        public Musicas() : base()
        {

        }

        public Musicas(int codigo, string nome, string categoria, int tamanho_arq, string artista, int duracao_s) : base(codigo, nome, categoria, tamanho_arq)
        {
            this.artista = artista;
            this.duracao_s = duracao_s;
        }

        public void GetMusicas()
        {
            Console.Write("Codigo............: {0}\n", codigo);
            Console.Write("Nome..............: {0}\n", nome);
            Console.Write("Categoria.........: {0}\n", categoria);
            Console.Write("Tamanho do Arquivo: {0}\n", tamanho_arq);
            Console.Write("Nome Artista......: {0}\n", artista);
            Console.Write("Duracao (s).......: {0}\n", duracao_s);
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            System.Collections.Generic.List<Filmes> vetorF;
            System.Collections.Generic.List<Musicas> vetorM;

            vetorF = new List<Filmes>();
            vetorM = new List<Musicas>();

            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("Digite as informacoes do filme {0}", i+1);
                vetorF.Add(LeFilmes());
                Console.WriteLine();
            }

            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("Digite as informacoes da musica {0}", i+1);
                vetorM.Add(LeMusica());
                Console.WriteLine();
            }

            Console.WriteLine("----------------------------\n");

            for (int i = 0; i < vetorF.Count; i++)
            {
                Console.WriteLine("FILMES:");
                vetorF[i].GetFilmes();
            }

            Console.WriteLine("----------------------------\n");

            for (int i = 0; i < vetorM.Count; i++)
            {
                Console.WriteLine("MUSICAS:");
                vetorM[i].GetMusicas();
            }

            // Altere o exercício anterior para mostrar ao usuário um menu em modo texto, que permita entrar com novas informações e também mostrar os dados armazenados em arrays.
            // Implementar!!!!!!!!!!!!!!!!!!!!!!

        }

        public static Filmes LeFilmes()
        {
            Filmes f = new Filmes();

            Console.Write("Codigo: ");
            f.codigo = int.Parse(Console.ReadLine());
            Console.Write("Nome: ");
            f.nome = Console.ReadLine();
            Console.Write("Categoria: ");
            f.categoria = Console.ReadLine();
            Console.Write("Tamanho do Arquivo: ");
            f.tamanho_arq = int.Parse(Console.ReadLine());

            Console.Write("Nome Diretor: ");
            f.nome_diretor = Console.ReadLine();
            Console.Write("Nome Ator Principal: ");
            f.ator_principal = Console.ReadLine();
            Console.Write("Nome Atriz Principal: ");
            f.atriz_principal = Console.ReadLine();

            return f;
        }

        public static Musicas LeMusica()
        {
            Musicas m = new Musicas();

            Console.Write("Codigo: ");
            m.codigo = int.Parse(Console.ReadLine());
            Console.Write("Nome: ");
            m.nome = Console.ReadLine();
            Console.Write("Categoria: ");
            m.categoria = Console.ReadLine();
            Console.Write("Tamanho do Arquivo: ");
            m.tamanho_arq = int.Parse(Console.ReadLine());

            Console.Write("Nome Artista: ");
            m.artista = Console.ReadLine();
            Console.Write("Duracao (s): ");
            m.duracao_s = int.Parse(Console.ReadLine());

            return m;
        }
    }
}
