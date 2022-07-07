//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//Console.Write("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());

string numtext = Convert.ToString(num);

if (numtext.Length >2)
    {
        Console.WriteLine("Третия цифра :" + numtext[2]);
    }
else 
    {
        Console.WriteLine("Третьей цифры нет");
    }
