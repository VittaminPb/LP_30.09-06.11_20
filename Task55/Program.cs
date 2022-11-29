// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.


// добавить и вывод создание массива
void PrintRowsColumsIndex(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = i; j < matrix.GetLength(1); j++)
{
int temp = matrix[i, j];
matrix[i, j] = matrix[j, i];
matrix[j, i] = temp;
}

}
}
int[,] array2D = CreateMatrixRndInt(4, 4, 1, 10);
if (array2D.GetLength(0) == array2D.GetLength(1))
{
PrintMatrix(array2D);
Console.WriteLine("");
PrintRowsColumsIndex(array2D);
PrintMatrix(array2D);
}
else Console.Write("невозможно");