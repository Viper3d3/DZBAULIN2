// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


int size = new Random().Next(5, 8);
double[] array = new double[size];

for (int i = 0; i < size; i++)
{
    array[i] = new Random().NextDouble() * 100;
}
double max = array.Max();
double min =  array.Min();
max = Math.Round(max);
min = Math.Round(min);
Console.WriteLine($"[{String.Join(", ", array)}] -> {max - min}");

