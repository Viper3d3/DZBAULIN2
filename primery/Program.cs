


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
// Console.ReadKey();
        