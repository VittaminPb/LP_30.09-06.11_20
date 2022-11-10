// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

Console.Write("Введите позицию 1: ");
int row = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите позицию 2: ");
int column = Convert.ToInt32(Console.ReadLine());

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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],2}, ");
            else Console.Write($"{matrix[i, j],2}");
        }
        Console.WriteLine(" |");
    }
}

bool CheckCorrect(int[,] array2D)
{
    return(row >= 0 && row < array2D.GetLength(0) && column >= 0 && column < array2D.GetLength(1));
}

int[,] array2D = CreateMatrixRndInt(3, 4, 0, 10);
PrintMatrix(array2D);

bool checkCorrect = CheckCorrect(array2D);

if (checkCorrect) Console.WriteLine($"{row}, {column} -> {array2D[row, column]}");
else Console.WriteLine($"{row}, {column} -> Элемента с таким индексом не существует в данном массиве");