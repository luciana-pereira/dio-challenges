/*
Desafio
Leia um valor inteiro N. Apresente todos os n�meros entre 1 e 10000 que divididos por N d�o resto igual a 2.

Entrada
A entrada cont�m um valor inteiro N (N < 10000).

Sa�da
Imprima todos valores que quando divididos por N d�o resto = 2, um por linha.
*/

import java.io.IOException;
import java.util.Scanner;

public class DIO {
	
	public static void main(String[] args) throws IOException {
    	Scanner leitor = new Scanner(System.in);
    	int N = leitor.nextInt();
    	for (int i =  1; i <  10000; i ++) {
    		if (i %  N  ==  2) System.out.println(i);
    	}
	}
}