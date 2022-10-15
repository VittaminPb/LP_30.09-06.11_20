// Напишите программу, которая принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 10000 || number > 99999)

    Console.WriteLine("Ошибка ввода данных");

else 
{
    int n1 = number / 10000;
    int n2 = number / 1000 % 10;
    int n3 = number / 100 % 10;
    int n4 = number / 10 % 10;
    int n5 = number % 10;

    if (n1 == n5 && n2 == n4)
        Console.WriteLine($"{number} -> Да");
    else Console.WriteLine($"{number} -> Нет");
}