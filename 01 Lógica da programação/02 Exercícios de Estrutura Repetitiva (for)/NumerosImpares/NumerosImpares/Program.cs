using System;
using System.Globalization;

namespace uri1067 //Números Ímpares

// https://github.com/acenelio/nivelamento-csharp/blob/master/uri1067/uri1067/Program.cs
// https://judge.beecrowd.com/pt/problems/view/1067

{
    internal class Program
    {
        static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine());

            for (int i = 1;  i <= X; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}