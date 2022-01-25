/*Desafio
Crie um programa que leia 6 valores, os quais poder�o ser negativos e/ou positivos. 
Em seguida, apresente a quantidade de valores positivos digitados.

Entrada
Voc� receber� seis valores, negativos e/ou positivos.

Sa�da
Exiba uma mensagem dizendo quantos valores positivos foram lidos. assim como � 
exibido abaixo no exemplo de sa�da. N�o se esque�a de incluir na mensagem de sa�da 
o sufixo " valores positivos", conforme o exemplo abaixo:
*/

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
 
public class QtdeNumerosPositivos {
    public static void main(String[] args) throws IOException {
       String linha;
       Double n;
       int Pos, i;
 
       Pos=0;
       BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
       
       for (i=0; i < 6; i++) {
           linha = br.readLine();
           n = Double.parseDouble(linha);
           if(n > 0.0)Pos++;
       }
 
       System.out.println("" + Pos + " valores positivos");
    }
}