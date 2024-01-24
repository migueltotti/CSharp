namespace IdadeEmDias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Idade em dias
            int i, idade, idade_anos=0, idade_meses=0, idade_dias=0;

            Console.Write("Digite sua idade em dias: ");
            idade = int.Parse(Console.ReadLine());

            for (i = 0; i < idade; i++)
            {
                idade_dias++;

                if (idade_dias == 30)
                {
                    idade_meses++;
                    idade_dias -= 30;
                }

                if(idade_meses == 12 && idade_dias == 5)
                {
                    idade_anos++;
                    idade_meses -= 12;
                    idade_dias -= 5;
                }

            }

            Console.WriteLine("{0} ano(s)\n{1} mes(es)\n{2} dia(s)", idade_anos, idade_meses, idade_dias);

        }
    }
}
