using System;
using System.Globalization;

namespace uri1157 //Divisores I

// https://github.com/acenelio/nivelamento-csharp/blob/master/uri1157/uri1157/Program.cs
// https://judge.beecrowd.com/pt/problems/view/1157

{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                if (N % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}