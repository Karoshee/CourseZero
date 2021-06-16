using System;

string GetString(string prompt)
{
    Console.Write(prompt + " ");
    return Console.ReadLine();
}

int GetNumber(string prompt)
{
    int num;
    string strNumber;
    do
    {
        strNumber = GetString(prompt);
    } while (!int.TryParse(strNumber, out num) || num < 1 || num > 10);
    return num;
}

Console.WriteLine("Программа расчёта факториала числа");
Console.WriteLine();

int number = GetNumber("Введите число от 1 до 10");

int factorial = 1;

for (int i = 2; i <= number; i++)
{
    factorial *= i;
}

Console.WriteLine($"{number}! = {factorial}");

int Factorial(int n)
{
    if (n == 1)
    {
        return 1;
    }
    else
    {
        return n * Factorial(n - 1);
    }
}