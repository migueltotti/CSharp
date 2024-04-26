using Exercicio_3.Entities;
using Exercicio_3.Entities.Enums;
using System.Security.Cryptography.X509Certificates;

namespace Exercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Client
            Client client;
            string name;
            string email;
            DateTime birthdate;

            // Order
            Order order;
            string status;
            int num_itens;
            int quantity;

            // OrderItem
            OrderItem orderItem;

            // Product
            string pnome;
            double pprice;

            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            name = Console.ReadLine();

            Console.Write("Email: ");
            email = Console.ReadLine();

            Console.Write("Birth date (DD/MM/YYYY): ");
            birthdate = DateTime.Parse(Console.ReadLine());

            client = new Client() 
            {
                Name = name,
                Email = email,
                BirthDate = birthdate
            };

            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            status = Console.ReadLine();

            order = new Order()
            {
                Client = client,
                Status = Enum.Parse<OrderStatus>(status),
                Moment = DateTime.Now
            };


            Console.Write("How many items to this order? ");
            num_itens = int.Parse(Console.ReadLine());
            
            for(int i = 1; i <= num_itens; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                pnome = Console.ReadLine();

                Console.Write("Product price: ");
                pprice = double.Parse(Console.ReadLine());

                Console.Write("Quantity: ");
                quantity = int.Parse(Console.ReadLine());
                Console.WriteLine();

                orderItem = new OrderItem()
                {
                    Price = pprice,
                    Product = new Product(pnome, pprice),
                    Quantity = quantity
                };

                order.AddItem(orderItem);
            }


        }
    }
}
