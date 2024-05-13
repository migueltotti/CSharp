using GetHashCode_Equals_personalizados.Entities;

namespace GetHashCode_Equals_personalizados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client a = new Client
            {
                Name = "Miguel",
                Email = "migueltotti2005@gmail.com"
            };

            Client b = new Client
            {
                Name = "Isadora",
                Email = "migueltotti2005@gmail.com"
            };

            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a == b);
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());
        }
    }
}
