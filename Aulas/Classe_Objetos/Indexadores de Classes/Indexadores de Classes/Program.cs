namespace Indexadores_de_Classes
{
    
    class Carro
    {
        // Indexador de Classe: permite um objeto funcionar como um array (vetor)
        // para isso criamos um vetor de uma propriedade que queremos alocar varios valores
        private int[] velMax = new int[5] { 80, 120, 160, 240, 300 };

        // e criamos um metodo 'this[int i]'
        // 'int i' serve para acessarmos os indices do array
        // podemos usar as propriedades get e set de qualquer forma
        public int this[int i] // Indexador - utiliza 'this[]'
        {
            get 
            {
                return velMax[i];
            }
            set 
            {
                if (value < 0)
                {
                    velMax[i] = 0;
                }
                else if (value > 300)
                {
                    velMax[i] = 300;
                }
                else
                {
                    velMax[i] = value;
                }
            }
        }

        public Carro()
        {
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Carro carro1 = new Carro();

            // Com isso conseguimos acessar mais de um valor em uma determinada propriedade por um objeto, como se fosse um array
            Console.WriteLine("Velocidade: {0}", carro1[4]);

            carro1[4] = 250; 
            Console.WriteLine("Velocidade: {0}", carro1[4]);
        }
    }
}
