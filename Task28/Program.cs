// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

 int [] array = new int [8];
 int size = array.Length;
 int i = 0;
 
 while (i < size)
 {
    array[i] = new Random().Next(100, 999);
    array[i]+= size; 
    i++;
 }
 
 
Console.WriteLine($"[{String.Join(", " , array)}]");


 
 
