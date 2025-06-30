/*
    4 - Reescreva as instruções abaixo com o mínimo de parênteses possível, mas sem alterar o
resultado:
*/

public class Atividade04()
{

    static void Main(string[] args)
    {

        /*
            A <- 6*(3+2)
        */

        int A = 6 * 3;
        A += 6 * 2; // Simplificando A = 6 * 3 + 6 * 2

        /*
            B <- 2+(6*(3+2))
        */

        int B = 6 * 3;
        B += 6 * 2;
        B += 2; // Simplificando B = 2 + 6 * 3 + 6 * 2

        /*
            C <- 2+(3*6)/(2+4)
        */

        int C = 3 * 6;
        C /= 2 + 4;
        C += 2; // Simplificando C = 2 + (3 * 6) / (2 + 4)


        /*
            D <- 2*(8/(3+1))
        */

        int D = 8 / (3 + 1);
        D *= 2; // Simplificando D = 2 * (8 / (3 + 1))

        /*
            E <- 3+(16-2)/(2*(9-2)) 
        */

        int E = 16 - 2;
        E /= 2 * 9 - 2 * 2;
        E += 3; // Simplificando E = 3 + (16 - 2) / (2 * (9 - 2))

        /*
            F <- (6/3)+(8/2) 
        */

        int F = 6 / 3;
        F += 8 / 2; // Simplificando F = (6 / 3) + (8 / 2)

        /*
            G <- ((3+(8/2))*4)+(3*2)
        */

        int G = 8 / 2;
        G *= 4;
        G += 3;
        G += 3 * 2; // Simplificando G = ((3 + (8 / 2)) * 4) + (3 * 2)

        /*
            H <- (6*(3*3)+6)-10
        */

        int H = 6 * 3;
        H *= 6 * 3;
        H += 6;
        H -= 10; // Simplificando H = (6 * (3 * 3) + 6) - 10

        /*
            I <- (((10*8)+3)*9)
        */

        int I = 10 * 8;
        I += 3;
        I *= 9; // Simplificando I = (((10 * 8) + 3) * 9)

        /*
            J <- ((-12)*(-4))+(3*(-4)) 
        */

        int J = -12 * -4;
        J += 3 * -4; // Simplificando J = ((-12) * (-4)) + (3 * (-4))

        // Exibindo os resultados
        Console.WriteLine("Resultados:");
        Console.WriteLine($"A: {A}");
        Console.WriteLine($"B: {B}");
        Console.WriteLine($"C: {C}");
        Console.WriteLine($"D: {D}");
        Console.WriteLine($"E: {E}");
        Console.WriteLine($"F: {F}");
        Console.WriteLine($"G: {G}");
        Console.WriteLine($"H: {H}");
        Console.WriteLine($"I: {I}");
        Console.WriteLine($"J: {J}");
    }

}