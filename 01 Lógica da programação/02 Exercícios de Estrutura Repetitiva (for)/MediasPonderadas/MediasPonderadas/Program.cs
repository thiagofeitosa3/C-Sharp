using System;
using System.Globalization;

namespace uri1079 //Médias Ponderadas

// https://github.com/acenelio/nivelamento-csharp/blob/master/uri1079/uri1079/Program.cs
// https://judge.beecrowd.com/pt/problems/view/1079

{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                double x = double.Parse(vet[0], CultureInfo.InvariantCulture);
                double y = double.Parse(vet[1], CultureInfo.InvariantCulture);
                double z = double.Parse(vet[2], CultureInfo.InvariantCulture);

                double total = (x * 2.0 + y * 3.0 + z * 5.0) / 10;

                Console.WriteLine(total.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}