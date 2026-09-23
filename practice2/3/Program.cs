List<int> numbers = new List<int>();

while (true)
{
    Console.WriteLine("введите число: ");
    int a = int.Parse(Console.ReadLine());

    if (numbers.Contains(a))
    {
        Console.WriteLine("такое число уже есть!");
        break;
    }
    numbers.Add(a);
}

Console.WriteLine("массив чисел: ");
foreach (int i in numbers)
{
    Console.WriteLine(i);
}