namespace Operador_This
{
    public class Calculos
    {
        public int v1;
        public int v2;

        // metodo construtor
        public Calculos(int v1, int v2)
        {
            // Operador 'This.nome_variavel' eh utilizado quando os parametros de entrada para metodos tem o mesmo nome das propriedades das classes
            // significa que vc esta explicando pro metodo que aquela variavel eh a existente no objeto/classe e nao a "criada como um parametro" 
            this.v1 = v1;
            this.v2 = v2;
        }


        public int Somar()
        {
            return v1 + v2;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Calculos calc = new Calculos(2, 2);

            Console.WriteLine(calc.Somar());
            
        }
    }
}
