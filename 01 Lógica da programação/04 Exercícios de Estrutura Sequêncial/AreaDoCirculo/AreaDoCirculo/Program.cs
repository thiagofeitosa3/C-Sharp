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
            double pi, raio, area;
            pi = 3.14159;

            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = Math.Pow(raio, 2) * pi;

            Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));

        }
    }
}