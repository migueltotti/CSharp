namespace Membros_Statics
{
    // Membros Statics sao usados quando nao queremos usar objetos para acessar propriedades ou chamar metodos
    class Mat
    {
        public static double pi = 3.14;

        public static void Dobro(ref int num)
        {
            num *= 2;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Nao eh necessaria a instanciacao de um objeto da classe Mat, pois seus membros sao static
            double vpi = Mat.pi;
            int n = 10;
            Console.WriteLine(vpi);
            Mat.Dobro(ref n);
            Console.WriteLine(n);
        }
    }
}
