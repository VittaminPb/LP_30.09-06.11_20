// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int Binary(int num)
{
    int tmp = 0;
    int count = 1;
    while (num > 0)
    {
        tmp = tmp + num % 2 * count;
        num = num / 2;
        count = count * 10;
    }
    return tmp;
}

int binary = Binary(number);
Console.WriteLine($"{number} -> {binary}");