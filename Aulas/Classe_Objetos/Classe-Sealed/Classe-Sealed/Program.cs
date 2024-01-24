namespace Classe_Sealed
{
    // Classes Sealed - NAO PODEM SER HERDADAS
    sealed class Veiculo
    {

    }

    class Carro : Veiculo
    {

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Carro carro1 = new Carro();
        }
    }
}
