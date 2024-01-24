using System;
using System.Globalization;

namespace Metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // METODOS - FUNCOES
            // o metodo Main() eh um metodo static
            // logo, apenas metodos criados static podem funcionar dentro do main
/*
            Miguel();

            int x = Soma(1, 2);
            Console.WriteLine("\nA soma de 1 com 2 eh: {0}", x);

            Console.WriteLine("\nA soma de 1 com 2 eh: {0}\n", Soma(1,2));

            // essa eh a forma de chamar o nosso metodo dentro do Main()

            int num = 10;
            // ref nome_da_variavel - quer fizer que aquela variavel esta sendo passada para dentro da funcao por referencia e nao apenas por valor
            // passar por referencia eh como se estivessemos mandando a propria variavel (em c++ seria o endereco da variavel) para dentro da funcao
            Dobrar(ref num);
            Console.WriteLine("O dobro de 10 eh {0}", num);


            int divid, div, quociente, resto;
            divid = 10;
            div = 5;
            quociente = Divide(divid, div, out resto);
            // para usar uma variavel como um argumento de saida, devemos colocar out antes da varivel como parametro

            Console.WriteLine("{0} / {1}: quociente = {2} e resto = {3}", divid, div, quociente, resto);
*/
            
            int n1=10, n2=3, n3=1;
            Soma2(n3);
            // para utilizar metodos com orgumento 'params' como entrada devemos passar os valores normalmente sem nenhuma alteracao
        }
        
        // metodo sem retorno e sem parametros de entrada
        static void Miguel()
        {
            String resposta;
            Console.WriteLine("Ola Miguel, tudo bem?");
            resposta = Console.ReadLine();
            if(resposta == "sim" || resposta == "SIM")
            {
                Console.WriteLine("Que otimo!\nTenha um bom dia");
            }
        }

        // metodo com retorno int e 2 parametros de entrada
        // PASSAGEM POR VALOR: passamos apenas uma copia do valor contido naquela variavel, por isso nao ocorre nenhuma alteracao na propria variavel de entrada nos parametros
        // para que um valor seja retornado preciamos utilizar 'return'
        static int Soma1(int x, int y)
        {
            return x + y;
        }
        
        
        // PASSAGEM POR REFERENCIA: passamos a variavel inteira para dentro do metodo e por conta disso qualquer alteracao feita dentro do metodo afetara a variavel fora do metodo, depois que ele finalizar
        // funciona como se fosse um return porem o metodo nao necessariamente precisa ter retorno
        static void Dobrar(ref int valor)
        {
            valor *= 2; 
        }

        // ARGUMENTO - OUT : usamos out quando precisamos retornar mais de um valor de um metodo, utilizamos o 'return' e o argumento 'out tipo_dado nome_variavel'
        static int Divide(int dividendo, int divisor, out int resto)
        {
            int quociente;
            quociente = dividendo / divisor;
            resto = dividendo % divisor;
            return quociente;
        }


        // ARGUMENTO - PARAMS: quando a quantidade de parametros de entrada nao eh exata, podem ter 1, 2, 3 ou mais em diferentes casos
        // usamos params tipo_dado[] nome_array
        // podemos ou nao especificar o tamanho do array
        static void Soma2(params int[] n)
        {
            int res=0;

            if(n.Length < 1) //== 0
            {
                Console.WriteLine("\nNao existe valores a serem somados");
            }
            else if(n.Length < 2) // == 1
            {
                Console.WriteLine("Valores insuficientes para soma: {0}", n[0]);
            }
            else
            {
                for (int i = 0; i < n.Length; i++)
                {
                    res += n[i];
                }
                Console.WriteLine("A soma dos valores eh: {0}", res);
            }

            
        }
    }
}
