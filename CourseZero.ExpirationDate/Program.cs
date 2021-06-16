using System;

Console.WriteLine("Программа определения годности продукта!");
Console.WriteLine();

Console.Write("Введите дату изготовления продукта:");
string strDate = Console.ReadLine();

Console.Write("Введите срок годности в днях:");
string strDays = Console.ReadLine();

DateTime date = DateTime.Parse(strDate);
int days = int.Parse(strDays);

date = date.AddDays(days);

DateTime today = DateTime.Today;

if (date > today)
    Console.WriteLine("Поздравляю! Вы можете это съесть!");
else
    Console.WriteLine("Внимание! Оно не съедобно! Выбросьте это немедленно!");

Console.ReadKey();

//// void method
//// string method
//// default text
//// check date
//// check date and day
//// check days

void Print(string text = "")
{
    Console.WriteLine(text);
}

string GetString(string prompt)
{
    Console.Write(prompt + " ");
    return Console.ReadLine();
}

strDate = GetString("Введите дату изготовления продукта:");

if (!DateTime.TryParse(strDate, out date))
{
    Print("Дата некорректная");
    return;
}

while (!DateTime.TryParse(strDate, out date))
{
    Print("Дата некорректная");
    strDate = GetString("Введите дату ещё раз:");
}

do
{
    strDays = GetString("Введите срок годности в днях:");
} while (!int.TryParse(strDays, out days) || days < 1);

do
{
    strDays = GetString("Введите срок годности в днях:");
    if (int.TryParse(strDays, out days) && days > 0)
        break;
    Print("Срок годности указан некорректно");
    Print();
} while (true);

DateTime GetDateTime(string prompt)
{
    return date;
}

int GetDays(string prompt)
{
    return days;
}


