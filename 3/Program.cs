﻿//  Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] array = new double[5];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
array[i] = rand.Next(1, 51) + rand.NextDouble();

Console.WriteLine($"[{string.Join(" , " ,array )}]");

double max=array[0];
double min=array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
        if (array[i] > max) max = array[i];
    }
double result=max-min;
Console.WriteLine($"Максимальное число {max} - Минимальное число {min} Разность = {result}");
        Console.WriteLine($"{result:F2}");
