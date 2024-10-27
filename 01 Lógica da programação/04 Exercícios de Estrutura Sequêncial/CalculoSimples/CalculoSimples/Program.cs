using System;
using System.Globalization;

namespace uri1010 //Cálculo Simples

// https://github.com/acenelio/nivelamento-csharp/blob/master/uri1010/uri1010/Program.cs
// https://judge.beecrowd.com/pt/problems/view/1010

{
    internal class Program
    {
        static void Main(string[] args)
        {
            int CodPeca1, CodPeca2, NRPeca1, NRPeca2;
            double ValorPeca1, ValorPeca2, ValorPagar;

            string[] vet = Console.ReadLine().Split(' ');
            CodPeca1 = int.Parse(vet[0]);
            NRPeca1 = int.Parse(vet[1]);
            ValorPeca1 = double.Parse(vet[2], CultureInfo.InvariantCulture);

            string[] vet2 = Console.ReadLine().Split(' ');
            CodPeca2 = int.Parse(vet2[0]);
            NRPeca2 = int.Parse(vet2[1]);
            ValorPeca2 = double.Parse(vet2[2], CultureInfo.InvariantCulture);

            ValorPagar = (NRPeca1 * ValorPeca1) + (NRPeca2 * ValorPeca2);

            Console.WriteLine("VALOR A PAGAR: R$ " + ValorPagar.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}