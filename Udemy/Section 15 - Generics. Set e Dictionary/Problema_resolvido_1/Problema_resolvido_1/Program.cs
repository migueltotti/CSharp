using Problema_resolvido_1.Entities;

namespace Problema_resolvido_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<User> collection = new HashSet<User>();

            // user data
            string[] data;
            string name;
            DateTime date;

            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            try
            {
                using(StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        data = sr.ReadLine().Split(" ");
                        name = data[0];
                        date = DateTime.Parse(data[1]);
                        collection.Add(new User(name, date));
                    }

                    Console.WriteLine("Total users: " + collection.Count);
                }


            }catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
