//  Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""


string naturalNumber(int Value_1, int Value_2)
{
    if (Value_1 == Value_2) return Convert.ToString(Value_2);
    return naturalNumber(Value_1, Value_2 - 1) + " - " + Convert.ToString(Value_2);
}
int M = 1, N = 5;
Console.WriteLine(naturalNumber(M, N));

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Sum(int Value_1, int Value_2)
{
    if (Value_1 == Value_2) return Value_2;
    return Sum(Value_1, Value_2 - 1) + Value_2;
}

int M = 1;
int N = 15;
Console.WriteLine(Sum(M, N));


//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

int Ackermann(int m, int n)
{
    if (m == 0)
        return n + 1;
    else
      if ((m != 0) && (n == 0))
        return Ackermann(m - 1, 1);
    else
        return Ackermann(m - 1, Ackermann(m, n - 1));
}
int m = 2, n = 3;
Console.WriteLine($"{Ackermann(m, n)}");




























