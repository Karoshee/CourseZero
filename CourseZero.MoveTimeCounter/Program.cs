using System;

const int speedWalk = 5;
const int speedTrainOrTrolley = 40;
const int speedCar = 200;

Console.WriteLine("Программа подсчёта времени пути!");
Console.WriteLine();

Console.Write("Какое расстояние планируете пройти? ");
string strLength = Console.ReadLine();

Console.WriteLine("Как планируете двигаться?");
Console.WriteLine($"a - пойду пешком ({speedWalk} км/ч)");
Console.WriteLine($"б - поеду на троллейбусе ({speedTrainOrTrolley} км/ч)");
Console.WriteLine($"в - сяду на поезд ({speedTrainOrTrolley} км/ч)");
Console.WriteLine($"г - возьму машину и буду гнать как угорелый ({speedCar} км/ч)");

var answer = Console.ReadKey();
Console.WriteLine();

char moveType = answer.KeyChar;

int speed;

if (moveType == 'а')
{
    speed = speedWalk;
}
else if (moveType == 'б' || moveType == 'в')
{
    speed = speedTrainOrTrolley;
}
else if (moveType == 'г')
{
    speed = speedCar;
}
else
{
    Console.WriteLine("Такой вариант не предусмотрен!");
    return;
}

//switch (moveType)
//{
//    case 'а':
//        speed = 5;
//        break;

//    case 'б':
//    case 'в':
//        speed = 40;
//        break;

//    case 'г':
//        speed = 200;
//        break;

//    default:
//        Console.WriteLine("Такой вариант не предусмотрен!");
//        return;
//}

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

decimal length = decimal.Parse(digits);
if (!isKilometer)
{
    length /= 1000;
}

// decimal
decimal hours = length / speed;

decimal seconds = (hours - (int)hours) * 3600;

var r = "На путь вы потратите " + hours + " часов " + seconds / 60 + " минут " + seconds % 60 + " секунд";

Console.WriteLine("На путь вы потратите {0} часов {1} минут {2} секунд", (int)hours, (int)(seconds / 60), (int)(seconds % 60));

Console.WriteLine($"На путь вы потратите {(int)hours} часов {(int)(seconds / 60)} минут {(int)(seconds % 60)} секунд");

Console.ReadKey();