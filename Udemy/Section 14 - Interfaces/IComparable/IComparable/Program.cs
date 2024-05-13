using IComparable1.Entitites;

namespace IComparable1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\User\Documents\C#\CSharp\Udemy\Section 14 - Interfaces\in_1.txt";

            try
            {
                using(StreamReader sr = File.OpenText(path))
                {
                    List<Employee> list = new List<Employee>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(new Employee(sr.ReadLine()));
                    }

                    list.Sort();

                    foreach (Employee e in list)
                    {
                        Console.WriteLine(e);
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
