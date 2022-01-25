/*
 *Leia 3 valores, no caso, variáveis A, B e C, que são as três notas de um aluno. 
 *A seguir, calcule a média do aluno, sabendo que a nota A tem peso 2, a nota B tem peso 3 
 *e a nota C tem peso 5. Considere que cada nota pode ir de 0 até 10.0, sempre com uma casa decimal.
 */

using System;

namespace Start
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C;

            A = Convert.ToDouble(Console.ReadLine());
            B = Convert.ToDouble(Console.ReadLine());
            C = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("MEDIA = " + ((A / 10 * 2) + (B / 10 * 3) + (C / 10 * 5)).ToString("0.0"));
            Console.ReadKey();
        }
    }
}