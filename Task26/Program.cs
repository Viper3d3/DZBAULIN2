Console.WriteLine("Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.");

//1 способ.
// Console.WriteLine ("Введите число №1" );
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Введите число №2" );
// int num2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"{num1}*{num2} = " + Math.Pow(num1, num2));


//2 способ цикл!
int multiplication(int x, int y)
{
   int result = 1;
   for(int i = 0; i < y; i++)
    { 
   result = result * x;
    }
return result;
}

Console.Write("Введите число которое надо возвести в степень :");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Число для возведения в степень первого :");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write($"{num1}^{num2} --->[{multiplication(num1, num2)} результат]");

