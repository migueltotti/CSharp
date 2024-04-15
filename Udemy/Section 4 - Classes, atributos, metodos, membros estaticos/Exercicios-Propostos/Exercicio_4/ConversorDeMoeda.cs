using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_4
{
    internal static class ConversorDeMoeda
    {
        public static double IOF = 0.06;

        public static double Conversao(double dolar, double quantidade)
        {
            return (dolar * quantidade) + ((dolar * quantidade) * IOF);
        }

    }
}
