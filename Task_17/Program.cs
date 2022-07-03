Console.WriteLine("Введите пятизначное число:");
int fivenumber = Convert.ToInt32(Console.ReadLine());

int one = (fivenumber / 10000); // нахождение первой цифры
int two = (fivenumber/1000)%10; // нахождение второй цифры
int three = (fivenumber/100)%10; // нахождение третий цифры
int four = (fivenumber/10)%10; // нахождение четвертой  цифры 
int five = (fivenumber % 10); // нахождение пятой цирфы 

if (one==five && two==four )
{
    Console.WriteLine("Это палиндром.");
}
else 
{
    Console.WriteLine("Это не палиндром.");
}


//Console.WriteLine($"1-{one} 2-{two} 3-{three} 4-{four } 5-{five} ");

//*string numtext = Console.ReadLine();
 
//if (numtext[0]==numtext[4] && numtext[1]==numtext[3] )
//{
    //Console.WriteLine("Палиндром");
//}
//else
//{
 // Console.WriteLine("Не палиндром");
//}
// Второе решение.