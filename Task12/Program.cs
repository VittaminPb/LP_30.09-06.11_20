﻿// Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли второе число
// кратным первому. Если число 2 не кратно числу 1, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.Write("Введите число 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int remainder = num1 % num2;

if (remainder == 0)
    Console.WriteLine($"{num1}, {num2} -> кратно");
else Console.WriteLine($"{num1}, {num2} -> не кратно, остаток {remainder}");
