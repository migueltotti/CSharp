using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Arrays / Vertores 
            int[] n = new int[5]; // declarando um vetor de 5 posicoes vazias (0 - 4)
            //int[] num = new int[3] {11, 22, 33}; // cria um vetor nulo e depois atribuo valores
            int[] num = { 11, 22, 33 }; // crio um vetor com as posicoes com valores ja atribuidos
            string[] nomes = {"Miguel", "Isadora"};

            n[0] = 1;
            n[1] = 2;
            n[2] = 3;
            n[3] = 4;
            n[4] = 5;

            Console.WriteLine(num[1]);
            Console.WriteLine(nomes[1]);

            // matrizes

            int[,] num2 = new int[3, 2] { {10, 20}, 
                                          {15, 25 },
                                          {20, 30} 
                                        };
            /*
             num2 =
             10 20
             15 25
             20 30
            */

            Console.WriteLine(num2[2,1]);
        }
    }
}

