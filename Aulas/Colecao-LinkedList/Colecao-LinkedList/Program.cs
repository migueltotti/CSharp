using System.Collections.Generic;
// biblioteca de Colecoes

namespace Colecao_LinkedList
{
    // Lista Duplamente Encadeada: cada elemento esta conectado ao seu sucessor e anterior
    internal class Program
    {
        static void Main(string[] args)
        {
            // declaracao da 'LinkedList' generica
            LinkedList<string> transp = new LinkedList<string>();


            // Metodo AddFirst();
            // adiciona elementos no inicio da lista
            transp.AddFirst("Carro");
            transp.AddFirst("Aviao");
            transp.AddFirst("Navio");

            // Metodo AddLast();
            // adiciona elementos no fim da lista
            transp.AddLast("Moto");

            // Metodo AddAfter(); e AddBefore();
            // Adiciona elementos depois ou antes de outro elemento
            // parametros: No de referencia, valor que vai ser inserido apos o No
            
            LinkedListNode<string> no;
            no = transp.FindLast("Navio").Next;
            // no ta recebendo o 'No' do proximo valor apontado por 'Navio' -> 'Aviao'

            //transp.AddAfter(no, "Bicicleta");
            // ou
            transp.AddAfter(transp.FindLast("Aviao"), "Bicicleta");

            transp.AddBefore(transp.FindLast("Aviao").Previous, "Patins");
            // vai inserir o valor 'Patins' no 'No' antecessor a 'Aviao': 'Navio' <- 'Aviao'


            // Metodo Clear();
            // remocao de todos os elementos
            //transp.Clear();


            // Metodo Remove();
            // remove um elemento da lista a partir de um valor de referencia
            transp.Remove("Carro");

            // RemoveFirst(); RemoveLast();
            // remove o primeiro e o ultimo elemento
            //transp.RemoveFirst();
            //transp.RemoveLast();

            // Metodo Find();
            // encontra um valor na lista
            if(transp.Find("Carro") == null)
            {
                Console.WriteLine("Valor nao encontrado\n");
            }
            else
            {
                Console.WriteLine("Valor encontrado\n");
            }

            foreach (string n in transp)
            {
                Console.WriteLine("Transporte: {0}", n);
            }
        }
    }
}
