// Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

bool CheckNum(int number1, int number2)
{
    return number1 * number1 == number2 || number2 * number2 == number1;
}

Console.Write("Введите число 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());

bool result = CheckNum(num1, num2);

if (result)

    Console.WriteLine($"{num1}, {num2} -> да");

else Console.WriteLine($"{num1}, {num2} -> нет");