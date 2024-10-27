using System;
using System.Globalization;

namespace uri1007 //Diferença

// https://github.com/acenelio/nivelamento-csharp/blob/master/uri1007/uri1007/Program.cs
// https://judge.beecrowd.com/pt/problems/view/1007

{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, D, DIFERENCA;
            A =int.Parse(Console.ReadLine());
            B =int.Parse(Console.ReadLine());
            C =int.Parse(Console.ReadLine());
            D =int.Parse(Console.ReadLine());
            DIFERENCA = (A*B) - (C*D);
            Console.WriteLine("DIFERENCA = " + DIFERENCA);
        }
    }
}