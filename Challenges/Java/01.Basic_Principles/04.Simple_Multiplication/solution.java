/*
Desafio
Voc� receber� dois valores inteiros. Fa�a a leitura e em seguida calcule o produto entre estes dois 
valores. Atribua esta opera��o � vari�vel PROD, mostrando esta de acordo com a mensagem de 
sa�da esperada (exemplo abaixo).   

Entrada
A entrada cont�m 2 valores inteiros.

Sa�da
Exiba a vari�vel PROD conforme exemplo abaixo, tendo obrigatoriamente um espa�o em branco 
antes e depois da igualdade.
*/

import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		
		int A, B, PROD;
		
		A = sc.nextInt();
		B = sc.nextInt();
		
		PROD = A * B; 
		
		System.out.println("PROD = " + PROD);
		
		sc.close();
		
	}

}