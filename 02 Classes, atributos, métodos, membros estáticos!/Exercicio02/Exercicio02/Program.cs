using System;
using System.Globalization;

namespace Exercicio02 //Exercicio 02 do PDF

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario F1 = new Funcionario();
            Funcionario F2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            F1.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            F1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write("Nome: ");
            F2.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            F2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (F1.Salario + F2.Salario) / 2.00;

            Console.WriteLine("Salãrio médio = " + media.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}