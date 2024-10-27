using System;
using System.Globalization;

namespace uri1008 //Salário

// https://github.com/acenelio/nivelamento-csharp/blob/master/uri1008/uri1008/Program.cs
// https://judge.beecrowd.com/pt/problems/index/1

{
    internal class Program
    {
        static void Main(string[] args)
        {
            int NRfun, horas;
            double salario, Vhoras;

            NRfun = int.Parse(Console.ReadLine());
            horas = int.Parse(Console.ReadLine());
            Vhoras = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salario = horas * Vhoras;

            Console.WriteLine("NUMBER = " +  NRfun);
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}