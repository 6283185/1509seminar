// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) //rows
    {
        for (int j = 0; j < matrix.GetLength(1); j++) //columns
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1)
            {
                Console.Write($"{matrix[i, j], 4}, ");
            }
            else Console.Write($"{matrix[i, j], 4}");

        }
        Console.WriteLine("]");
    }   
}

int GetSumDiagonalElements(int[,] mtx)
{
    int sum = default;
    for (int i = 0; i < mtx.GetLength(0); i++) //rows
    {
        for (int j = 0; j < mtx.GetLength(1); j++) //columns
        {
            if (i == j) sum += mtx[i, j];
        }
    }

    return sum;
}



int[,] array2D = CreateMatrixRndInt(4, 4, 0, 10);
PrintMatrix(array2D);
int result = GetSumDiagonalElements(array2D);
Console.WriteLine($"Сумма элементов находящихся на главной диагонали матрицы равна: {result}.");

// int[,] myArray = CreateMatrix(4, 3, 1, 9);
// PrintMatrix(myArray);
// Console.WriteLine();
// Console.WriteLine($"{SummOfEqualIndex(myArray)}");


// int SummOfEqualIndex(int[,] matrix)
// {
// int sum = default;
// int targetSize = 0;
// if ( matrix.GetLength(0) > matrix.GetLength(1)) targetSize = 1;
// for (int i = 0; i < matrix.GetLength(targetSize); i++)
// {
// sum += matrix[i, i];
// }
// return sum;
// }