// Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти");
string quarter = Console.ReadLine();

string result = Range(quarter);
Console.WriteLine(result);

string Range(string quart)
{
    if (quart == "1") return "x - положительные, y - положительные";
    if (quart == "2") return "x - отрицательные, y - положительные";
    if (quart == "3") return "x - отрицательные, y - отрицательные";
    if (quart == "4") return "x - положительные, y - отрицательные";
    return "некорректный ввод";
}
