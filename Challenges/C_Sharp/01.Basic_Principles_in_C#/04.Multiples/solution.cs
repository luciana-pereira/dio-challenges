/*
Desafio: m
Leia 2 valores inteiros (A e B). Ap�s, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao Multiplos", 
indicando se os valores lidos s�o m�ltiplos entre si.

Entrada
A entrada cont�m valores inteiros.

Sa�da
A sa�da deve conter uma das mensagens conforme descrito acima.
 
 */
using System;

class minhaClasse
{
    static void Main(string[] args)
    {

        string[] valores = Console.ReadLine().Split(' ');
        int A = int.Parse(valores[0]);
        int B = int.Parse(valores[1]);

        if (A % B == 0 || B % A == 0)
        {
            Console.WriteLine("Sao Multiplos");
        }
        else
        {
            Console.WriteLine("Nao sao Multiplos");
        }
    }
}