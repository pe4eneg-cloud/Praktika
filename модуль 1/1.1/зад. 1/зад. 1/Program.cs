using System;
class P
{
    static long F(int n) => n < 2 ? 1 : n * F(n - 1);
    static void Main()
    {
        Console.Write("Введите число: ");
        try
        {
            Console.WriteLine(F(int.Parse(Console.ReadLine())));
        }
        catch
        {
            Console.WriteLine("Ошибка!");
        }
    }
}