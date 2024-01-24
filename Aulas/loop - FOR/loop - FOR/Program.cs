namespace loop___FOR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // loop - FOR

            int i;
            int[] num = new int[5];

            for(i=0; i<num.Length; i++)
            {
                num[i] = (i+1) * 5;
                //Console.WriteLine(num[i]);
            }
            for(i=0; i<num.Length; i++)
            {
                Console.WriteLine(num[i]);
            }
        }
    }
}
