using Exercicio04;
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
            Funcionario fun = new Funcionario();

            Console.Write("Nome: ");
            fun.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            fun.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            fun.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(fun);

            Console.Write("Digite a porcentagem para aumentar o salário: ");

            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            fun.AumentarSalario(porcentagem);

            Console.WriteLine(fun);

        }
    }
}