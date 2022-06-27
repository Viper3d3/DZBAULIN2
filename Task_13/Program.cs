//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трехзначное число:");
int threenumber = Convert.ToInt32(Console.ReadLine());

//int num1 = threenumber / 10;
//int sum = num1 % 10;
int sum = (threenumber/10)%10;  // Сокращение. 

Console.WriteLine($"Второе число: {sum}");
