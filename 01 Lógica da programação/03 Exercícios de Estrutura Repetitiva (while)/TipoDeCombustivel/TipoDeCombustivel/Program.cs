using System;
using System.Globalization;

namespace uri1134 //Tipo de Combustível

// https://github.com/acenelio/nivelamento-csharp/blob/master/uri1134/uri1134/Program.cs
// https://judge.beecrowd.com/pt/problems/view/1134

{
    internal class Program
    {
        static void Main(string[] args)
        {
           int x = int.Parse(Console.ReadLine());
            int diesel = 0, gasolina = 0, alcool = 0;
            
            while (x != 4) {
                if (x == 1)
                {
                    alcool++;
                }
                else if (x == 2)
                {
                    gasolina++;
                }
                else if (x == 3)
                {
                    diesel++;
                }
                x = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
        }
    }
}