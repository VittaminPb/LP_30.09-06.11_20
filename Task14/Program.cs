// Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());

// if (num % 7 == 0 && num %23 == 0)            // решение через if else
//     Console.WriteLine($"{num} -> да");
// else Console.WriteLine($"{num} -> нет");

bool CheckNum(int number)
{
    return number % 7 == 0 && number % 23 == 0;
}

bool result = CheckNum(num);
if (result)
    Console.WriteLine($"{num} -> да");
else Console.WriteLine($"{num} -> нет");