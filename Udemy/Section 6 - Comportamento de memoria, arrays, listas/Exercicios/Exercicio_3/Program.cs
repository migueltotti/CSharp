namespace Exercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, negativeCount=0;
            string[] valores;

            N = int.Parse(Console.ReadLine());

            int[,] mat = new int[N, N];

            for(int i = 0; i < N; i++)
            {
                valores = Console.ReadLine().Split(' ');

                for(int j = 0; j < N; j++)
                {
                    mat[i, j] = int.Parse(valores[j]);
                }
            }

            Console.WriteLine("\nMain diagonal:");
            
            for(int i = 0;i < N; i++)
            {
                for(int j = 0; j < N; j++)
                {
                    if(i == j)
                    {
                        Console.Write(mat[i, j] + " ");
                    }

                    if (mat[i, j] < 0)
                    {
                        negativeCount++;
                    }
                }
            }

            Console.WriteLine();

            Console.Write("Negative numbers: ");
            Console.WriteLine(negativeCount);
        }
    }
}
