using System;
using System.Globalization;

namespace cod01 //Exercicio 01

// https://github.com/acenelio/nivelamento-csharp/blob/master/cond01/cond01/Program.cs

{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());

            if (A < 0)
            {
                Console.WriteLine("NEGATIVO");
            }
            else
            {
                Console.WriteLine("NÃO NEGATIVO");
            }
        }
    }
}