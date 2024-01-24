namespace Ex_5
{
    class AlbumDeFotos
    {
        public int NumeroTotalDePaginas;
        public int NumeroTotalDeFotos; // == NumeroTotalDePaginas * 2;
        public int NumeroDeFotos;

        public AlbumDeFotos() { }

        public AlbumDeFotos(int NumeroTotalDePaginas) 
        { 
            this.NumeroTotalDePaginas = NumeroTotalDePaginas;
            NumeroTotalDeFotos = NumeroTotalDePaginas * 2;
        }

        public int NumeroFotos
        {
            get
            {
                return NumeroDeFotos;
            }
            set
            {
                if( value > NumeroTotalDeFotos ) 
                {
                    Console.WriteLine("ERRO: numero de fotos ultrapassou o limite");
                }
                else
                {
                    NumeroDeFotos = value;
                    Console.WriteLine("Numero de fotos aceito");
                }
            }
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            AlbumDeFotos albumDeFotos = new AlbumDeFotos(5);

            Console.Write("Digite a quantidade total de fotos no album: ");
            albumDeFotos.NumeroFotos = int.Parse(Console.ReadLine());


        }
    }
}
