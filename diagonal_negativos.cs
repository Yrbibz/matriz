using System;
class Program
{
    static void Main()
    {
        int N;
        do
        {
            Console.Write("Qual a ordem da matriz ?: ");
            N = int.Parse(Console.ReadLine());
        } while (N > 10 || N <= 0);

        int[,] matriz = new int[N, N];
        LerMatriz(matriz, N);

        Console.WriteLine("Diagonal principal:");
        mdp(matriz, N);

        int negativos = contn(matriz, N);
        Console.WriteLine("Quantidade de negativos: " + negativos);
    } static void LerMatriz(int[,] matriz, int n)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("Elemento [" + i + "," + j + "]: ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }static void mdp(int[,] matriz, int n)
    {
        for (int i = 0; i < n; i++)
        {
            Console.Write(matriz[i, i] + " ");
        }
        Console.WriteLine();
    }static int contn(int[,] matriz, int n)
    {
        int count = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (matriz[i, j] < 0)
                {
                    count++;
                }
            }
        }
      return count;
    }
}
