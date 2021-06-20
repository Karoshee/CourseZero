using System;

void Print(string text = "")
{
    Console.WriteLine(text);
}

string GetString(string prompt)
{
    Console.Write(prompt + " ");
    return Console.ReadLine();
}

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
    int day;
    string strDays;
    do
    {
        strDays = GetString("Введите срок годности в днях:");
    } while (!int.TryParse(strDays, out day) || day < 1);
    return day;
}

Print("Программа определения годности продукта!");
Print();

DateTime date = GetDateTime();

int days = GetDays();

date = date.AddDays(days);

DateTime today = DateTime.Today;

string result = date > today 
    ? "Поздравляю! Вы можете это съесть!" 
    : "Внимание! Оно не съедобно! Выбросьте это немедленно!";

Print(result);

Console.ReadKey();

