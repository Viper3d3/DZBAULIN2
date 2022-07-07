// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11

Console.WriteLine("введите число"); //247
int x = Convert.ToInt32(Console.ReadLine());
int sum = 0;       
for (int i = x; i > 0; i /= 10) 
{ 
      sum += i % 10;   //sum(0) = sum(0) + 247 % 10 (7) -->  sum =7  ||  sum(7) = sum (7) + 24 %10(4) = 11 ||  sum(11) = sum (11) + 2 % 10 (2) = sum 13
}

Console.WriteLine($"{x} -> {sum}");