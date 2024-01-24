namespace SentencaDancante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentenca;
            char[] caracteres = new char[50];
            char caracter;
            bool ant_maiusculo = false;

            sentenca = Console.ReadLine();

            if(1 < sentenca.Length|| sentenca.Length <= 0) 
            {

                for (int i = 0; i < sentenca.Length; i++)
                {
                    caracteres[i] = sentenca[i];

                    if(!ant_maiusculo && caracteres[i] != ' ')// caracter anterior minusculo
                    {
                        caracter = char.ToUpper(caracteres[i]);
                        caracteres[i] = caracter;
                        ant_maiusculo = true;
                    }
                    else if (ant_maiusculo && caracteres[i] != ' ')
                    {
                        caracter = char.ToLower(caracteres[i]);
                        caracteres[i] = caracter;
                        ant_maiusculo = false;
                    }
                }

            }

            for (int i = 0; i < sentenca.Length; i++)
            {
                Console.Write(caracteres[i]);
            }

            Console.WriteLine();

        }
    }
}
