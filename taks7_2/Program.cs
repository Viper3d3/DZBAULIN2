// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


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
        Console.Write(myArray[i,j]+ "\t");
    }
     Console.WriteLine();     
}


for (int j = 0; j < myArray.GetLength(1); j++)
{
    double sumArifmetic = 0;
    for (int i = 0; i < myArray.GetLength(0); i++)
    {
        sumArifmetic += myArray[i, j];
    }
    
    Console.Write(Math.Round(sumArifmetic / myArray.GetLength(0),1)+"\t");
} 



