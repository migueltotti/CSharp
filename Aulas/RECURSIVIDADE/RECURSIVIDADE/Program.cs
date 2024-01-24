namespace RECURSIVIDADE
{
    // Funcoes que chamam elas mesmas pelo menos 1 vez
    class Calc
    {
        public int Soma(params int[] n)
        {
            int res = 0;

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

        // Funcao recursiva para Fatorial:
        public int Fatorial(int num)
        {
            int res=0;

            if(num == 1)
            {
                res = 1;
            }
            else
            {
                res = num * Fatorial(num - 1);
            }

            return res;
        }

        public int Exponencial(int valor, int expoente)
        {
            int res = 0;

            if(expoente == 0)
            {
                res = 1;
            }
            else
            {
                res = valor * Exponencial(valor, expoente - 1);
            }

            return res;
        }

        public int Fibonacci(int num)
        {
            if(num == 0 || num == 1)
            {
                return 1;
            }
            else
            {
                return Fibonacci(num - 1) + Fibonacci(num - 2);
                
            }
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Calc calc = new Calc();

            int num1 = 5;
            int res = calc.Fatorial(num1);
            Console.WriteLine("Fatorial de {0}: {1}", num1, res);

            res = calc.Exponencial(12, 2);
            Console.WriteLine("12^2 = {0}", res);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(calc.Fibonacci(i));
            }
           
        }
    }
}
