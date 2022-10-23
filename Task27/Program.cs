// Задача 27: Напишите программу, которая принимает на вход число и 
// выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sumOfDigits = SumOfDigits(number);
Console.WriteLine($"Сумма цифр в числе {number} -> {sumOfDigits}");

int SumOfDigits(int num)
{
    int sumOfD = 0;
    while (num > 0)
    {
        sumOfD = sumOfD + num % 10;
        num /= 10;
    }
    return sumOfD;
}
