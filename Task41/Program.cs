// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Write("Сколько будет чисел? ");
int number = Convert.ToInt32(Console.ReadLine());

int[] CreateArray(int num)
{
    Console.Write("Введите числа через пробел: ");
    int[] arr = new int[number];
    string[] input = Console.ReadLine().Split(' ');

    for (int i = 0; i < arr.Length; ++i)
        arr[i] = int.Parse(input[i]);
    return arr;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i < (array.Length - 1)) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
}

int CountPositive(int[] arr)
{
    int count = default;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0) count++;
    }
    return count;
}

int[] array = CreateArray(number);
PrintArray(array);

int countPositive = CountPositive(array);
Console.Write($" -> {countPositive}");