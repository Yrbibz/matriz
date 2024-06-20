using System;
namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            int linha, coluna, i, j;
            Console.Write("Quantas linhas vai ter a matriz? ");
            linha = int.Parse(Console.ReadLine());
            Console.Write("Quantas colunas vai ter a matriz? ");
            coluna = int.Parse(Console.ReadLine());
            int[,] mat = new int[linha, coluna];
            for (i = 0; i < coluna; i++)
            {
                for (j = 0; j < linha; j++)
                {
                    Console.Write("Elemento [" + i + "," + j + "]: ");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine();
            Console.WriteLine("MATRIZ DIGITADA:");
            for (i = 0; i < linha; i++)
            {
                for (j = 0; j < coluna; j++)
                {
                    Console.Write(mat[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}




