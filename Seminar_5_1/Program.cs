// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] myArray = new int[6];
Random rand = new Random();
int negativValue = 0;
for (int i = 0, j=0; i < myArray.Length; i++, j++)
{
    myArray[i] = rand.Next(1, 10);
    if (i%2 != 0)
    {
        negativValue = negativValue + myArray [i];
    }
}
Console.WriteLine($"[{String.Join(", " , myArray)}] -> {negativValue}");

