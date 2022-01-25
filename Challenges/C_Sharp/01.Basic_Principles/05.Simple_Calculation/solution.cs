/*
Desafio: C�lculo Simples
Neste problema, deve-se ler o c�digo de uma pe�a 1, o n�mero de pe�as 1, o valor unit�rio de cada pe�a 1, 
o c�digo de uma pe�a 2, o n�mero de pe�as 2 e o valor unit�rio de cada pe�a 2. Ap�s, calcule e mostre o 
valor a ser pago.

Entrada
O arquivo de entrada cont�m duas linhas de dados. Em cada linha haver� 3 valores, respectivamente dois 
inteiros e um valor com 2 casas decimais.

Sa�da
A sa�da dever� ser uma mensagem conforme o exemplo fornecido abaixo, lembrando de deixar um espa�o ap�s 
os dois pontos e um espa�o ap�s o "R$". O valor dever� ser apresentado com 2 casas ap�s o ponto.
 */
using System;

class DIO
{

    static void Main(string[] args)
    {
        string[] input;

        input = Console.ReadLine().Split(' ');
        int cod1 = int.Parse(input[0]);
        int n1 = int.Parse(input[1]);
        double valor1 = double.Parse(input[2]);
        input = Console.ReadLine().Split(' ');
        int cod2 = int.Parse(input[0]);
        int n2 = int.Parse(input[1]);
        double valor2 = double.Parse(input[2]);

        double total = (n1 * valor1) + (n2 * valor2);
        Console.WriteLine("VALOR A PAGAR: R$ {0:F2}", total);
    }

}