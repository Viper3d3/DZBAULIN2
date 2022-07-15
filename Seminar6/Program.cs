// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int[] myArray = new int[6];
uint PositiveNumber = 0; 

for (int i = 0; i < myArray.Length; i++)

{
    Console.Write($"Введите число с индексом[{i}] = ");
    myArray[i] = Convert.ToInt32(Console.ReadLine());

    if (myArray[i] > 0)
        PositiveNumber++;
}
Console.WriteLine($"Общее количество чётных чисел в массиве: [{PositiveNumber}]");
