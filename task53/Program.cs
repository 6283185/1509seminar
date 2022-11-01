//Задача 53: Задайте двумерный массив.
//Напишите программу, которая поменяет местами
//первую и последнюю строку массива.

Console.Write("Введите количество строк создаваемой матрицы: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов создаваемой матрицы: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] CreateMatrixRndInt(int m, int n, int min, int max)
{
    int[,] matrix = new int[m, n];
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

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void ReplaceFirstOnLastRows(int[,] mtx)
{
    int objTemp = default;
    for (int i = 0; i < mtx.GetLength(1); i++)
    {
        objTemp = mtx[0, i];
        mtx[0, i] = mtx[mtx.GetLength(0) - 1, i];
        mtx[mtx.GetLength(0) - 1, i] = objTemp;

    }
}

int[,] matrix = CreateMatrixRndInt(rows, columns, 0, 10);
PrintArray(matrix);
ReplaceFirstOnLastRows(matrix);
Console.WriteLine();
PrintArray(matrix);
