using Problema_motivador_1.Services;

namespace Problema_motivador_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PrintService<int> printService = new PrintService<int>();
                int num;

                Console.Write("How many values? ");
                num = int.Parse(Console.ReadLine());

                for (int i = 0; i < num; i++)
                {
                    printService.addValue(int.Parse(Console.ReadLine()));
                }

                // Type safety - nao vai permitir a operacao com inteiro POIS na isntanciacao foi indicado que o PrintService trabalhara com 'string'
                int a = printService.first();
                int b = a + 2;
                Console.WriteLine(b);

                printService.print();
                Console.WriteLine("First: " + printService.first());
            }
            catch(InvalidOperationException ex)
            {
                Console.WriteLine("An error occured!");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
