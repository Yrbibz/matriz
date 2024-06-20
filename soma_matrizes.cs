using System;
class Program
{
    static void Main()
    {
        int M, N;
        do
        {
            Console.Write("Quantas linhas vai ter cada matriz?: ");
            M = int.Parse(Console.ReadLine());
        } while (M > 10 || M <= 0);
           do {
            Console.Write("Quantas colunas vai ter cada matriz?: ");
            N = int.Parse(Console.ReadLine());
        } while (N > 10 || N <= 0);
        
        int[,] matrizA = new int[M, N];
        int[,] matrizB = new int[M, N];
        int[,] matrizC = new int[M, N];

        Console.WriteLine("Digite os valores da matriz A:");
        LerMatriz(matrizA, M, N);

        Console.WriteLine("Digite os valores da matriz B:");
        LerMatriz(matrizB, M, N);

        SomaMatrizes(matrizA, matrizB, matrizC, M, N);

        Console.WriteLine("Matriz soma: ");
        ImprimirMatriz(matrizC, M, N);
    }
 static void LerMatriz(int[,] matriz, int m, int n)
    {
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("Elemento [" + i + "," + j + "]: ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }

    static void ImprimirMatriz(int[,] matriz, int m, int n)
    {
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
    static void SomaMatrizes(int[,] matrizA, int[,] matrizB, int[,] matrizC, int m, int n)
    {
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrizC[i, j] = matrizA[i, j] + matrizB[i, j];
            }
        } 

    }

