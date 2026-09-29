using System;
class P
{
    static void Main()
    {
        try
        {
            Console.Write("Введите K: ");
            int k = int.Parse(Console.ReadLine());
            int count = 0, n = 2;
            while (count < k)
            {
                bool prime = true;
                for (int i = 2; i * i <= n; i++)
                    if (n % i == 0) { prime = false; break; }
                if (prime)
                {
                    Console.Write(n + "\t");
                    count++;
                    if (count % 10 == 0) Console.WriteLine();
                }
                n++;
            }
        }
        catch
        {
            Console.WriteLine("Ошибка!");
        }
    }
}