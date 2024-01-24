
using System.Collections.Generic;

namespace Colecao_Queue_Fila_
{
    // Queue - Fila (FIFO)
    // First In - First Out

    internal class Program
    {
        static void Main(string[] args)
        {
            string[] V = { "Carro", "Moto", "Aviao" };
            
            // declaracao da Queue e ja iniciacao utilizando um vetor de mesmo tipo 
            Queue<string> veiculos = new Queue<string>(V);


            // Metodo Enqueue();
            // adiciona elementos. Por ser uma fila a adicao de elementos sempre sera no final da fila
            veiculos.Enqueue("Nave");
            veiculos.Enqueue("Navio");

            Info(veiculos);


            // Metodo Dequeue();
            // pega o primeiro elemento, retorna ele e depois elimina-o da fila, fazendo o segundo se tornar o primeiro
            string elemento;
            elemento = veiculos.Dequeue();

            Console.WriteLine("Elemento removido: {0}\n", elemento);
            Info(veiculos);


            // Metodo Peek();
            // retorna o primeiro elemento e nao remove 
            elemento = veiculos.Peek();
            Console.WriteLine("Elemento retornado: {0}\n", elemento);

            // Metodo Count();
            // retorna um int que representa a quantidade de elementos na fila
            Console.WriteLine("Tamanho da fila: {0}\n", veiculos.Count());


            // Metodo Contains();
            // verifica a existencia de um elemento na fila
            string v = "Bicicleta";
            if(veiculos.Contains(v))
            {
                Console.WriteLine("Veiculo {0} pertencente a fila!\n", v);
            }
            else
            {
                Console.WriteLine("Veiculo {0} nao pertence a fila!\n", v);
            }


            // Impressao e Remocao de itens da fila
            Console.WriteLine("Elementos: ");
            while (veiculos.Count() > 0)
            {
                Console.WriteLine(veiculos.Dequeue());
            }
            // aconcelhado usar while() ao inves de for() com filas

            Console.WriteLine("Tamanho da Fila: {0}\n", veiculos.Count());

            // Metodo Clear();
            // limpa a fila
            //veiculos.Clear();
            Info(veiculos);



        }

        public static void Info(Queue<string> veiculos)
        {
            Console.WriteLine("Carros:");
            foreach (string s in veiculos)
            {
                Console.WriteLine("Carro: {0}", s);
            }
            Console.WriteLine();
        }
    }
}
