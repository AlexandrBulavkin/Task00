//  Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
//  и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());
if (dayNumber == 6 || dayNumber == 7)
{
    Console.WriteLine("Этот день выходной");
}
else if (dayNumber <= 5 && dayNumber >= 1)
{
    Console.WriteLine("Этот день не выходной");
    }
else
{
    Console.WriteLine("Нет такого дня недели");
   }

