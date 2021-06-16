using System;

Console.WriteLine("Программа подсчёта времени пути!");

Console.Write("Какое расстояние планируете пройти? ");
string strLength = Console.ReadLine();

Console.WriteLine("Как планируете двигаться?");
Console.WriteLine("a - пойду пешком (5 км/ч)");
Console.WriteLine("б - поеду на троллейбусе (40 км/ч)");
Console.WriteLine("в - сяду на поезд (40 км/ч)");
Console.WriteLine("г - возьму машину и буду гнать как угорелый (200 км/ч)");

var answer = Console.ReadKey();

char moveType = answer.KeyChar;

int speed;

if (moveType == 'а')
    speed = 5;
else if (moveType == 'б' || moveType == 'в')
    speed = 40;
else if (moveType == 'г')
    speed = 200;
else
{
    Console.WriteLine("Такой вариант не предусмотрен!");
    return;
}

switch (moveType)
{
    case 'а':
        speed = 5;
        break;

    case 'б':
    case 'в':
        speed = 40;
        break;

    case 'г':
        speed = 200;
        break;

    default:
        Console.WriteLine("Такой вариант не предусмотрен!");
        return;
}

//// 10км

bool isKilometer = strLength.Contains("км");
string digits = "";

foreach (char character in strLength)
{
    if (char.IsDigit(character))
    {
        digits += character;
    }
}

double length = double.Parse(digits);
if (!isKilometer)
{
    length *= 1000;
}

double hours = length / speed;

Console.WriteLine("На путь вы потратите " + hours + " часов");

double seconds = (hours - (int)hours)*3600;

Console.WriteLine("На путь вы потратите {0} часов {1} минут {2} секунд", hours, seconds / 60, seconds % 60);
Console.ReadKey();

//// int seconds
//// $ interpolation
//// { } into if statement
//// speed constaints
