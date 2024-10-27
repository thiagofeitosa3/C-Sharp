using System;
using System.Globalization;

namespace cond02 //Exercicio 02

// https://github.com/acenelio/nivelamento-csharp/blob/master/cond02/cond02/Program.cs

{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());

            if (A % 2 == 0)
            {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.WriteLine("IMPAR");
            }
        }
    }
}