using System;
using System.Globalization;

namespace uri1114 //Senha Fixa

// https://github.com/acenelio/nivelamento-csharp/blob/master/uri1114/uri1114/Program.cs
// https://judge.beecrowd.com/pt/problems/view/1114

{
    internal class Program
    {
        static void Main(string[] args)
        {
            int acesso = 2002, senha;

            senha = int.Parse(Console.ReadLine());
            while (acesso != senha)
            {
                Console.WriteLine("Senha Invalida");
                senha = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso Permitido");
        }
    }
}