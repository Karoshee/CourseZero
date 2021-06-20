using System;

Console.WriteLine("Программа определения годности продукта!");
Console.WriteLine();

DateTime date = GetDateTime();
int days = GetDays();

date = date.AddDays(days);

DateTime today = DateTime.Today;

if (date > today)
    Console.WriteLine("Поздравляю! Вы можете это съесть!");
else
    Console.WriteLine("Внимание! Оно не съедобно! Выбросьте это немедленно!");

Console.ReadKey();

void Print(string text = "")
{
    Console.WriteLine(text);
}

string GetString(string prompt)
{
    Console.Write(prompt + " ");
    return Console.ReadLine();
}

//if (!DateTime.TryParse(strDate, out date))
//{
//    Print("Дата некорректная");
//    return;
//}

//do
//{
//    string strDays = GetString("Введите срок годности в днях:");
//    if (int.TryParse(strDays, out days) && days > 0)
//        break;
//    Print("Срок годности указан некорректно");
//    Print();
//} while (true);

DateTime GetDateTime()
{
    string strDate = GetString("Введите дату изготовления продукта:");
    DateTime dt;
    while (!DateTime.TryParse(strDate, out dt))
    {
        Print("Дата некорректная");
        strDate = GetString("Введите дату ещё раз:");
    }
    return dt;
}

int GetDays()
{
    string strDays;
    int number;
    do
    {
        strDays = GetString("Введите срок годности в днях:");
    } while (!int.TryParse(strDays, out number) || number < 1);
    return number;
}


