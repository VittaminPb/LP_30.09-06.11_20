// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

Console.Write("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число C: ");
int numberC = Convert.ToInt32(Console.ReadLine());

bool Triangle(int numA, int numB, int numC)
{
    return(numA < numB + numC && numB < numA + numC && numC < numA + numB);
}

bool triangle = Triangle(numberA, numberB, numberC);

if(triangle) Console.WriteLine("Существование треугольника с заданными сторонами возможно");
else Console.WriteLine("Треугольник с заданными сторонами не существует");