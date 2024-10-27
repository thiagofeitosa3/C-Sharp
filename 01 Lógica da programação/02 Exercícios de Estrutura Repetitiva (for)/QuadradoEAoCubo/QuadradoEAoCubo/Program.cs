using System;
using System.Globalization;

namespace uri1143 //Quadrado e ao Cubo

// https://github.com/acenelio/nivelamento-csharp/blob/master/uri1143/uri1143/Program.cs
// https://judge.beecrowd.com/pt/problems/view/1143

{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 1;  i <= N; i++)
            {
                int a = i * i;
                int b = i * i * i;
                Console.Write(i + " ");
                Console.Write(a + " ");
                Console.Write(b);
                Console.WriteLine();
            }
        }
    }
}