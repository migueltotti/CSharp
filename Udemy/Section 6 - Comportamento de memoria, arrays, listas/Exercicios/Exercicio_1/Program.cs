namespace Exercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quarto[] quartos = new Quarto[10];

            Console.Write("How many rooms will be rented? ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            string name;
            string email;
            int room;

            // utilizando ordenacao
            /*
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"Rent #{i+1}:");
                Console.Write("Name: ");
                name = Console.ReadLine();
                Console.Write("Email: ");
                email = Console.ReadLine();
                Console.Write("Room: ");
                room = int.Parse(Console.ReadLine());
                Console.WriteLine();

                quartos[i] = new Quarto { Name = name, Email = email, Room = room};
            }

            Ordenacao.SelectionSort(quartos, n, 'C');

            Console.WriteLine("Busy rooms:");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(quartos[i].Room + ": " + quartos[i]);
            }*/

            // alocando os quartos no indice do vetor correspondente ao 'room' inserido

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Rent #{i + 1}:");
                Console.Write("Name: ");
                name = Console.ReadLine();
                Console.Write("Email: ");
                email = Console.ReadLine();
                Console.Write("Room: ");
                room = int.Parse(Console.ReadLine());
                Console.WriteLine();

                quartos[room] = new Quarto { Name = name, Email = email, Room = room };
            }

            Console.WriteLine("Busy rooms:");

            for (int i = 0; i < 10; i++)
            {
                if (quartos[i] != null)
                {
                    Console.WriteLine(quartos[i].Room + ": " + quartos[i]);
                }
            }
        }
    }
}
