namespace loop_FOREACH
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[3] { 11, 22, 33 };

            foreach(int i in num)
            {
                Console.WriteLine(i);
            }
            // a variavel 'i' vai pegar/armazenar os valores de cada indice por vez do vetor num
            // 'i' vai pegar os valores 'dentro'/'in' num (vetor int)

        }
    }
}
