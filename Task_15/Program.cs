// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите цифру:");
int cifra = Convert.ToInt32(Console.ReadLine());

if(cifra == 6 || cifra == 7)
    {
        Console.Write("Выходной");
    }
    if (cifra>=1 && cifra<=5)
        {
            Console.Write("Будни");
        }
    