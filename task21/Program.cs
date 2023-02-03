﻿// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();

Console.Write("Введите координату X для первой точки: ");
double x1 = double.Parse(Console.ReadLine());
Console.Write("Введите координату Y для первой точки: ");
double y1 = double.Parse(Console.ReadLine());
Console.Write("Введите координату Z для первой точки: ");
double z1 = double.Parse(Console.ReadLine());

Console.Write("Введите координату X для второй точки: ");
double x2 = double.Parse(Console.ReadLine());
Console.Write("Введите координату Y для второй точки: ");
double y2 = double.Parse(Console.ReadLine());
Console.Write("Введите координату Z для второй точки: ");
double z2 = double.Parse(Console.ReadLine());

double result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));

Console.WriteLine($"A ({x1}, {y1}, {z1}); B ({x2}, {y2}, {z2}) -> {result}");
