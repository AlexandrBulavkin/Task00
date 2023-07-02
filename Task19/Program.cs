// Задача 19
// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите целое пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0)
{
    number *= -1;
}
if (number >= 10000 && number <= 99999)
{
    int numb5 =number % 10;
    int numb4 = number/10 % 10;
    int numb2 = number/1000 % 10;
    int numb1 = number/10000 % 10;
}    
else
{
    Console.WriteLine("Введено не пятизначное число");
}

// int palidrom = Palidrom(number); 
// bool Palidrom(int numb1, int numb5, int numb2, int numb4)
// {
// for
// {
//   numb1 == numb5;

// }
// }