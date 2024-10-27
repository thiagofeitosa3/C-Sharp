using System;
using System.Globalization;

namespace uri1046 //Tempo de Jogo

// https://github.com/acenelio/nivelamento-csharp/blob/master/uri1046/uri1046/Program.cs
// https://judge.beecrowd.com/pt/problems/view/1046

{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            int inicio = int.Parse(vet[0]);
            int final = int.Parse(vet[1]);
            int horas;

            if (inicio < final)
            {
                horas = final - inicio;
            }
            else
            {
                horas = 24 - inicio + final;
            }
            Console.WriteLine("O JOGO DUROU " + horas + " HORA(S)");
        }
    }
}