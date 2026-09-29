using System;
class P
{
    static void Main()
    {
        try
        {
            int[] a = new int[10];
            Random r = new Random();

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < 10; i++)
            {
                a[i] = r.Next(-50, 50);
                Console.Write(a[i] + " ");
            }

            int max = a[0], idx = 0;
            for (int i = 1; i < 10; i++)
                if (a[i] > max) { max = a[i]; idx = i; }

            Console.Write("\nВведите число для замены: ");
            a[idx] = int.Parse(Console.ReadLine());

            Console.WriteLine("Изменённый массив:");
            for (int i = 0; i < 10; i++) Console.Write(a[i] + " ");
        }
        catch
        {
            Console.WriteLine("Ошибка!");
        }
    }
}