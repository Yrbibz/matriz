using System;

class Program
{
    static void Main()
    {
        int linha, coluna;

        Console.Write("Quantas linhas vai ter a matriz? ");
        linha = int.Parse(Console.ReadLine());

        Console.Write("Quantas colunas vai ter a matriz? ");
        coluna = int.Parse(Console.ReadLine());

        double[,] mat = new double[linha, coluna];
        double[] somaLinhas = new double[linha];

        for (int i = 0; i < linha; i++)
        {
            Console.WriteLine("Digite o elemento da " + (i + 1) + "ª linha");
            for (int j = 0; j < coluna; j++)
            {
                mat[i, j] = double.Parse(Console.ReadLine());
            }
        }

        for (int i = 0; i < linha; i++)
        {
            somaLinhas[i] = 0;
            for (int j = 0; j < coluna; j++)
            {
                somaLinhas[i] += mat[i, j];
            }
        }

        Console.WriteLine();
        Console.WriteLine("Vetor gerado: ");
        for (int i = 0; i < linha; i++)
        {
            Console.WriteLine(somaLinhas[i]);
        }
    }
}

