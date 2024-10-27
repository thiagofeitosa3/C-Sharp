using System;
using System.Globalization;

namespace uri1044 //Múltiplos

// https://github.com/acenelio/nivelamento-csharp/blob/master/uri1044/uri1044/Program.cs
// https://judge.beecrowd.com/pt/problems/view/1044

{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B;
            double Max, Min, resto1, resto2;
            Max = 0.0;
            Min = 0.0;

            string[] vet = Console.ReadLine().Split(' ');
            A = int.Parse(vet[0]);
            B = int.Parse(vet[1]);

            if (A < B)
            {
                Min = A;
                Max = B;

                if (Max % Min == 0)
                {
                    Console.WriteLine("Sao Multiplos");
                }
                else
                {
                    Console.WriteLine("Nao sao Multiplos");
                }
            }
            else if (A > B)
            {
                Min = B;
                Max = A;

                if (Max % Min == 0)
                {
                    Console.WriteLine("Sao Multiplos");
                }
                else
                {
                    Console.WriteLine("Nao sao Multiplos");
                }
            }



        }
    }
}