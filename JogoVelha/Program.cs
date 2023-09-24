using System.Numerics;

internal class Program
{
    private static void Main(string[] args)
    {
        string[] primeiralinha = new string[3] { "x", "o", "x" };
        string[] segundalinha = new string[3] { "x", "x", "o" };
        string[] terceiralinha = new string[3] { "o", "o", "x" };

        string resultado = Matriz3x3.MatrizTresXTres(primeiralinha, segundalinha, terceiralinha);
        Console.WriteLine(resultado);
        Console.ReadKey();
    }
}

public static class Matriz3x3
{
    public static string MatrizTresXTres(string[] primeiralinha, string[] segundalinha, string[] terceiralinha)
    {
        var matriz = new string[][] { primeiralinha, segundalinha, terceiralinha };

        for (int i = 0; i < matriz.Length; i++)
        {
            for (int x = 0; x < matriz[i].Length; x++)
            {
                Console.Write(matriz[i][x]);
                Console.Write("-");
            }
            Console.WriteLine();
        }

        for (int i = 0; i < 3; i++)
        {
            if (matriz[i][0] == matriz[i][1] && matriz[i][1] == matriz[i][2])
            {
                return "o ganhador na horizontal é: " + matriz[i][0];
            }

            if (matriz[0][i] == matriz[1][i] && matriz[1][i] == matriz[2][i])
            {
                return "o ganhador na vertical é: " + matriz[i][0];
            }

            if (matriz[i][0] == matriz[1][1] && matriz[1][1] == matriz[2 - i][2])
            {
                return "o ganhador na diagonal é: " + matriz[i][0];
            }
        }

        return "";
    }
}