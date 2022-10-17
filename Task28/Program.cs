// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int factorial = Factorial(number);
// Console.WriteLine($"Произведение числа от 1 до {number} -> {factorial}");

int Factorial(int num)
{
    int fact = 1;
    int i;
    for (i = 1; i <= num; i++)
    {
        try
        {
            checked
            {
                fact = fact * i;
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Переполнение типа данных!");
            break;
        }    
    }
    Console.WriteLine($"Факториал числа {i - 1} = {fact}");
    return fact;
}