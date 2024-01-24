// namespace vai servir para controlar o escopo
// eh uma forma de organizacao e eh possivel classificar os elementos dentro do namespace

namespace Calc1
{
    class Area
    {
        public static double Quad(double bas, double alt)
        {
            if(bas == 0 || alt == 0)
            {
                throw new Exception("Base ou Altura nao podem ser iguais a 0");
            }

            return bas * alt;
        }
    }
}

// eh possivel existir duas classes, iguals ou com o mesmo nome desde que elas pertencao a namespaces diferentes
namespace Calc2
{
    class Area
    {
        public static double Quad(double bas, double alt)
        {
            if (bas == 0 || alt == 0)
            {
                throw new Exception("Base ou Altura nao podem ser iguais a 0");
            }

            return bas * alt;
        }
    }
}

namespace Namespace
{


    internal class Program
    {
        static void Main(string[] args)
        {
            double area;

            // Para chamar Classes, metodos ou propriedades de outros 'namespaces' eh preciso identificar antes o namespace onde elas pertencem
            try
            {
                area = Calc2.Area.Quad(10, 5);
                Console.WriteLine("Area do Quadrado: {0}", area);
            }
            catch(Exception e)
            {
                Console.WriteLine("ERRO: {0}", e.Message);
            }
            finally
            {
                Console.WriteLine("Fim do processo!");
            }
            
        }
    }
}
