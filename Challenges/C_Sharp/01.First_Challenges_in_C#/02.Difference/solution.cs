/*
 * Desafio: Diferen�a
 * Leia quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferen�a
 * do produto de A e B pelo produto de C e D segundo a f�rmula:
 * DIFERENCA=(A * B - C * D).
 */

using System;

namespace Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            int D = int.Parse(Console.ReadLine());

            Console.WriteLine("DIFERENCA = " + (A * B - C * D));
            Console.ReadKey();
        }
    }
}
