// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberB < 0)

    Console.WriteLine($"Некорректные данные на входе");

else if (numberB == 0)

    Console.WriteLine($"Число {numberA} в степени {numberB} -> 1");

else
{
    {
        int degree = numberA;

        DegreeNumbers(degree);

        void DegreeNumbers(int deg)
        {
            for (int i = 1; i < numberB; i++)
            {
                deg = deg * numberA;
            }
            Console.WriteLine($"Число {numberA} в степени {numberB} -> {deg}");
        }
    }
}