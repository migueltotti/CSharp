namespace Resto_da_Divisao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            if (x >= 0 && y >= 0)
            {
                if(x < y)
                {
                    for(int i = x; i < y; i++)
                    {
                        if(i % 5 == 2 || i % 5 == 3)
                        {
                            Console.WriteLine(i);
                        }
                    }
                }
                else
                {
                    for (int i = y; i < x; i++)
                    {
                        if (i % 5 == 2 || i % 5 == 3)
                        {
                            Console.WriteLine(i);
                        }
                    }
                }
            }
        }
    }
}
