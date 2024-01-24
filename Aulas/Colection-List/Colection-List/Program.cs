using System.Collections.Generic;

namespace Colection_List
{
    // Listas: substituem arrays

    struct Carros
    {
        public string modelo;
        public int ano;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // declaracao da Lista
            List<string> carros = new List<string>();
            List<string> carros2 = new List<string>();
            string[] carros3 = new string[10];

            // utilizando Structs com Listas, podemos usar Classes e Objetos com Listas da mesma forma
            List<Carros> carros1 = new List<Carros>();

            Carros C = new Carros();
            C.modelo = "Supra";
            C.ano = 2005;

            carros1.Add(C);

            // Metodo Add();
            // adiciona elementos na lista
            carros.Add("Civic");
            carros.Add("Skyline");
            carros.Add("Lancer");
            carros.Add("Skyline");


            // Metodo Insert();
            // inserir elementos na lista em uma posicao determinada
            carros.Insert(0, "Miata");


            // Metodo AddRange();
            // adiciona elementos de outra lista no final da lista
            carros2.AddRange(carros);


            // Metodo CopyTo();
            // copia um elemento de uma string para uma lista
            carros.CopyTo(carros3, 1);

            // Metodo Clear();
            // limpa a lista
            //carros.Clear();

            // Metodo Remove();
            // remove um elemento da lista a partir do valor
            carros.Remove("Miata");

            // RemoveAt();
            // remove um elemento a partir de um indice
            //carros.RemoveAt(1);

            // RemoveRange()
            // remove elementos a partir de um indice e pela quantidade de remocoes
            //carros.RemoveRange(0, 3);


            // Metodo Reverse();
            // inverte a lista
            //carros.Reverse();


            // Metodo Sort();
            // ordena a lista em ordem crescente, em string eh por ordem alfabetica
            carros.Sort();


            // Metodo Count();
            // retorna a quantidade de elementos da lista
            Console.WriteLine("Tamanho de Carros: {0}", carros.Count());


            // Propriedade Capacity;
            // retorna a capacidade de elementos que a lista pode armazenar
            Console.WriteLine("Capacidade da lista Carros: {0}", carros.Capacity);

            // podemos mudar a capacidade de armazenamento na lista
            carros.Capacity = 15;
            Console.WriteLine("Capacidade da lista Carros: {0}", carros.Capacity);


            // Metodo Contains();
            // verifica a existencia de um determinado valor na lista
            if (carros.Contains("Civic"))
            {
                Console.WriteLine("Carro encontrado\n");
            }
            else
            {
                Console.WriteLine("Carro nao encontrado\n");
            }


            // Metodo IndexOf();
            // retorna um inteiro que representa o indice do valor buscado
            string car = "Skyline";
            int pos = carros.IndexOf(car);
            Console.WriteLine("Posicao de {0} na lista carros: {1}\n", car, pos);

            // Metodo LastIndexOf();
            // retorna a posicao da ultima ocorrencia de um valor na lista
            int pos2 = carros.LastIndexOf(car);
            Console.WriteLine("Posicao da ultima ocorrencia de {0} na lista carros: {1}\n", car, pos2);


            Console.WriteLine("Carros:");
            foreach (string s in carros)
            {
                Console.WriteLine("Carro: {0}", s);
            }
            Console.WriteLine();

            Console.WriteLine("Carros2:");
            foreach (string s in carros2)
            {
                Console.WriteLine("Carro: {0}", s);
            }

            Console.WriteLine("\nCarros3:");
            foreach (string s in carros3)
            {
                Console.WriteLine("Carro: {0}", s);
            }
        }
    }
}
