// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

void Fibonacci(int num)
{
    int digA = 0;
    int digB = 1;
    Console.Write($"Если N = {num} -> {digA} {digB} ");
    for (int i = 2; i < num; i++)
    {
        digB = digB + digA;
        Console.Write($"{digB} ");
        digA = digB - digA;
    }
}

Fibonacci(number);