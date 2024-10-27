using System;
using System.Globalization;

namespace uri1153 //Fatorial Simples

// https://github.com/acenelio/nivelamento-csharp/blob/master/uri1153/uri1153/Program.cs
// https://judge.beecrowd.com/pt/problems/view/1153

{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int fatorial = 1;
            
            for (int i = 1;  i <= N; i++)
            {
                fatorial = fatorial * i;
            }
            Console.WriteLine(fatorial);
        }
    }
}