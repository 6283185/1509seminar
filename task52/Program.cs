// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("Введите количество строк создаваемой матрицы: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов создаваемой матрицы: ");
int columns = Convert.ToInt32(Console.ReadLine());

//double[] matrix = new double[columns];

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

void PrintMatrix(int[,] mtx)
{

    for (int i = 0; i < mtx.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < mtx.GetLength(1); j++)
        {
            if (j < mtx.GetLength(1) - 1)
            {
                Console.Write($"{mtx[i, j],4}, ");
            }
            else Console.Write($"{mtx[i, j],4}");

        }
        Console.WriteLine("]");
    }
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write($"{array[i], 4}, ");
        }
        else Console.Write($"{array[i], 4}");

    }
    Console.WriteLine("]");
}

double[] AverageOfColumns(int[,] mtx)
{
    double[] matrix = new double[mtx.GetLength(1)];
    for (int j = 0; j < mtx.GetLength(1); j++)
    {
        double sumOfColumn = 0;
        for (int i = 0; i < mtx.GetLength(0); i++)
        {
            sumOfColumn += mtx[i, j];
        }
        matrix[j] = Math.Round(sumOfColumn / mtx.GetLength(0), 1, MidpointRounding.ToZero);
    }
    return matrix;
}



int[,] array2D = CreateMatrixRndInt(rows, columns, -10, 10);
PrintMatrix(array2D);
System.Console.WriteLine();
System.Console.WriteLine("Среднее арифметическое столбцов.");
System.Console.WriteLine("--------------------------------");
PrintArray(AverageOfColumns(array2D));

