// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    var matrix = new int[rows, columns];
    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
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
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4} ");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine(" |");
    }
}

double[] AverageArrayColumn(int[,] array2D)
{
    double[] averageArrayColumn = new double[array2D.GetLength(1)];
    for (int i = 0; i < array2D.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < array2D.GetLength(0); j++)
        {
            sum += array2D[j, i];
        }
        averageArrayColumn[i] = Math.Round(sum / array2D.GetLength(0), 1);
    }
    return averageArrayColumn;
}

void PrintArray(double[] averageArrayColumn)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < averageArrayColumn.Length; i++)
    {
        if (i < averageArrayColumn.Length - 1) Console.Write($"{averageArrayColumn[i]}, ");
        else Console.Write($"{averageArrayColumn[i]}.");
    }
}

int[,] array2D = CreateMatrixRndInt(3, 4, 0, 10);
PrintMatrix(array2D);

double[] averageArrayColumn = AverageArrayColumn(array2D);
PrintArray(averageArrayColumn);

