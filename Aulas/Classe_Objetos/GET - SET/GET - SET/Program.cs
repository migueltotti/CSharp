namespace GET___SET
{

    class Carro
    {
        private int velMax;

        // PROPRIEDADE de Leitura e Escrita
        public int vm
        {
            get //mostrando o valor
            {
                return velMax;
            }
            set //obtendo o valor
            {
                if(value < 0)
                {
                    velMax = 0;
                }
                else if(value > 300)
                {
                    velMax = 300;
                }
                else
                {
                    velMax = value;
                }
            }
        }

        public Carro()
        {
            // usando a propriedade (set) dentro da classe para inserir o valor 120 na variavel 'velMax'
            vm = 120;
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Carro carro1 = new Carro();

            Console.WriteLine("Velocidade: {0}", carro1.vm);
            // 'carro1.vm' - retornando (get) o valor de velMax 

            carro1.vm = 299; // 'carro1.vm' - recebendo (set) o valor de velMax
            Console.WriteLine("Velocidade: {0}", carro1.vm);
            // 'carro1.vm' - retornando (get) o valor de velMax 
        }
    }
}
