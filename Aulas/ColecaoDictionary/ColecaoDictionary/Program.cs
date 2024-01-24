using System.Collections.Generic;
using System.Security;
// biblioteca para uso do 'Dictionay'

namespace ColecaoDictionary
{
    // Dictionary: colecao de dados relacionados a uma 'chave' e um 'valor'
    internal class Program
    {
        static void Main(string[] args)
        {
            // declaracao de um 'Dictionary' generico
            // Dictionary<tipo_chave, tipo_valor>
            // a chave e o valor podem ter tipos iguais ou diferentes
            Dictionary<int, string> veiculos = new Dictionary<int, string>();

            // Metodo Add(); 
            // adicionar elementos
            veiculos.Add(10, "Carro");
            veiculos.Add(5, "Aviao");
            veiculos.Add(2, "Navio");
            veiculos.Add(20, "Moto");
            veiculos.Add(15, "Skate");


            // Metodo Count();
            // mostra a quantidade de elementos/tamanho no 'Dictionary', retorna int
            Console.WriteLine("Tamanho do Dictionary: {0}", veiculos.Count());


            // Metodo Clear();
            // limpa o 'Dictionary' INTEIRO
            //veiculos.Clear();
            Console.WriteLine("Tamanho do Dictionary: {0}", veiculos.Count());


            // Metodo Remove();
            // remove um elemento da 'Colecao'
            veiculos.Remove(10);


            // Metodo ContainsKey();
            // procura uma chave, retorna true caso encontre e false caso nao encontre
            int chave = 10;
            if(veiculos.ContainsKey(chave))
            {
                Console.WriteLine("Chave {0} contido dentro do Dictionary", chave);
            }
            else
            {
                Console.WriteLine("Chave {0} nao esta contido no Dictionary", chave);
            }


            // Utilizar indexadores 
            // nome_dictionary[chave] = valor;
            veiculos[5] = "Nave";

            // Metodo ContainsValue();
            // verifica se existe um valor no 'Dictionary'/'Colecao'
            string valor = "Nave";
            if (veiculos.ContainsValue(valor))
            {
                Console.WriteLine("Valor {0} contido dentro do Dictionary\n", valor);
            }
            else
            {
                Console.WriteLine("Valor {0} nao esta contido no Dictionary\n", valor);
            }

            // Imprimindo elementos da 'Colecao'
            foreach(KeyValuePair<int, string> v in veiculos)
            {
                Console.WriteLine(v.Value);
            }
            Console.WriteLine();

            // Outra forma de Impressao
            // criar uma nova 'Colecao'/'Dictionary' do tipo 'ValueCollection' para armazenar apenas os valores e receber oss valores da 'Colecao' 'veiculos'
            Dictionary<int, string>.ValueCollection valores = veiculos.Values;

            foreach(string v in valores)
            {
                Console.WriteLine(v);
            }

        }

    }
}
