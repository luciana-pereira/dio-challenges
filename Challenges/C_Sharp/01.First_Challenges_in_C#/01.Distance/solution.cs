/*
 Desafio
 Duas motos (X e Y) partem em uma mesma dire��o. A moto X sai com velocidade constante de 60 Km/h
 e a moto Y sai co velocidade constante de 90 Km/h.
 
 Em uma hora (60 minutos) a moto Y consegue se distanciar 30 quil�metros da moto X, ou seja,
 consegue se afastar um quil�metro a cada 2 minutos.
 
 O desafio � ler a dist�ncia (em Km) e calcular quanto tempo leva (em minutos) para moto Y
 tomar essa dist�ncia da outra moto.
 */

using System;

class Desafio
{
    static void Main()
    {
        int quilometros = Int32.Parse(Console.ReadLine());
        int minutos = quilometros * 2; 

        Console.WriteLine(minutos + " minutos");
    }
}