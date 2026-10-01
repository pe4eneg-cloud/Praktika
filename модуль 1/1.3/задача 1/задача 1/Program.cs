using System;

class P
{
    static int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    static void Main()
    {
        try
        {
            Console.Write("Введите числитель (неотрицательное число): ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Введите знаменатель (положительное число): ");
            int den = int.Parse(Console.ReadLine());

            if (num < 0 || den <= 0)
            {
                Console.WriteLine("Ошибка: числитель должен быть >= 0, знаменатель > 0!");
                return;
            }

            int gcd = GCD(num, den);
            int newNum = num / gcd;
            int newDen = den / gcd;

            Console.WriteLine($"\nИсходная дробь: {num}/{den}");
            Console.WriteLine($"НОД: {gcd}");
            Console.WriteLine($"Сокращённая дробь: {newNum}/{newDen}");
        }
        catch
        {
            Console.WriteLine("Ошибка ввода!");
        }
    }
}