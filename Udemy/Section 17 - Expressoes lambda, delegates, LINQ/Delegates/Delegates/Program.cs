using Delegates.Services;

namespace Delegates
{
    delegate double BinaryNumericOperation(double n1, double n2);
    delegate void BinaryNumericOperationVoid(double n1, double n2);

    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            //BinaryNumericOperation op = CalculationService.Max;
            BinaryNumericOperation op1 = new BinaryNumericOperation(CalculationService.Max);

            //double result = op(a, b);
            double result = op1.Invoke(a, b);

            Console.WriteLine(result);

            Console.WriteLine("\nMulticast Delegates:");

            BinaryNumericOperationVoid op2 = CalculationService.ShowSum;
            op2 += CalculationService.ShowMax;

            op2(a, b);
            //op2.Invoke(a, b);
        }
    }
}
