﻿Console.WriteLine("Введите пятизначное число N: ");
string number = Console.ReadLine();
int lastNumber = Convert.ToInt32(number);

if (lastNumber == Palindrom(number))
{
    Console.WriteLine("Да!");
}
else
{
    Console.WriteLine("Нет!");
}

int Palindrom(string x)
{
    int result = Convert.ToInt32(Convert.ToString(x[4]) + Convert.ToString(x[3]) + Convert.ToString(x[2]) + Convert.ToString(x[1]) + Convert.ToString(x[0]));
    return result;
    }
