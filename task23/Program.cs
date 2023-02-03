// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();
Console.Write("Введите число: ");
double N = double.Parse(Console.ReadLine());
double count = 1;
double num = 1;

Console.Write($"{N} -> ");

if (N > 0)
{
    while (count <= N)
    {
        num = Math.Pow(count, 3);
        Console.Write($"{num}, ");
        count++;
    }
}
else
{
    count = -1;
    while (count >= N)
    {
        num = Math.Pow(count, 3);
        Console.Write($"{num}, ");
        count--;
    }
}
