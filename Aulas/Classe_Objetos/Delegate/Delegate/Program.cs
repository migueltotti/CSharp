namespace Delegate
{
    // Delegate eh um objeto que faz referencia a um ou varios metodos
    // poodemos criar uma class static e um Delegate que vai fazer referencia a todos esses metodos statics
    // ele contem o endereco de memoria do ponto de entrada do metodo

    // os parametros do 'delegate' precisam ser iguais aos parametros dos metodos q ele fara referencia
    public delegate int Op(int n1, int n2);
    public delegate int Op2(params int[] x);

    internal class Program
    {
        public static int Soma(int n1, int n2)
        {
            return n1 + n2;
        }

        public static int Dobro(int n)
        {
            return n * 2;
        }

        public static int Mult(int n1, int n2)
        {
            return n1 * n2;
        }

        public static int Soma(params int[] n)
        {
            int res=0;

            for(int i = 0; i < n.Length; i++)
            {
                res += n[i];
            }

            return res;
        }
    
        static void Main(string[] args)
        {
            int res;

            // quantidade de parametros definidos
            Op d1 = new Op(Soma);

            res = d1(10, 50);

            Console.WriteLine("Soma 1: {0}", res);

            d1 = new Op(Mult);

            Console.WriteLine("Mult: {0}", d1(10, 2));

            // quantidade de parametros nao definidos
            Op2 d2 = new Op2(Soma);
            res = d2(10, 5, 6, 4);
            Console.WriteLine("Soma 2: {0}", res);
        }
    }
}
