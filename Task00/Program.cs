// 0. Демонстрация решения
// Напишите программу, которая на вход
// принимает число и выдаёт его квадрат (число)
// умноженное на само себя).
// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49
// string str = Console.ReadLine();
// int number = Convert.ToInt32(str);

Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
//int number = int.Parse(Console.ReadLine());

// -2 147 483 648  до  2 147 483 647
int square = number * number;
Console.WriteLine($"Квадрат числа {number} = {square}");