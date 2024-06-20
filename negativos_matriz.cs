using System;

{
    int linha, coluna;

    Console.Write("Digite o número de linhas da matriz (máximo 10): ");
    linha = int.Parse(Console.ReadLine());
    if (linha > 10) linha = 10;

    Console.Write("Digite o número de colunas da matriz (máximo 10): ");
    coluna = int.Parse(Console.ReadLine());
    if (coluna > 10) coluna = 10;

    int[,] matriz = new int[linha, coluna];

    for (int i = 0; i < linha; i++)
    {
        for (int j = 0; j < coluna; j++)
        {
            Console.Write("Elemento: ");
            matriz[i, j] = int.Parse(Console.ReadLine());
        }
    }

    Console.WriteLine();
    Console.WriteLine("Valores Negativos:");

    bool hasNegatives = false;
    for (int i = 0; i < linha; i++)
    {
        for (int j = 0; j < coluna; j++)
        {
            if (matriz[i, j] < 0)
            {
              
                Console.WriteLine(matriz[i, j]);
                hasNegatives = true;
            }
        }
    }
}
    
