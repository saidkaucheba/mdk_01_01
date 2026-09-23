Console.WriteLine("Введите количество студентов: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество предметов: ");
int m = int.Parse(Console.ReadLine());

int[,] matrix = new int[n, m];

for (int i = 0; i < n; i++)
{
    Console.WriteLine("студент " + (i + 1) + ": ");
    for (int j = 0; j < m; j++)
    {
        Console.WriteLine("предмет " + (j + 1) + ": ");
        matrix[i, j] = int.Parse(Console.ReadLine());
    }
}

for (int i = 0; i < n; i++)
{
    int a = 0;
    for (int j = 0; j < m; j++)
    {
        a += matrix[i, j];
    }

    double b = (double) a / m;
    Console.WriteLine("среднее значение для студента: " + (i + 1) + ": " + b);
}