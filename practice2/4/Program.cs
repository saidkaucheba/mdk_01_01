Dictionary<string, string> slovar = new Dictionary<string, string>();

while (true)
{
    Console.WriteLine("добавить контакт(добавить); найти контакт(найти); просмотреть контакт(просмотр); выйти из телефонной книги(выход): ");
    string a = Console.ReadLine();

    if (a == "добавить" || a == "Добавить")
    {
        Console.WriteLine("введите имя: ");
        string name = Console.ReadLine();
        Console.WriteLine("введите номер: ");
        string phone = Console.ReadLine();
        slovar[name] = phone;
    }

    else if (a == "найти" || a == "Найти")
    {
        Console.WriteLine("введите имя: ");
        string name = Console.ReadLine();
        if (slovar.ContainsKey(name))
        {
            Console.WriteLine(name + ": " + slovar[name]);
        }
        else
        {
            Console.WriteLine("контакта нет в телефонной книжке");
        }
    }
    
    else if (a == "просмотр" || a == "Просмотр")
    {
        foreach (var i in slovar)
        {
            Console.WriteLine(i.Key + ": " + i.Value);
        }
    }

    else if (a == "выход" || a == "Выход")
    {
        break;
    }

    else
    {
        Console.WriteLine("такой команды нет");
    }
}