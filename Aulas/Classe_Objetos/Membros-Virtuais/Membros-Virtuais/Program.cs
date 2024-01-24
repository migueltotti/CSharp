namespace Membros_Virtuais
{
    // membros 'virtual' seram sobescritos por membros 'override' em classes deridavadas aonde os membros possuem o mesmo nome
    // sempre que tiver algo para ser subescrito a outro igual precisamos usar 'virtual' e 'override'
    public class Base
    {
        public Base()
        {
            Console.WriteLine("Construtor da clase base");
        }

        virtual public void Info() 
        {
            Console.WriteLine("Base");
        }
    }

    public class Derivada1 : Base
    {
        public Derivada1()
        {
            Console.WriteLine("Construtor da Derivada 1");
        }

        // nesse caso o Info() da Derivada1 vai subescrever o Info() da sua base, Base
        override public void Info()
        {
            Console.WriteLine("Derivada 1");
        }
    }

    public class Derivada2 : Derivada1
    {
        public Derivada2()
        {
            Console.WriteLine("Construtor da Derivada 2");
        }
        
        // nesse caso o Info() da Derivada2 vai subescrever o Info() da sua base, Derivada1
        override public void Info()
        {
            Console.WriteLine("Derivada 2");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // a palavra chave 'Ref' eh uma referencia que pode receber as classes derivadas da base 'Base'
            Base Ref = new Base();
            Derivada1 derivada1 = new Derivada1();
            Derivada2 derivada2 = new Derivada2();
            // ordem de execussao: Base -> Derivada1 -> Derivada2 -> ... -> Derivada(n)

            Ref = derivada1;
            Ref.Info();
        }
    }
}
