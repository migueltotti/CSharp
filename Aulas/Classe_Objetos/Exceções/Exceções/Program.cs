namespace Exceções
{
    class Area
    {
        public static double Quad(float bas, float alt)
        {
            // unica Excecao: base e altura != 0
            if(bas == 0 || alt == 0)
            {
                throw new Exception("Base ou altura nao podem ser iguais a 0");
                // Novo erro criado
            }

            return bas * alt;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, res;
            res = n1 = n2 = 0;

            // Unhandled exception. System.DivideByZeroException: Attempted to divide by zero.
            // erro gerado pela tentativa de divisao por zero
            // Unhandled exception == Excecao sem Tratamento
            // podemos tratar esse erro

            n1 = 10;
            n2 = 0; // gerando um erro

            // Modo generico de Tratamento de Excecoes
            // Tratando o erro para que apareca a mensagem de "ERRO" ao inves de "Unhandled exception. System.DivideByZeroException: Attempted to divide by zero."
            /*try
            {
                res  = n1 / n2;
                Console.WriteLine("Divisao de {0} por {1} eh igual a {2}", n1, n2, res);
            }
            catch
            {
                Console.WriteLine("ERRO");
            }*/

            /*try
            {
                res = n1 / n2;
                Console.WriteLine("Divisao de {0} por {1} eh igual a {2}", n1, n2, res);
            }
            catch(Exception ex) // Dessa forma o "catch" vai pegar exatamente o erro gerado acima no "try"
            {
                Console.WriteLine("Execao Completa: {0}\n\n", ex);
                Console.WriteLine("Mensagem de Erro: {0}\n\n", ex.Message);
                Console.WriteLine("Tipo da Excecao: {0}\n\n", ex.GetType());
                // ex.Message vai mostrar exatamente o erro gerado
            }*/
            // Exception = Classe Pai de todos os Erros
            // ex = vai ser o erro gerado


            // Como disparar uma Excecao sem necessariamente gerar um erro
            n1 = 10;
            n2 = 2;

            /*try{
                res = n1 / n2;
                Console.WriteLine("Divisao de {0} por {1} eh igual a {2}", n1, n2, res);
                throw new Exception("MIGUEL TOTTI");
                // Gerando uma nova Excecao com a mensagem "MIGUEL TOTTI"
                // Dessa forma o erro eh gerado por conta do 'throw new Exception' e nao pela divisao (que esta correta)
            }
            catch (Exception ex) // Dessa forma o "catch" vai pegar exatamente o erro gerado acima no "try"
            {
                Console.WriteLine("Execao Completa: {0}\n\n", ex);
                Console.WriteLine("Mensagem de Erro: {0}\n\n", ex.Message);
                Console.WriteLine("Tipo da Excecao: {0}\n\n", ex.GetType());
                // ex.Message vai mostrar exatamente o erro gerado
            }
            finally
            {
                Console.WriteLine("Fim do Processo");
            }*/
            // finally: nao importa se houve erro ou nao, ele sera executado independentemente


            double area = 0;

            try
            {
                area = Area.Quad(0, 5);
                Console.WriteLine("Area do Quadrado: {0}", area);
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERRO: {0}", ex.Message);
            }
            finally
            {
                Console.WriteLine("Fim do Processo");
            }

        }
    }
}
