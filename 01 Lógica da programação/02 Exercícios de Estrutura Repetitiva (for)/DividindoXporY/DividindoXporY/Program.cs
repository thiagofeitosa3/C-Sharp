using System;
using System.Globalization;

namespace uri1116 //Dividindo X por Y

// https://github.com/acenelio/nivelamento-csharp/blob/master/uri1116/uri1116/Program.cs
// https://judge.beecrowd.com/pt/problems/view/1116

{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
           
            for (int i = 0; i < N; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                int x = int.Parse(vet[0]);
                int y = int.Parse(vet[1]);

                if (y == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    double resultado = (double)x / y;
                    Console.WriteLine(resultado.ToString("F1", CultureInfo.InvariantCulture));
                }

            }
        }
    }
}