namespace Ex_4
{

    class Ponto3D
    {
        public int X;
        public int Y;
        public int Z;

        public Ponto3D() { }

        public Ponto3D(int x, int y, int z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public void Mostrar()
        {
            Console.WriteLine("Pontos: ");
            Console.WriteLine("X: {0}", X);
            Console.WriteLine("Y: {0}", Y);
            Console.WriteLine("Z: {0}\n", Z);
        }

        public void MoverPara(int x, int y, int z)
        {
            Console.WriteLine("Cordenada Nova: ");
            Console.ReadLine(); // X
            Console.ReadLine(); // Y
            Console.ReadLine(); // Z
        }

        public double Distancia(Ponto3D p2)
        {
            double distancia;

            distancia = Math.Sqrt((Math.Pow((this.X - p2.X), 2)) + (Math.Pow((this.Y - p2.Y), 2)) + (Math.Pow((this.Z - p2.Z), 2)));

            return distancia;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Ponto3D[] ponto3Ds = new Ponto3D[3];
            

            for(int i =0; i < ponto3Ds.Length; i++)
            {
                Console.WriteLine("Ponto {0}: ", i+1);

                ponto3Ds[i] = SetPontos();
            }

            for(int i = 0; i < ponto3Ds.Length-1; i++)
            {
                Console.WriteLine("Distancia entre os pontos [1] e [{0}]: {1}", i+2, ponto3Ds[0].Distancia(ponto3Ds[i + 1]));

            }
        }

        public static Ponto3D SetPontos()
        {
            Ponto3D p = new Ponto3D();

            Console.Write("X: ");
            p.X = int.Parse(Console.ReadLine());
            Console.Write("Y: ");
            p.Z = int.Parse(Console.ReadLine());
            Console.Write("Z: ");
            p.Y = int.Parse(Console.ReadLine());

            return p;
        }
    }
}
