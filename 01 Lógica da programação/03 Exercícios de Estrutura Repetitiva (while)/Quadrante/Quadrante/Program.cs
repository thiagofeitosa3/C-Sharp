using System;
using System.Globalization;

namespace uri1115 //Quadrante

// https://github.com/acenelio/nivelamento-csharp/blob/master/uri1115/uri1115/Program.cs
// https://judge.beecrowd.com/pt/problems/view/1115

{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            string[] vet = Console.ReadLine().Split(' ');
            x = int.Parse(vet[0]);
            y = int.Parse(vet[1]);

            while (x != 0 && y != 0)
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("primeiro");
                }
                else if (x > 0 && y < 0)
                {
                    Console.WriteLine("quarto");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("terceiro");
                }
                else
                {
                    Console.WriteLine("segundo");
                }
                string[] vet1 = Console.ReadLine().Split(' ');
                x = int.Parse(vet1[0]);
                y = int.Parse(vet1[1]);
            }
        }
    }
}