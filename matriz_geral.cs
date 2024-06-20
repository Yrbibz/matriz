using System;

class Program
{
    static void Main()
    {
        int N;

        do
        {
            Console.Write("Qual a ordem da matriz?: ");
            N = int.Parse(Console.ReadLine());
        } while (N > 10 || N <= 0);

        double[,] matriz = new double[N, N];

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write("Elemento [" + i + "," + j + "]: ");
                matriz[i, j] = double.Parse(Console.ReadLine());
            }
        }

        double somapo = 0;
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                if (matriz[i, j] > 0)
                {
                    somapo += matriz[i, j];
                }
            }
        }
        Console.WriteLine("Soma dos positivos: " + somapo);


        Console.Write("Escolha uma linha: ");
        int linha = int.Parse(Console.ReadLine());

        if (linha >= 0 && linha < N)
        {
            Console.Write("Linha escolhida: ");
            for (int j = 0; j < N; j++)
            {
                Console.Write(matriz[linha, j] + " ");
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Índice de linha inválido.");
        }

        Console.Write("Escolha uma coluna: ");
        int coluna = int.Parse(Console.ReadLine());

        if (coluna >= 0 && coluna < N)
        {
            Console.Write("Coluna escolhida: ");
            for (int i = 0; i < N; i++)
            {
                Console.Write(matriz[i, coluna] + " ");
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Índice de coluna inválido.");
        }

        Console.Write("Diagonal principal: ");
        for (int i = 0; i < N; i++)
        {
            Console.Write(matriz[i, i] + " ");
        }
        Console.WriteLine();

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                if (matriz[i, j] < 0)
                {
                    matriz[i, j] = Math.Pow(matriz[i, j], 2);
                }
            }
        }

        Console.WriteLine("Matriz alterada:");
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
