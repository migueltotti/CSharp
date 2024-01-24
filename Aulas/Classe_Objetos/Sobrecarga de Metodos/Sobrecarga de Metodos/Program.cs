namespace Sobrecarga_de_Metodos
{
    class Calc
    {
        public int Soma(int n1, int n2)
        {
            return n1 + n2;
        }
        // podemos criar mais de um metodo com o mesmo nome (sobrecarga de metodos) desde que os parametros sejam diferentes, quantidade ou tipo dos parametros

        public int Soma(params int[] n)
        {
            int res=0;

            for(int i = 0; i < n.Length; i++)
            {
                res += n[i];
            }

            return res;
        }

        public double Soma(params double[] n) 
        {
            double res = 0;

            for (int i = 0; i < n.Length; i++)
            {
                res += n[i];
            }

            return res;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Calc calc = new Calc();
            int res;
            double r;

            res = calc.Soma(1, 4);

            Console.WriteLine("Soma: " + res);

            res = calc.Soma(1, 4, 3);

            Console.WriteLine("Soma: " + res);

            res = calc.Soma(1, 4, 3, 9);

            Console.WriteLine("Soma: " + res);

            r = calc.Soma(2.5, 9.7, 5.6);

            Console.WriteLine("Soma: " + r);
        }
    }
}
