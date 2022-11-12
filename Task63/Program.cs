// Задача 63: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

Console.Write("Введите целое число N: ");
int number = Convert.ToInt32(Console.ReadLine());

void NaturalNumbers (int num) // метод рекурсии
{
    if(num == 0) return;
    NaturalNumbers(num - 1); // вызов рекурсии
    Console.Write($"{num} ");
}

Console.Write($"N = {number} -> ");
NaturalNumbers(number);