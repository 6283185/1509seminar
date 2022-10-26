// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.

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
                Console.Write($"{matrix[i, j],4}, ");
            }
            else Console.Write($"{matrix[i, j],4}");

        }
        Console.WriteLine("]");
    }
}

void MatrixQuadOfEvenIndex(int[,] mtx)
{
    for (int i = 0; i < mtx.GetLength(0); i += 2) //rows
    {
        for (int j = 0; j < mtx.GetLength(1); j += 2) //columns
        {
            mtx[i, j] *= mtx[i, j];
        }
    }
}

int[,] matrixRandom = CreateMatrixRndInt(4, 4, 0, 10);
PrintMatrix(matrixRandom);
System.Console.WriteLine();
MatrixQuadOfEvenIndex(matrixRandom);
PrintMatrix(matrixRandom);
