﻿// Программа находит точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1;
// y = k2 * x + b2. Значение k1, b1, k2, b2 задаются пользователем.

Console.Write("Введите k1: ");
double k1 = double.Parse(Console.ReadLine());
Console.Write("Введите b1: ");
double b1 = double.Parse(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = double.Parse(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = double.Parse(Console.ReadLine());

double x = (b2 - b1)/(k1 - k2);
double y = k1*x + b1;

Console.WriteLine($"Точка пересечения прямых имеет координаты: х = {x}, y = {y}");