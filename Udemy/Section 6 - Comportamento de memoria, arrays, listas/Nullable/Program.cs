namespace Nullable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Nullable<double> x = null;
            double? y = 10.0;

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            if(x.HasValue)
            {
                Console.WriteLine(x.Value);
            }
            Console.WriteLine(y.Value);
            Console.WriteLine();

            double? x1 = null;
            double? y1 = 10;

            double a = x1 ?? 5;
            double b = y1 ?? 5;

            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
