﻿


// while(true)
// {
//     Console.Clear();
//     double firstValue, secondValue;
//     string actions;

// Console.WriteLine("Введите число 1");
// firstValue = double.Parse(Console.ReadLine());

// Console.WriteLine("Введите число 2");
// secondValue = double.Parse(Console.ReadLine());

// Console.WriteLine($"Введите что хотите сделать '+' '/' '*' '-' ");
// actions = Console.ReadLine();

// switch (actions)
// {
//     case "+":
//         Console.WriteLine($"Сумма чисел -->" + (firstValue + secondValue));
//         break;

//     case "-":
//         Console.WriteLine($"Вычетание -->" + (firstValue - secondValue));
//         break;
//     case "/":
//         Console.WriteLine($"Деление  -->" + (firstValue / secondValue));
//         break;
//     case "*":
//         Console.WriteLine($"Умножение  --> " + (firstValue*secondValue));
//         break;
//     default:
//     Console.WriteLine("Вы ввели не извсетный мне симсвол :_:");
//     break;
// }

// }

// Внимание, внимание! *Начиная с этого дз при оценке учитывается оформление и названия переменных. Будьте внимательны)
// *Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76                         



// Random rand = new Random();
// int[] arr = new int[10];
// for (int i = 0; i < arr.Length; i++)
// {
//     arr[i] = rand.Next(1, 20);
//     Console.WriteLine("arr[{0}] = {1}", i, arr[i]);
// }
// int max = arr.Max();
// int min = arr.Min();
// Console.WriteLine("\nМаксимальный элемент массива = {0}", max);
// Console.WriteLine("\nМиниимальный элемент массива = {0}", min);
// int result = max - min;
// Console.WriteLine("\nРазность = " +result);
// Console.ReadKey()


// Console.WriteLine("Введите первое число: ");
// int firstNumber = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите степень первого числа: ");
// int stepenNumber = Convert.ToInt32(Console.ReadLine());
// int result = 1;

// for(int i = 0; i < stepenNumber; i++)
// {
//       result = result * firstNumber;
// }
// Console.Write($"{firstNumber}*{stepenNumber} :(  {result}");




// int [] myArray = new int[4];

// for (int i = 0; i < myArray.Length; i++)

// {

//     Console.Write($"Введите число массива с индексом[{i}] = ");

//     myArray[i] = Convert.ToInt32(Console.ReadLine());

// }

// int SumOddElements = 0;

// for (int i = 0; i < myArray.Length; i ++)

// {

//   if (i%2 != 0)
//     SumOddElements = SumOddElements + myArray [i];

// }

// Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях массива : {SumOddElements}");



// int[] myArray = new int[5];

// for (int i = 0; i < myArray.Length; i++)

// {

//     Console.Write($"Введите число массива с индексом[{i}] = ");

//     myArray[i] = Convert.ToInt32(Console.ReadLine());

// }

// uint resultPositiveNumbersM = 0; //четные числа

// for (int i = 0; i < myArray.Length; i++)

// {

//     if (myArray[i] > 0)

//         resultPositiveNumbersM++;

// }











// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)



// Console.WriteLine("Введите b1");
// double NumberFirst = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите k1");
// double NumberTwo = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите b2");
// double NumberThree = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите k2");
// double NumberFour = Convert.ToInt32(Console.ReadLine());

// double X = (NumberThree-NumberFirst)/(NumberTwo-NumberFour);
// double Y = NumberTwo*(NumberThree-NumberFirst)/(NumberTwo-NumberFour)+NumberFirst;

// Console.WriteLine(X);
// Console.WriteLine(Y);





// Console.Write("Введите количество строк массива: ");
// int rows = int.Parse(Console.ReadLine()); // null - ссылка в пустоту
// Console.Write("Введите количество столбцы массива: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// /// summary - описание метода
// /// m на n: m - кол-во строк, n - кол-во столбцов
// /// minValue , maxValue
// int[,] GetArray(int m, int n, int minValue, int maxValue)
// {
//     int[,] matrix = new int[m, n];
//     for (int i = 0; i < m; i++)     // Строчки. m = matrix.GetLength(0)
//     {
//         for (int j = 0; j < n; j++) // n = matrix.GetLength(1)
//         {
//             matrix[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return matrix;
// }

// // Задайте двумерный массив.
// // Напишите программу,
// // которая поменяет местами первую и последнюю строку массива.

// Console.Write("Введите количество строк массива: ");
// int rows = int.Parse(Console.ReadLine()); // null - ссылка в пустоту
// Console.Write("Введите количество столбцы массива: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// /// summary - описание метода
// /// m на n: m - кол-во строк, n - кол-во столбцов
// /// minValue , maxValue
// int[,] GetArray(int m, int n, int minValue, int maxValue)
// {
// int[,] matrix = new int[m, n];
// for (int i = 0; i < m; i++) // Строчки. m = matrix.GetLength(0)
// {
// for (int j = 0; j < n; j++) // n = matrix.GetLength(1)
// {
// matrix[i, j] = new Random().Next(minValue, maxValue + 1);
// }
// }
// return matrix;
// }
// /// Печатает массив на экран
// void PrintArray(int[,] inputArray)
// {
// for (int i = 0; i < inputArray.GetLength(0); i++)
// {
// for (int j = 0; j < inputArray.GetLength(1); j++)
// {
// Console.Write(inputArray[i, j] + "\t");
// // 1 2 3 4
// }
// Console.WriteLine();
// }
// }
// int [,] array = GetArray(rows,columns,0,10);
// PrintArray(array);

// void ChangeRows(int [,] matrix)
// {
// int indexLastRow = matrix.GetLength(0) - 1;
// for (int i = 0; i < matrix.GetLength(1); i++)
// {
// int temp = matrix[0,i];
// matrix[0,i] = matrix[indexLastRow,i];
// matrix[indexLastRow,i] = temp;
// }
// }
// ChangeRows(array);
// Console.WriteLine("Результат: ");
// PrintArray(array);



// void Inizialisazion(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 11);
//             Console.Write(array[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
// }

// void ReadMass(int[,] Array)
// {
//     for(int i = 0; i < Array.GetLength(0); i++)
//     {
//         for(int  j= 0; j < Array.GetLength(1); j++)
//         {
//             Console.Write(Array[j, i] + "\t");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] matrix = new int[5, 5];

// Inizialisazion(matrix);
// System.Console.WriteLine();
// ReadMass(matrix);



// На оценку "5" нужно сделать минимум 4 задачи

// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// В итоге получается вот такой массив:

// 1 2 4 7

// 2 3 5 9

// 2 4 4 8

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// Например, заданы 2 массива:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// и

// 1 5 8 5

// 4 9 4 2

// 7 2 2 6

// 2 3 4 7

// Их произведение будет равно следующему массиву:

// 1 20 56 10

// 20 81 8 6

// 56 8 4 24

// 10 6 24 49

// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// массив размером 2 x 2 x 2

// 12(0,0,0) 22(0,0,1)

// 45(1,0,0) 53(1,0,1)

// Задача 62. Заполните спирально массив 4 на 4.

// Например, на выходе получается вот такой массив:

// 1 2 3 4

// 12 13 14 5

// 11 16 15 6

// 10 9 8 7




Console.WriteLine("Введите число, которое необходимо найти в массиве: ");

int findNumber = Convert.ToInt32(Console.ReadLine());
bool tempfindNumber = false;
bool temp = true;
int[,] myArray = {{1,2,3,4},{12,13,14,5},{11,16,15,6},{10,9,8,7}};


for (int i = 0; i < myArray.GetLength(0); i++)

{

    for (int j = 0; j < myArray.GetLength(1); j++)

    {
       
       
        Console.Write(myArray[i, j] + "\t");

    }

    Console.WriteLine();


}

Console.WriteLine();




for (int i = 0; i < myArray.GetLength(0); i++)

{

    for (int j = 0; j < myArray.GetLength(1); j++)

    {



        if (findNumber == myArray[i, j])

        {

            tempfindNumber = true;
            break;
        }
else 
{
    temp = false;
}
    }
   
}
 Console.WriteLine(tempfindNumber);