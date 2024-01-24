namespace NotaseMoedas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ponto=0;
            string valor_str;
            double valor_dbl;
            int Inteiro, Decimal;
            int[] notas = {100, 50, 20, 10, 5, 2, 1};
            int[] moedas = {50, 25, 10, 05, 01};
            int[] quantidade_int = new int[7]; // armazenar a quantida de cada nota
            int[] quantidade_dec = new int[5];

            valor_dbl = Convert.ToDouble(Console.ReadLine());

            if (0 <= valor_dbl || valor_dbl <= 1000000.00)
            {
                valor_str = Convert.ToString(valor_dbl);


                // copiar o valor antes e apos a virgula em string separadas e ja converte-los para valores inteiros
                Inteiro = int.Parse(valor_str.Substring(0, valor_str.Length-2));
                Decimal = int.Parse(valor_str.Substring(valor_str.Length-2, 2));

                // Quantidade das notas do valor Inteiro
                for(int i = 0; i < notas.Length; i++)
                {
                    if (Inteiro >= notas[i])
                    {
                        quantidade_int[i] = Inteiro / notas[i];
                        Inteiro = Inteiro % notas[i];
                    }
                }

                // Quantidade das notas do valor Decimal
                for (int i = 0; i < moedas.Length; i++)
                {
                    if (Decimal >= moedas[i])
                    {
                        quantidade_dec[i] = Decimal / moedas[i];
                        Decimal = Decimal % moedas[i];
                    }
                }

                // print na tela das quantidades das notas por valor
                Console.WriteLine("NOTAS:");

                for (int i = 0; i < (notas.Length-1); i++)
                {        
                    Console.WriteLine("{0} nota(s) de R$ {1}.00", quantidade_int[i], notas[i]);
                }

                Console.WriteLine("MOEDAS:");

                for (int i = -1; i < quantidade_dec.Length; i++)
                {
                    if (i < 0)
                    {
                        Console.WriteLine("{0} nota(s) de R$ {1}.00", quantidade_int[6], notas[6]);
                    }
                    else
                    {
                        Console.WriteLine("{0} nota(s) de R$ 0.{1}", quantidade_dec[i], moedas[i]);
                    }
                } 
            }


        }
    }
}
