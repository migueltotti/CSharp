using System.Security.Cryptography;

namespace Metodos_para_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // METODOS - ARRAYS

            int[] array1 = new int[5];
            int[] array2 = new int[5];
            int[] array3 = new int[5];

            Random random = new Random();

            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = random.Next(50);
            }

            Console.WriteLine("Elementos do vetor1");
            foreach (int n in array1)
            {
                Console.WriteLine(n);
            }

            // public static int BinarySearch(array, valor);

            // *retorna um valor inteiro*
            Console.WriteLine("\nBinarySearch");
            int procurando = 33;
            int pos = Array.BinarySearch(array1, procurando);
            // BinarySearch vai procurar o valor 'procurando' dentro do array 'array1' e retornar a sua posicao, indice dentro do array
            // caso o valor n seja encontrado o metodo retornara o valor '-1'
            Console.WriteLine("Valor {0} esta na posicao {1}", procurando, pos);
            Console.WriteLine("*------------------------------*\n");


            // public static void Copy(Ar_original, Ar_destino, Qtde_elementos)
            Console.WriteLine("Copy");
            Array.Copy(array1, array2, array1.Length);
            // Copy vai copiar os elementos do 'array1' para o 'array2' a partir da quantidade de elementos desejados e indicados pelo tamanho do 'array1' (array1.Length)
            foreach (int n in array2)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("*------------------------------*\n");


            // public void CopyTo(Ar_destino, a_partir_desta_posicao);
            Console.WriteLine("CopyTo");
            array1.CopyTo(array3, 0);
            // CopyTo copia todos os elementos do 'array1' para o 'array3' a partir da posicao dada
            // esse metodo nao utiliza a classe Array e sim o proprio vetor original 
            foreach (int n in array3)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("*------------------------------*\n");

            // Copy - quando queremos copiar os elementos de um array para outro ATE um certo ponto, tendo um tamanho especificado
            // CopyTo - quando queremos copiar os elementos de um array para outro a PARTIR de uma posicao desejada


            // public long GetLongLength(dimensao);
            Console.WriteLine("GetLongLength");
            long QtdeElemArray = array1.GetLongLength(0);
            // retorna um valor long (int de 64 bits) que representa a quantidade de elementos naquele array
            // um vetor normal apresenta apenas uma dimensao, por isso o campo 'dimensao' no metodo eh zero (0)
            Console.WriteLine("Quantidade de Elementos no Array1: {0}", QtdeElemArray);
            Console.WriteLine("*------------------------------*\n");


            // public int GetLowerBound(dimensao);
            Console.WriteLine("GetLowerBound");
            int MenorIndArray = array1.GetLowerBound(0);
            // esse metodo retorna o menor indice aquele vetor ou matriz, caso seja matriz deve ser especificado qual a dimensao de analise
            Console.WriteLine("Menor Indice do Array1: {0}", MenorIndArray);
            Console.WriteLine("*------------------------------*\n");


            // public int GetUpperBound(dimensao);
            Console.WriteLine("GetUpperBound");
            int MaiorIndArray = array1.GetUpperBound(0);
            // esse metodo retorna o maior indice aquele vetor ou matriz, caso seja matriz deve ser especificado qual a dimensao de analise
            Console.WriteLine("Maior Indice do Array1: {0}", MaiorIndArray);
            Console.WriteLine("*------------------------------*\n");


            // public object GetValue(long indice);
            Console.WriteLine("GetValue");
            int valor = Convert.ToInt32(array1.GetValue(3));
            // esse metodo vai retornar o valor na posicao dada, indice do array
            // ele retorna um objeto, pois podem existir arrays de inteiros, double, string, char... e para isso precisamos converter para o tipo desejado mesmo que o tipo da variavel de armazenagem seja igual ao tipo do array
            Console.WriteLine("Valor da posicao 3 do array1: {0}", valor);
            Console.WriteLine("*------------------------------*\n");


            // public static int IndexOf(array, valor);
            Console.WriteLine("IndexOf");
            int indice1 = Array.IndexOf(array1, 3);
            // esse metodo vai retornar o indice da primeira ocorrencia do valor dado dentro do vetor
            Console.WriteLine("Indice do primeiro valor 3 dentro do array1: {0}", indice1);
            Console.WriteLine("*------------------------------*\n");


            // public static int LastIndexOf(array, valor);
            Console.WriteLine("LastIndexOf");
            int indice2 = Array.LastIndexOf(array1, 3);
            // esse metodo vai retornar o indice da ultima ocorrencia do valor dado
            Console.WriteLine("Indice do ultimo valor 3 dentro do array1: {0}", indice2);
            Console.WriteLine("*------------------------------*\n");


            // public static void Reverse(array);
            Console.WriteLine("Reverse");
            Array.Reverse(array1);
            // esse metodo vai inverter a ordem do arry passado como parametro
            foreach (int n in array1)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("*------------------------------*\n");


            // public void SetValue(object valor, long pos);
            Console.WriteLine("SetValue");
            array2.SetValue(99, 0);
            // esse metodo permitir setar um valor em uma certa posicao dada
            for(int i=1; i < array2.Length; i++)
            {
                array2.SetValue(0, i);
            }
            foreach(int n in array2)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("*------------------------------*\n");


            // public static void Sort(array);
            Console.WriteLine("Sort");
            Array.Sort(array1);
            Array.Sort(array2);
            Array.Sort(array3);
            // metodo para ordenacao crescente de um array
            // para fazer decrescente basta aplicar o Sort() e depois o Reverse()
            Console.WriteLine("Vetor1:");
            foreach (int n in array1)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("\nVetor2:");
            foreach (int n in array2)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("\nVetor3:");
            foreach (int n in array3)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("*------------------------------*\n");

        }
    }
}
