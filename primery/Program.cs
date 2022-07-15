


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



int[] myArray = new int[5];

for (int i = 0; i < myArray.Length; i++)

{

    Console.Write($"Введите число массива с индексом[{i}] = ");

    myArray[i] = Convert.ToInt32(Console.ReadLine());

}

uint resultPositiveNumbersM = 0; //четные числа

for (int i = 0; i < myArray.Length; i++)

{

    if (myArray[i] > 0)

        resultPositiveNumbersM++;

}



Console.WriteLine($"Общее количество чётных чисел в массиве: " + resultPositiveNumbersM);







// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)



Console.WriteLine("Введите b1");
double NumberFirst = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите k1");
double NumberTwo = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите b2");
double NumberThree = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите k2");
double NumberFour = Convert.ToInt32(Console.ReadLine());

double X = (NumberThree-NumberFirst)/(NumberTwo-NumberFour);
double Y = NumberTwo*(NumberThree-NumberFirst)/(NumberTwo-NumberFour)+NumberFirst;

Console.WriteLine(X);
Console.WriteLine(Y);