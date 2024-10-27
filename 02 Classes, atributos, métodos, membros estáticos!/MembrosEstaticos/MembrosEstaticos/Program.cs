using MembrosEstaticos;
using System;
using System.Globalization;

namespace uri1000 //Exercicio

// https://github.com/
// https://judge.beecrowd.com/

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("QUal é a cotação do dólar? ");

            double dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar? ");

            double quant = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double result = ConversorDeMoeda.DolarParaReal(dolar, quant);

            Console.WriteLine("Valor a ser pago em reais = " + result.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}