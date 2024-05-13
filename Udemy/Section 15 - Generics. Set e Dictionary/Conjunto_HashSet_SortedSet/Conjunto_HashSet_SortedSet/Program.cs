using Conjunto_HashSet_SortedSet.Entities;
using System.Reflection;

namespace Conjunto_HashSet_SortedSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();

            set.Add("TV");
            set.Add("Notebook");
            set.Add("Tablet");

            Console.WriteLine(set.Contains("Notebook"));

            foreach (var item in set)
            {
                Console.WriteLine(item);
            }

            SortedSet<int> a = new SortedSet<int>()
            {
                10, 5, 4, 2, 6, 8, 0
            };
            SortedSet<int> b = new SortedSet<int>()
            {
                5, 6, 7, 8, 9, 10
            };

            Console.WriteLine();
            PrintCollection(a);
            PrintCollection(b);

            // Union
            SortedSet<int> c = new SortedSet<int>(a);
            c.UnionWith(b);
            PrintCollection(c);
            Console.WriteLine();

            // intersection
            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b);
            PrintCollection(d);
            Console.WriteLine();

            // Difference
            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b);
            PrintCollection(e);
            Console.WriteLine();



            // Como colecoes Hash fazem comparacao de igualdade
            HashSet<Product> f = new HashSet<Product>();

            Console.WriteLine("Como colecoes Hash fazem comparacao de igualdade:");

            f.Add(new Product("TV", 900.0));
            f.Add(new Product("Notebook", 1200.0));

            HashSet<Point> g = new HashSet<Point>();

            g.Add(new Point(3, 4));
            g.Add(new Point(5, 10));

            Product prod = new Product("Notebook", 1200.0);
            Console.WriteLine(f.Contains(prod));

            Point p = new Point(5, 10);
            Console.WriteLine(g.Contains(p));
        }

        static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach (T obj in collection)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }
    }
}
