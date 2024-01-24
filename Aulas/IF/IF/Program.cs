using System;

namespace IF
{
    class Program
    {
        static void Main(string[] args)
        {
            // operadores relacional
            /*
             == : igual
             != : diferente
             >  : maior
             >= : maior-igual
             <  : menor
             <= : menor-igual
            */

            // Operadores logicos
            /*
             && : E ou AND
             || : Ou ou OR
             !  : Nao ou NOT ou Inversora
            */

            // IF

            int x = 11;
            int y = 5;

            if (x == 10)
            {
                Console.WriteLine("x igual de 10");
            }
            else if (x == 11)
            {
                Console.WriteLine("x igual a 11");
            }
            else
            {
                Console.WriteLine("x diferente de 10");
            }

            // outra forma de fazer um IF simples

            Console.WriteLine(x > y ? "x maior que y" : "x menor que y");
        }
    }
}
