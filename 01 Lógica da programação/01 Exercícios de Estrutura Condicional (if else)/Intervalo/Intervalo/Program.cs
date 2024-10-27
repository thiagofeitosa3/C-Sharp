using System;
using System.Globalization;

namespace uri1037 //Intervalo

// https://github.com/acenelio/nivelamento-csharp/blob/master/uri1037/uri1037/Program.cs
// https://judge.beecrowd.com/pt/problems/view/1037

{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (Valor >= 0 && Valor <= 25.0000)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (Valor >= 25.00001 && Valor <= 50.0000)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if(Valor >= 50.00001 && Valor <= 75.0000)
            {
                Console.WriteLine("Intervalo [50,75]");
            }
            else if (Valor >= 75.00001 && Valor <= 100.0000)
            {
                Console.WriteLine("Intervalo (75,100]");
            }
            else
            {
                Console.WriteLine("Fora de intervalo");
            }
        }
    }
}