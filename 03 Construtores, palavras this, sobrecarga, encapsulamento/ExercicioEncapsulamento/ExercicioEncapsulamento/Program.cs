using ExercicioEncapsulamento;
using System;
using System.Globalization;

namespace ContaBancaria //Exercicio de encapsulamento

{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valor = 0.0;

            Console.Write("Entre o número da conta: ");
            int conta = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            string inicio = Console.ReadLine();

            if (inicio == "s")
            {
                Console.Write("Entre com o valor de déposito inicial: ");
                valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            Banco b = new Banco(conta, titular, valor);

            Console.ReadLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(b);
            Console.ReadLine();

            Console.Write("Entre um valor para depósito: ");
            double valorAdd = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            b.AdicionarValor(valorAdd);

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(b);
            Console.ReadLine();

            Console.Write("Entre um valor para saque: ");
            valorAdd = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            b.RemoverValor(valorAdd);

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(b);

        }
    }
}