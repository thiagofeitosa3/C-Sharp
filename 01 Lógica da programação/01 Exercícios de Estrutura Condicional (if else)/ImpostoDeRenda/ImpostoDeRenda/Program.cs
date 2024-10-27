using System;
using System.Globalization;

namespace uri1051 //Imposto de Renda

// https://github.com/acenelio/nivelamento-csharp/blob/master/uri1051/uri1051/Program.cs
// https://judge.beecrowd.com/pt/problems/view/1051

{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double imposto = 0.0;

            if (valor <= 2000.00)
            {
                imposto = 0.0;
            }
            else if (valor <= 3000.00)
            {
                imposto = (valor - 2000.00) * 0.08;

            }
            else if (valor <= 4500.00)
            {
                imposto = (valor - 3000.00) * 0.18 + 1000.0 * 0.08;
            }
            else
            {
                imposto = (valor - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
            }
            if (imposto ==  0.0)
            {
                Console.WriteLine("Isento");
            }
            else
            {
                Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}