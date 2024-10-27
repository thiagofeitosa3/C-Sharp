using System;
using System.Globalization;

namespace uri1072 //Intervalo 2

// https://github.com/acenelio/nivelamento-csharp/blob/master/uri1072/uri1072/Program.cs
// https://judge.beecrowd.com/pt/problems/view/1072

{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int dentro = 0, fora = 0;


            for (int i = 0; i < N; i++)
            {
                int x = int.Parse(Console.ReadLine());

                if (x >= 10 && x <= 20)
                {
                    dentro++;
                }
                else
                {
                    fora++;
                }
            }
            Console.WriteLine(dentro + " in");
            Console.WriteLine(fora + " out");
        }
    }
}