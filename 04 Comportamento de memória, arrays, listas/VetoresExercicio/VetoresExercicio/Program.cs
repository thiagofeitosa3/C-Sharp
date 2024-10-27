using System;
using System.Globalization;
using VetoresExercicio;

namespace uri1000 //Exercicio

// https://github.com/
// https://judge.beecrowd.com/

{
    internal class Program
    {
        static void Main(string[] args)
        {

            Cadastro[] cadastro = new Cadastro[10];

            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Aluguel #" + i + ":");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                cadastro[quarto] = new Cadastro(nome, email);
                Console.ReadLine();
            }
            Console.WriteLine("Quarto ocupados:");

            for (int i = 0;i < 10; i++)
            {
                if (cadastro[i] != null)
                {
                    Console.WriteLine(i + ": " + cadastro[i]);
                }
            }
        }
    }
}