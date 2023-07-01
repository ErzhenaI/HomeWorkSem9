string printNumbers(int a, int b)
{
    if (a == b)
        return $"{b}";
    return printNumbers(a, b - 1) + $", {b}";
}
Console.Clear();
Console.Write("Введите 1-ое число: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите 2-ое число: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(printNumbers(m, n));
Console.WriteLine($"Сумма от 1 до {n}: {((n + 1) / 2.0) * n}");