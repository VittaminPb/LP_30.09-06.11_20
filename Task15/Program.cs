// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, 
// является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите номер дня недели: ");
int numDay = Convert.ToInt32(Console.ReadLine());

// switch (numDay)          // можно взять за основу решенную нами задачу с использованием конструкции "swith case"
// {
//     case 1:
//         Console.WriteLine("Нет");
//         break;
//     case 2:
//         Console.WriteLine("Нет");
//         break;
//     case 3:
//         Console.WriteLine("Нет");
//         break;
//     case 4:
//         Console.WriteLine("Нет");
//         break;
//     case 5:
//         Console.WriteLine("Нет");
//         break;
//     case 6:
//         Console.WriteLine("Да");
//         break;
//     case 7:
//         Console.WriteLine("Да");
//         break;
//     default:
//         Console.WriteLine("Нет такого дня недели");
//         break;
// }

if (numDay < 1 || numDay > 7)   // Либо написать свое решение))
    Console.WriteLine("Нет такого дня недели");
else if (numDay == 6 || numDay == 7)
    Console.WriteLine($"{numDay} -> Да");
else Console.WriteLine($"{numDay} -> Нет");