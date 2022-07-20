// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

Console.WriteLine("Введите число для проверки нахождения его в массиве:");

int NumberSearchArray = Convert.ToInt32(Console.ReadLine());
bool temp = false;

int[,] myArray =
{
    {4,5,63,6},
    {35,3,5,2},
    {9,4,52,1}
};

for (int i = 0; i < myArray.GetLength(0); i++)
{
    for (int j = 0; j < myArray.GetLength(1); j++)
    {
        Console.Write(myArray[i, j] + "\t");
        if (NumberSearchArray  == myArray[i, j])
        {
            
            temp = true;
        break;
        }
    }
    Console.WriteLine();

}
Console.WriteLine(temp);

