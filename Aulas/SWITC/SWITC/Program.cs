namespace SWITCH
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor;
            char escolha;
            String bebida = "";

            // label
            inicio: 

            Console.Clear(); // limpa o console

            Console.WriteLine("Digite o caracter da bebida desejada.");
            Console.Write("[c] - coca cola\n[g] - guarana\n[a] - agua\n:");

            //escolha = Convert.ToChar(Console.ReadLine());
            escolha = char.Parse(Console.ReadLine());
            // converte o unico caracter de uma string em uma varaivel char

            switch (escolha)
            {
                case 'c':
                case 'C':
                    valor = 6.50;
                    bebida = "coca cola";
                    break;
                case 'g':
                case 'G':
                    valor = 5.50;
                    bebida = "guarana";
                    break;
                case 'a':
                case 'A':
                    valor = 2.50;
                    bebida = "agua";
                    break;
                default:
                    valor = -1;
                    break;
            }

            if(valor == -1)
            {
                Console.WriteLine("Codigo Indisponivel!");
            }
            else
            {
                Console.WriteLine("Aproveite sua {0} gelada por R$ {1}", bebida, valor);
            }

            Console.WriteLine("Deseja escolher outra bebida?: [s] - sim ; [n] - nao\n");
            escolha = char.Parse(Console.ReadLine());

            if (escolha == 's' || escolha == 'S')
            {
                // goto label; faz o programa voltar a um determinado momento e continuar dali
                goto inicio;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Fim do programa!");
            }
            
        }
    }
}
