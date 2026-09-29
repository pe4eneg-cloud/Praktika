using System;
class P
{
    static void Main()
    {
        try
        {
            Console.Write("Введите число: ");
            int n = int.Parse(Console.ReadLine());
            bool p = n > 1;
            for (int i = 2; i * i <= n && p; i++)
                if (n % i == 0) p = false;
            Console.WriteLine(p ? "Простое" : "Не простое");
        }
        catch
        {
            Console.WriteLine("Ошибка!");
        }
    }
}