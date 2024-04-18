using System.Threading.Channels;

namespace Exercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] dimensao = new string[2];
            string[] valores;
            int M, N;

            int valor, posM, posN, left, right, up, down;


            dimensao = Console.ReadLine().Split(' ');

            M = int.Parse(dimensao[0]);
            N = int.Parse(dimensao[1]);

            int[,] mat = new int[M, N];
            valores = new string[N];

            for (int i = 0; i < M; i++)
            {
                valores = Console.ReadLine().Split(' ');

                for(int j = 0; j < N; j++)
                {
                    mat[i, j] = int.Parse(valores[j]);
                }
            }

            valor = int.Parse(Console.ReadLine());

            for(int i = 0; i < M; i++)
            {
                for(int j = 0;j < N; j++)
                {
                    if (mat[i, j] == valor)
                    {
                        Console.WriteLine("Position " + i + "," + j + ":");
                        //i < DayOfWeek ? dwadada : awdadada
                        if(j-1 < N && j - 1 >= 0)
                        {
                            Console.WriteLine("Left: " + mat[i, j - 1]);
                        }

                        if(j+1 < N)
                        {
                            Console.WriteLine("Right: " + mat[i, j + 1]);
                        }

                        if (i - 1 < M && i - 1 >= 0)
                        {
                            Console.WriteLine("Up: " + mat[i - 1, j]);
                        }

                        if (i + 1 < M)
                        {
                            Console.WriteLine("Down: " + mat[i + 1, j]);
                        }
                    }
                }
            }
        }
    }
}
