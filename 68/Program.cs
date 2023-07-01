int Acc (int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (n == 0)
        return Acc (m-1, 1);
    else return Acc (m - 1, Acc (m, n-1));
}   
Console.Clear();
Console.Write("Введите 1-е неотрицательное число: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите 1-е неотрицательное число: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(Acc(n, m));