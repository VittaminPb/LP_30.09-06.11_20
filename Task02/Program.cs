﻿// Напишите программу, которая на вход принимает два числа и 
// выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2; b = 10 -> max = 10
// a = -9; b = -3 -> max = -3

Console.Write("Введите число 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 == num2)

    Console.WriteLine("числа равны");
 else
    if (num1 > num2)
        Console.WriteLine($"число {num1} > числа {num2}");
    else Console.WriteLine($"число {num2} > числа {num1}");
