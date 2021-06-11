using System;

Console.Write("Введите имя: ");
string name = Console.ReadLine();

Console.WriteLine("{0}, Вам никто не говорил, что у Вас дурацкое имя?",name);

bool Question(string text)
{
    Console.WriteLine(text);

    do
    {
        Console.Write("(Да/Нет): ");
        string answer = Console.ReadLine();

    } while (true);
}