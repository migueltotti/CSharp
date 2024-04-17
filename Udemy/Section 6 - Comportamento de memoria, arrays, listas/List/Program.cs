using System.Collections.Generic;

namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Isadora");
            list.Add("Miguel");
            list.Add("Frank");
            list.Add("Macaco");

            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

            list.Insert(2, "Kikii");

            Console.WriteLine("\n----------------------\n");

            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n----------------------\n");

            Console.WriteLine("Quantidade de elemetos: " + list.Count);

            Console.WriteLine("Primeiro elemento com a primeira letra M: " + list.Find(x => x[0] == 'M'));

            Console.WriteLine("Ultimo elemento com a primeira letra M: " + list.FindLast(x => x[0] == 'M'));

            Console.WriteLine("Index do primeiro elemento com a primeira letra I: " + list.FindIndex(x => x[0] == 'I'));

            Console.WriteLine("Index do ultimo elemento com a primeira letra M: " + list.FindLastIndex(x => x[0] == 'M'));

            List<string> list2 = list.FindAll(x => x.Length == 5);

            Console.WriteLine("\n----------------------\n");
            foreach(string item in list2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n----------------------\n");
            list.Remove("Miguel");
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n");

            list.RemoveAll(x => x[0] == 'M');
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n");

        }
    }
}
