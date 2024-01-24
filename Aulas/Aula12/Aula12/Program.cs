using System;

namespace TypeCast
{
    class Program
    {
        static void Main(string[] args)
        {
            string numero_str = "12";
            int a = Convert.ToInt32(numero_str);

            double numero_dbl = 1.5;
            int b = Convert.ToInt32(numero_dbl);

            int numero_int = 123;
            string c = Convert.ToString(numero_int);

            string caracter = "$";
            char d = Convert.ToChar(caracter);

            string booleano = "true";
            bool e = Convert.ToBoolean(booleano);

            Console.WriteLine(e);
        }
    }
}
