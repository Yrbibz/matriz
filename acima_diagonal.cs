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
        } while (N > 10);

        int[,] matriz = new int[N, N];

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write("Elemento [" + i + "," + j + "]: ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }
        int soma = 0;
        for (int i = 0; i < N; i++)
        {
            for (int j = i + 1; j < N; j++)
            {
                soma += matriz[i, j];
            }
        }

        Console.WriteLine("Soma dos elementos acima da diagonal principal: " + soma);
    }
