// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
Console.Write("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine());

int a1 = num / 10000;
int a2 = num % 10;
int b1 = num / 1000 % 10;
int b2 = num % 100 / 10;

if (num > 9999 && num < 100000)
{
    if (a1 == a2 && b1 == b2)
    {
        Console.WriteLine($"{num} -> да");
    }
    else
    {
        Console.WriteLine($"{num} -> нет");
    }
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"{num} -> непятизначное число");
    Console.ResetColor();
}
