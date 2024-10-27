using System;
using System.Globalization;

namespace uri1002 //Área do Círculo

// https://github.com/acenelio/nivelamento-csharp/blob/master/uri1002/uri1002/Program.cs
// https://judge.beecrowd.com/pt/problems/view/1002

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (x >= 0.0)
            {
                

                double raiz = Math.Sqrt(x);
                Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
                Console.Write("Digite um número: ");
                x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            Console.WriteLine("Número negativo!");

        }
    }
}