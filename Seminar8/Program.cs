// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// В итоге получается вот такой массив:

// 1 2 4 7

// 2 3 5 9

// 2 4 4 8

int rows = 3; // строки 
int colums = 4; // колонки

int [,] myArray = 
{
    {1,4,7,2},
    {5,9,2,3},
    {8,4,2,4}

};

for (int i = 0; i < myArray.GetLength(0); i++)
{
    for (int j = 0; j < myArray.GetLength(1); j++)
    {
        Console.Write(myArray[i,j]+"\t");
    }
    Console.WriteLine();
}

int[] tempMyArray = new int[colums];
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < colums; j++)
    {
        tempMyArray[j] = myArray[i, j];
    }

    Array.Sort(tempMyArray);

    for (int j = 0; j < colums; j++)
    {
        myArray[i, j] = tempMyArray[j];
    }
}
Console.WriteLine(" -----------------------");

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < colums; j++)
    {
        Console.Write(myArray[i, j] + "\t");
    }
    Console.WriteLine();
}



// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int rows, columns;
int[,] myArray;

Console.Write("Введите количество строк в матрице: ");
rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в матрице: ");
columns = Convert.ToInt32(Console.ReadLine());
myArray = new int[rows, columns];
Random rnd = new Random();


for (int i = 0; i < rows; i++)
    for (int j = 0; j < columns; j++)
        myArray[i, j] = rnd.Next(-0, 10 + 1);

for (int i = 0; i < rows; i++, Console.WriteLine())
    for (int j = 0; j < columns; j++)
        Console.Write(myArray[i, j] + "\t");

int minRowSum = int.MaxValue, indexMinRow = 0;

for (int i = 0; i < rows; i++)
{
    int rowSum = 0;
    for (int j = 0; j < columns; j++)
        rowSum += myArray[i, j];

    if (rowSum < minRowSum)
    {
        minRowSum = rowSum;
        indexMinRow = i;
    }
}

Console.WriteLine("Строка с минимальной суммой элементов");
for (int j = 0; j < columns; j++)
    Console.Write(myArray[indexMinRow,j] + "\t");




// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int rows = 3;
int columns = 4;

rows = new Random().Next(2, 5);
columns = new Random().Next(2, 5);

int[,] myArrayOne = new int[rows, columns];
int[,] myArrayTwo = new int[rows, columns];
int[,] myArrayResult = new int[rows, columns];
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        myArrayOne[i, j] = new Random().Next(3,10);
        myArrayTwo[i, j] = new Random().Next(6,8);
        myArrayResult[i, j] = myArrayOne[i, j] * myArrayTwo[i, j];
    }
}

void writemyArray (int rows, int columns, int[,] matrix)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("MATRIX_ONE");
writemyArray(rows, columns, myArrayOne);
Console.WriteLine("MATRIX_TWO");
writemyArray(rows, columns, myArrayTwo);

Console.WriteLine("MATRIX_RESULT");
writemyArray(rows, columns, myArrayResult);



// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)

int[,,] matrix3D = new int[4, 4, 4];
bool contains = true;
int number = 0;
List<int> checker = new List<int>();
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        for (int k = 0; k < 4; k++)
        {
            while (contains)
            {
                number = new Random().Next(5, 50);
                contains = checker.Contains(number);
            }
            matrix3D[i, j, k] = number;
            checker.Add(number);
            Console.Write($"{number}({i},{j},{k})   ");
        }
        Console.Write("\t");
    }
    Console.Write("\n");
}
