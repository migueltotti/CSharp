using Exercicio_1.Entities;

namespace Exercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<Student> set = new HashSet<Student>();
            int A, B, C;

            // students data
            int id;

            Console.Write("How many students for course A? ");
            A = int.Parse(Console.ReadLine());

            for(int i = 0; i < A; i++)
            {
                id = int.Parse(Console.ReadLine());
                set.Add(new Student(id));
            }

            Console.Write("How many students for course B? ");
            B = int.Parse(Console.ReadLine());

            for (int i = 0; i < B; i++)
            {
                id = int.Parse(Console.ReadLine());
                set.Add(new Student(id));
            }

            Console.Write("How many students for course C? ");
            C = int.Parse(Console.ReadLine());

            for (int i = 0; i < C; i++)
            {
                id = int.Parse(Console.ReadLine());
                set.Add(new Student(id));
            }

            Console.WriteLine("Total students: " + set.Count);
        }
    }
}
