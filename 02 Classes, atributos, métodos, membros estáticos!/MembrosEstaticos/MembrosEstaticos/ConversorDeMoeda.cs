using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembrosEstaticos
{
    internal class ConversorDeMoeda
    {
        public static double iof = 6.0;
        
        public static double DolarParaReal(double quant, double dolar)
        {
            double total = quant * dolar;
            return total + total * iof / 100.0;
        }
    }
}
