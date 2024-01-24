namespace CalculadoraSimples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Calculadora Simples

            char opcao = ' ', operador = ' ';
            double valor1=0, valor2=0, resultado=0;

            do
            {
                Console.Clear();

                Console.WriteLine("Digite o primeiro valor: ");
                valor1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite o operador: ");
                Console.Write("+, -, *, /, ^, $ (raiz quadrada)\n:");
                operador = Convert.ToChar(Console.ReadLine());

                if (operador != '$')
                {
                    Console.WriteLine("Digite o segundo valor: ");
                    valor2 = Convert.ToDouble(Console.ReadLine());
                }
            
                switch (operador)
                {
                    case '+':
                        resultado = valor1 + valor2;
                        break;
                    case '-':
                        resultado = valor1 - valor2;
                        break;
                    case '*':
                        resultado = valor1 * valor2;
                        break;
                    case '/':
                        resultado = valor1 / valor2;
                        break;
                    case '^':
                        resultado = Math.Pow(valor1, valor2);
                        break;
                    case '$':
                        resultado = Math.Sqrt(valor1);
                        break;
                    default:
                        Console.WriteLine("Operador Invalido!");
                        break;
                }

                Console.WriteLine("Resultado: " + resultado);

                Console.WriteLine("Deseja fazer outro calculo? (s/n):");
                opcao = Convert.ToChar(Console.ReadLine());

                if (opcao == 'n')
                {
                    Console.Clear();
                    Console.WriteLine("*** Calculadora Finalizada ***");
                }

            } while (opcao == 's');
        }
    }
}
