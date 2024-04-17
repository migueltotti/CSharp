using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1
{
    internal class Ordenacao
    {
        static private void swap(Quarto[] array, int pos1, int pos2)
        {
            Quarto aux;

            aux = array[pos1];
            array[pos1] = array[pos2];
            array[pos2] = aux;
        } 

        static public void SelectionSort(Quarto[] array, int tam, char opcao)
        {
            int i, j, Aux;

            for(i = 0; i < tam; i++)
            {
                Aux = i;

                for(j = i +1; j < tam; j++)
                {
                    if ((array[Aux].Room > array[j].Room && opcao == 'C') || (array[Aux].Room < array[j].Room && opcao == 'D'))
                    {
                        Aux = j;
                    }
                }

                swap(array, i, Aux);
            }
        }

    }
}
