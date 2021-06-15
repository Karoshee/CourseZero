using System;

Console.Write("Введите имя: ");
string name = Console.ReadLine();

if (Question($"{name}, Вам никто не говорил, что у Вас дурацкое имя?"))
{
    if (Question("Если так, то давно пора исправить эту оплошность. Хотете назваться по-другому?"))
    {
        Console.Write("Введите новое имя: ");
        string newName = Console.ReadLine();
        while (name == newName)
        {
            Console.Clear();
            Console.WriteLine("Меня не проведёшь! Это то же самое имя!");
            Console.Write("Введите ешё раз: ");
            newName = Console.ReadLine();            
        }
        name = newName;
        Console.WriteLine("Вот уже лучше");
    }
}
else 
{
    Console.WriteLine("Зато теперь Вы в курсе.");
}

var age = InputAge("Сколько Вам лет?");

Console.WriteLine("{0} программа поздравляет Вас с тем, что Вам {1} лет", name, age);

bool Question(string text)
{
    Console.WriteLine(text);

    do
    {
        Console.Write("(Да/Нет): ");
        string answer = Console.ReadLine();
        if (string.Equals(answer, "да", StringComparison.InvariantCultureIgnoreCase))
        {
            return true;
        }
        if (string.Equals(answer, "нет", StringComparison.InvariantCultureIgnoreCase))
        {
            return false;
        }
        Console.WriteLine("Нет такого ответа! Есть только:");
    } while (true);
}

int InputAge(string text)
{
    Console.Write(text + " ");
    int age;
    string ageText = Console.ReadLine();
    while(!(int.TryParse(ageText, out age) && age > 0 && age < 120))
    {
        Console.Clear();
        Console.WriteLine("Это некорректный возраст для человека!");        
        Console.Write(text + " ");
        ageText = Console.ReadLine();
    }
    return age;
}