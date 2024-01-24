using System.Globalization;

namespace Metodos_que_retornam_Objetos
{

    class Galinha
    {
        private string nomeGalinha;
        private int numOvo;
        public static int numOvoTotal;

        public Galinha(string nomeGalinha)
        {
            this.nomeGalinha = nomeGalinha;
            numOvo = 0;
        }

        // metodo que retorna um objeto do tipo Ovo
        public Ovo Botar()
        {
            numOvo++;
            //numOvoTotal++;
            return new Ovo(numOvo, this.nomeGalinha);
        }
    }

    class Ovo
    {
        private int numOvo;
        private string minhaGalinha;

        public Ovo(int numOvo, string minhaGalinha)
        {
            this.numOvo = numOvo;
            this.minhaGalinha = minhaGalinha;
            Galinha.numOvoTotal++;
            Console.WriteLine("Ovo criado: {0} - {1}", this.numOvo, this.minhaGalinha);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Galinha g1 = new Galinha("Berenice");
            Galinha g2 = new Galinha("Valeria");
            Galinha g3 = new Galinha("Oswaldina");

            g1.Botar(); // chamado de metodo que retorna um objeto do tipo Ovo
            g1.Botar();

            g2.Botar();
            g2.Botar();
            g2.Botar();

            g3.Botar();
            Console.WriteLine();

            Console.WriteLine("Num Total de Ovos: {0}", Galinha.numOvoTotal);
        }
    }
}
