using System;

Console.WriteLine("Добро пожаловать в программу определения високосного года");
Console.WriteLine();

Console.Write("Введите год, который хотите проверить: ");
string strYear = Console.ReadLine();

int year = int.Parse(strYear);

if ((year % 4) == 0)
{
    Console.WriteLine("Год високосный");
}
else
{
    Console.WriteLine("Год не високосный");
}

Console.ReadKey();