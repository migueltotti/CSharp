namespace PedraPapelTesoura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // jogo de pedra papel tesoura
            // User VS Computador

            int escolha_user, escolha_comp, v=0, d=0, e=0;
            char opcao = ' ';

            String[] opcoes = new string[3] { "Pedra", "Papel", "Tesoura" };
            Random random = new Random();

            do
            {
                Console.Clear();

                Console.WriteLine("\nDigite alguma das opcoes abaixo:");
                Console.Write(" [0] - Pedra\n [1] - Papel\n [2] - Tesoura\n:");
                escolha_user = Convert.ToInt32(Console.ReadLine());

                escolha_comp = random.Next(0, 3); // 0 - 2

                if (escolha_user == escolha_comp)
                {
                    Console.WriteLine("\n*** EMPATE ***");
                    Console.WriteLine("User: {0} x Comp: {1}\n", opcoes[escolha_user], opcoes[escolha_comp]);
                    e++;
                }
                else
                {
                    switch (escolha_user)
                    {
                        case 0:
                            if (escolha_comp == 1)
                            {
                                Console.WriteLine("*** VITORIA COMP ***");
                                Console.WriteLine("User: {0} x Comp: {1}\n", opcoes[escolha_user], opcoes[escolha_comp]);
                                d++;
                            }
                            else
                            {
                                Console.WriteLine("*** VITORIA USER ***");
                                Console.WriteLine("User: {0} x Comp: {1}\n", opcoes[escolha_user], opcoes[escolha_comp]);
                                v++;
                            }
                            break;
                        case 1:
                            if (escolha_comp == 2)
                            {
                                Console.WriteLine("*** VITORIA COMP ***");
                                Console.WriteLine("User: {0} x Comp: {1}\n", opcoes[escolha_user], opcoes[escolha_comp]);
                                d++;
                            }
                            else
                            {
                                Console.WriteLine("*** VITORIA USER ***");
                                Console.WriteLine("User: {0} x Comp: {1}\n", opcoes[escolha_user], opcoes[escolha_comp]);
                                v++;
                            }
                            break;
                        case 2:
                            if (escolha_comp == 0)
                            {
                                Console.WriteLine("*** VITORIA COMP ***");
                                Console.WriteLine("User: {0} x Comp: {1}\n", opcoes[escolha_user], opcoes[escolha_comp]);
                                d++;
                            }
                            else
                            {
                                Console.WriteLine("*** VITORIA USER ***");
                                Console.WriteLine("User: {0} x Comp: {1}\n", opcoes[escolha_user], opcoes[escolha_comp]);
                                v++;
                            }
                            break;
                    }
                }

                Console.Write("Deseja jogar novamente? (s/n): ");
                opcao = Convert.ToChar(Console.ReadLine());

            } while (opcao == 's');

            if (opcao == 'n')
            {
                Console.Clear();

                Console.WriteLine("\n-- FIM DE JOGO --");
                Console.WriteLine("*User*\nVitorias: {0}\nDerrotas: {1}\nEmpates: {2}", v, d, e);
            }
        }
    }
}
