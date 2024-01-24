using System.Diagnostics;

namespace fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // FIBONACCI  0,1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584
            int i, quant, ant1 = 1, ant2 = 0, atual = 0;

            //Console.Write("Digite a quantidade de numeros da sequencia Fibonacci deseja mostrar: ");
            quant = int.Parse(Console.ReadLine());

            if (quant < 46) // beecrowd
            {
                for (i = 0; i < quant; i++)
                {
                    if(i == 0)
                    {
                        Console.Write("0");
                    }
                    else if (i == 1)
                    {
                        Console.Write("1");
                    }
                    else
                    {
                        atual = ant1 + ant2;
                        ant2 = ant1;
                        ant1 = atual;

                        Console.Write(atual);

                    }
                    if(i < quant-1)
                    {
                        Console.Write(" ");
                    }
/* beecrowd         else
                    {
                        Console.WriteLine("");
                    }
*/
                }
            }

        }
    }
}
