using System;

// 2 -  Analise os algoritmos abaixo e diga o que será impresso na tela ao serem executados:


public class Atividade02
{
    static int A = 0, B = 0, C = 0, X = 0, Y = 0, Z = 0;  // Economia de memória, declarando variáveis globais

    /* 
    a) 
        A <- 10
        B <- 20 
        Escrever B
        B <- 5
        Escrever A, B
    */


    static int AlternativaA()
    {
        A = 10; // Inicializa a variável A com o valor 10
        B = 20; // Inicializa a variável B com o valor 20

        Console.WriteLine("--- Exemplo A ---");
        Console.WriteLine($"\nB: {B};"); // Imprime o valor de B, que é 20
        B = 5; // Atribui o valor 5 à variável B
        Console.WriteLine($"\nA: {A}, B: {B}."); // Imprime os valores de A e B, que são 10 e 5, respectivamente
        Console.WriteLine("\n------------------");

        return 0; // Retorna 0, indicando que a função foi executada com sucesso
    }

    /* 
        b) 
            A <- 30
            B <- 20 
            C <- A + B
            Escrever C
            B <- 10
            Escrever B, C
            C <- A + B
            Escrever A, B, C
    */

    static int AlternativaB()
    {
        Console.Write("--- Exemplo B ---");
        A = 30;
        B = 20;
        C = A + B;
        Console.WriteLine($"\nC: {C}");
        B = 10;
        Console.WriteLine($"\nB: {B}, C: {C}");
        C = A + B;
        Console.WriteLine($"\nA: {A}, B: {B}, C: {C}");
        Console.WriteLine("\n------------------");

        return 0;
    }

    /* 
        c) 
            A <- 10
            B <- 20 
            C <- A
            B <- C
            A <- B
            Escrever A, B, C
    */
    static int AlternativaC()
    {
        Console.WriteLine("--- Exemplo C ---");
        A = 10;
        B = 20;
        C = A; // C recebe o valor de A
        B = C; // B agora recebe o valor de C
        A = B; // A agora recebe o valor de B
        Console.WriteLine($"\nA: {A}, B: {B}, C: {C}");
        Console.WriteLine("\n------------------");

        return 0;
    }

    /*
        d) 
            A <- 10
            B <- A + 1 
            A <- B + 1
            Escrever A
            A <- B + 1 
            Escrever A, B
    */

    static int AlternativaD()
    {
        Console.WriteLine("--- Exemplo D ---");
        A = 10;
        B = A + 1;
        A = B + 1;
        Console.WriteLine($"\nA: {A}");
        A = B + 1;
        Console.WriteLine($"\nA: {A}, B: {B}");
        Console.WriteLine("\n------------------");

        return 0;
    }

    /* 
       e)
            A <- 10
            B <- 5
            C <- A + B
            B <- 20
            A <- 10
            Escrever A, B, C
    */

    static int AlternativaE()
        {
        Console.WriteLine("--- Exemplo E ---");
        A = 10;
        B = 5;
        C = A + B;
        B = 20;
        A = 10;
        Console.WriteLine($"\nA: {A}, B: {B}, C: {C}");
        Console.WriteLine("\n------------------");

        return 0;
        }
    /*
        f)
            X <- 1
            Y <- 2
            Z <- Y - X
            Escrever Z
            X <- 5
            Y <- X + Z
            Escrever X, Y, Z
    */

    static int AlternativaF() {
        Console.WriteLine("--- Exemplo F ---");
        X = 1;
        Y = 2;
        Z = Y - X; 
        Console.WriteLine($"\nZ: {Z}"); 
        X = 5; 
        Y = X + Z; 
        Console.WriteLine($"\nX: {X}, Y: {Y}, Z: {Z}");
        Console.WriteLine("\n------------------");

        return 0;
    }

    // Método principal que executa todos os exemplos
    static void Main(string[] args)
    {
        Console.WriteLine("Atividade 02 - Análise de Algoritmos");
        Console.WriteLine("====================================\n");
        AlternativaA();
        AlternativaB();
        AlternativaC();
        AlternativaD();
        AlternativaE();
        AlternativaF();
    }
}