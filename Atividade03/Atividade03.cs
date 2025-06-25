/* 
    3 - Os pares de instruções abaixo produzem o mesmo resultado?
*/

public class Atividade
{
// A <- (4/2)+(2/4) e A <- 4/2+2/4

    static int ExemploA()
    {
        int A1 = (4 / 2) + (2 / 4);
        int A2 = 4 / 2 + 2 / 4;

        Console.WriteLine($"\nA1: {A1}, A2: {A2}");
        Console.WriteLine($"\n Iguais: {A1==A2}");
        Console.WriteLine("-----------------");

        return 0; // Retorna 1 se forem iguais, 0 caso contrário
    }

    // B <- 4/(2+2)/4 e B <- 4/2+2/4

    static int ExemploB()
    {
        int B1 = 4 / (2 + 2) / 4;
        int B2 = 4 / 2 + 2 / 4;

        Console.WriteLine($"\nB1: {B1}, B2: {B2}");
        Console.WriteLine($"\n Iguais: {B1 == B2}");
        Console.WriteLine($"-----------------");

        return 0;
    }

    // C <- (4+2)*2-4 e C <- 4+2*2-4

    static int ExemploC()
    {
        int C1 = (4 + 2) * 2 - 4;
        int C2 = 4 + 2 * 2 - 4;

        Console.WriteLine($"\nC1: {C1}, C2: {C2}");
        Console.WriteLine($"\n Iguais: {C1 == C2}");
        Console.WriteLine("==========================================================");

        return 0;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Treinando Lógica de Programação - Atividade 03");
        Console.WriteLine("\n==========================================================");

        ExemploA();
        ExemploB();
        ExemploC();
    }

}
