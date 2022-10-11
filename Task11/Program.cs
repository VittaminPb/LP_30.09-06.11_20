// Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число из диапазона 1 - 999 => {number}");

// int firstDigit = number / 100; // 456 / 100 = 4
// int thirdDigit = number % 10; // 456 % 10 = 6
// int splitNumber = firstDigit * 10 + thirdDigit;

// Console.WriteLine($"Число из крайних цифер => {splitNumber}");

int SplitNumber(int num)
{
    int firstDigit = number / 100; // 456 / 100 = 4
    int thirdDigit = number % 10;
    int splitNumber = firstDigit * 10 + thirdDigit;
    return splitNumber;
}

int splitNumber = SplitNumber(number);
Console.WriteLine($"Число из крайних цифер => {splitNumber}");