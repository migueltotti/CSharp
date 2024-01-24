namespace loop___WHILE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0, j = 0, num=0;
            int[] num1 = new int[10];
            //int[] num2 = new int[10];

            // verifica a condicao e depois faz a acao
            while (i < num1.Length)
            {
                num1[i] = (i+1) * 2;
                Console.WriteLine(num1[i]);

                i++;
            }

            Console.WriteLine();

            // faz a acao e depois verifica a condicao
            // geralmente eh usado quando queremos mostrar algo primeiro mesmo que a condicao seja falsa
            do
            {
                Console.WriteLine("digite qualquer valor diferente de 1.");
                num = Convert.ToInt32(Console.ReadLine());

            } while(num != 1);

            if(num == 1)
            {
                Console.WriteLine("Ops acho que vc digitou o numero que nao era permitido!!");
            }
        }
    }
}
