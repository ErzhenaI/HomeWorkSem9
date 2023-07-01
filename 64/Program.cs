string printNumbers (int n)
{
    if (n==1)
        return $" {1}";
    return $" {n}" + printNumbers(n - 1);
}
Console.Clear();
Console.Write("Введите число больше 1: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Результат: {string.Join(", ", printNumbers(n))}");