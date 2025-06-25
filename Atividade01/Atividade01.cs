/* 
    Escreva um algoritmo que armazene o valor 10 em uma variável A e o valor 20 em uma variável B.
A seguir (utilizando apenas atribuições entre variáveis) troque os seus conteúdos fazendo com que o
valor que está em A passe para B e vice-versa. Ao final, escrever os valores que ficaram armazenados
nas variáveis. 
*/

using System;

class Atividade01
{
    static int A = 10, B= 20; // Inicializa a variável A com o valor 10

    static void TrocarValores()
    {
        int temp = A; // Armazena o valor de A em uma variável temporária
        A = B; // Atribui o valor de B a A
        B = temp; // Atribui o valor temporário (original de A) a B

        Console.WriteLine($"Valor de A após a troca: {A}"); // Exibe o valor de A após a troca
        Console.WriteLine($"Valor de B após a troca: {B}"); // Exibe o valor de B após a troca
    }
    static void Main(string[] args)
    {
        Console.WriteLine($"Valor inicial de A: {A}"); // Exibe o valor inicial de A
        Console.WriteLine($"Valor inicial de B: {B}"); // Exibe o valor inicial de B

        TrocarValores(); // Chama o método para trocar os valores de A e B
    }
}
