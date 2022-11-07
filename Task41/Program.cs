// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

    Console.Write("Введите числа через пробел: ");
    int[] strArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
    
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

PrintArray(strArr);

int countPositive = CountPositive(strArr);
Console.Write($" -> {countPositive}");