// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите целое число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите целое число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int sum = 0;
int SumNaturalNumbers(int numM, int numN)
{
    if (numM < numN)
    {
        sum = numN - 1;
        SumNaturalNumbers(numM, numN - 1);
        sum += numN;
    }
    if (numM > numN)
    {
        sum = numN + 1;
        SumNaturalNumbers(numM, numN + 1);
        sum = sum + numN;
    }  
    if (numM == numN) return numN;
    return sum;
}

int sumNaturalNumbers = SumNaturalNumbers(numberM, numberN);
Console.Write($"M = {numberM}; N = {numberN} -> {sumNaturalNumbers}");