//  Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
//  какое число большее, а какое меньшее.
//  a = 5; b = 7 -> max = 7
//  a = 2 b = 10 -> max = 10
//  a = -9 b = -3 -> max = -3

int max = 0;
int min = 0;
Console.WriteLine("Введите два не равных числа: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Первое число равно {number1} ");
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Второе число равно {number2} ");

if (number1 > number2)
{
    max = number1;
    min = number2;
}
else
{
    max = number2;
    min = number1;
}
Console.WriteLine("Большее число равно " + max + " а " + "меньшее число равно " + min);
