using System;
class P
{
    static void Main()
    {
        try
        {
            Console.Write("Введите N: ");
            int n = int.Parse(Console.ReadLine());
            double[] a = new double[n];

            Console.Write("Введите элементы (через пробел): ");
            string[] s = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++) a[i] = double.Parse(s[i]);

            double max = Math.Abs(a[0]);
            for (int i = 1; i < n; i++)
                if (Math.Abs(a[i]) > max) max = Math.Abs(a[i]);

            for (int i = 0; i < n; i++)
                Console.Write((a[i] / max).ToString("F4") + " ");
        }
        catch
        {
            Console.WriteLine("Ошибка!");
        }
    }
}