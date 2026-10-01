using System;
class P
{
    static void Main()
    {
        try
        {
            int n = 10;
            double[] arr = new double[n];
            int[] idx = new int[n];
            Random r = new Random();
            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < n; i++)
            {
                arr[i] = Math.Round(r.NextDouble() * 20 - 10, 2);
                idx[i] = i;
                Console.Write($"[{i}]={arr[i]}  ");
            }
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (arr[idx[j]] > arr[idx[j + 1]])
                    {
                        int temp = idx[j];
                        idx[j] = idx[j + 1];
                        idx[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("\n\nМассив индексов в порядке возрастания значений:");
            for (int i = 0; i < n; i++) Console.Write(idx[i] + " ");

            Console.WriteLine("\n\nЗначения по этим индексам:");
            for (int i = 0; i < n; i++) Console.Write(arr[idx[i]] + " ");
        }
        catch
        {
            Console.WriteLine("Ошибка!");
        }
    }
}