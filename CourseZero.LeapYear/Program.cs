using System;

Console.WriteLine("Добро пожаловать в программу определения високосного года");
Console.WriteLine();
Console.Write("Введите год, который хотите проверить: ");
string strYear = Console.ReadLine();

int year = int.Parse(strYear);

int remainder = year % 4;

bool isLeap = remainder == 0;

if (isLeap)
    Console.WriteLine("Год високосный");
else
    Console.WriteLine("Год не високосный");

Console.ReadKey();

//// Предыдущий год
//// Выражение if
//// Тернарный оператор