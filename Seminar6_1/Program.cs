﻿// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)



Console.WriteLine("Введите b1");
double NumberOne = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите k1");
double NumberTwo = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите b2");
double NumberThree = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите k2");
double NumberFour = Convert.ToInt32(Console.ReadLine());

double X = (NumberThree-NumberOne)/(NumberTwo-NumberFour);
double Y = NumberTwo*(NumberThree-NumberOne)/(NumberTwo-NumberFour)+NumberOne;

Console.WriteLine($"({X})\n({Y})");
