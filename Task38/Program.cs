// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndDouble(int size, int min, int max)
{
    var array = new double[size];
    var rnd = new Random();

    for (int i = 0; i < size; i++)
    {

        array[i] = Math.Round((rnd.NextDouble() * (max - min) + min), 1);
    }
    return array;
}
void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}

double FindMaxArrayElement(double[] array)
{
    double findmax = array[0];
        for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > findmax) findmax = array[i];
    }
    return findmax;
}

double FindMinArrayElement(double[] array)
{
    double findmin = array[0];
        for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < findmin) findmin = array[i];
    }
    return findmin;
}

double[] array = CreateArrayRndDouble(5, 0, 9);
PrintArray(array);

double findMaxArrayElement = FindMaxArrayElement(array);
double findMinArrayElement = FindMinArrayElement(array);

Console.Write($" -> {Math.Round((findMaxArrayElement - findMinArrayElement), 1)}");