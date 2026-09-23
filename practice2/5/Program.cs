Dictionary<string, int> slovar = new Dictionary<string, int>();

while (true)
{
    Console.WriteLine("введите слово: ");
    string a = Console.ReadLine();

    if (slovar.ContainsKey(a))
    {
        slovar[a] += 1;
    }

    else
    {
        slovar[a] = 1;
    }

    Console.WriteLine(a + ": " + slovar[a]);
}