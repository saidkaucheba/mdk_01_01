Console.WriteLine("Введите размер массива: ");
int a = int.Parse(Console.ReadLine());
int[] numbers = new int [a];
int c = 0;
for (int i = 0; i < a; i++) 
{
    int b = int.Parse(Console.ReadLine());
    numbers[i] = b;
}

Console.WriteLine("Массив в обратном порядке: ");
Array.Reverse(numbers);
foreach (int i in numbers)
{
    Console.WriteLine(i);
    c += i;
}

double d = (double) c / a;
int e = numbers[0];
double f = Math.Abs(numbers[0] - d);

for (int i = 1; i < numbers.Length; i++)
{
    double g = Math.Abs(numbers[i] - d);

    if (g < f)
    {
        f = g;
        e = numbers[i];
    }
}

Console.WriteLine("Среднее арифметическое: " + d + " близкое к нему число: " + e);