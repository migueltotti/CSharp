namespace Heranca_Ordem_de_Execucao
{

    public class Base
    {
        public Base()
        {
            Console.WriteLine("Construtor da clase base");
        }
    }

    public class Derivada1 : Base
    {
        public Derivada1()
        {
            Console.WriteLine("Construtor da Derivada 1");
        }
    }

    public class Derivada2 : Derivada1 
    { 
        public Derivada2()
        {
            Console.WriteLine("Construtor da Derivada 2");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Derivada2 derivada2 = new Derivada2();
            // ordem de execussao: Base -> Derivada1 -> Derivada2 -> ... -> Derivada(n)
        }
    }
}
