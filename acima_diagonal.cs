using System;
 
class Program
{
    static void Main()
    {
        int N;

        do
        {
            Console.Write("Qual a ordem da matriz (No máximo 10)?: ");
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

        Console.WriteLine();
        Console.WriteLine("Maior elemento de cada linha:");

        for (int i = 0; i < N; i++)
        {
            int maiorElemento = matriz[i, 0];
            for (int j = 1; j < N; j++)
            {
                if (matriz[i, j] > maiorElemento)
                {
                    maiorElemento = matriz[i, j];
                }
            }
            Console.WriteLine(maiorElemento);
        }
    }
}
