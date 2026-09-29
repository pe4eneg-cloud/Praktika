using System;
class P
{
    static void Main()
    {
        try
        {
            Console.Write("Введите количество элементов K: ");
            int k = int.Parse(Console.ReadLine());
            Console.Write("Введите начало диапазона A (можно отрицательное, например -20): ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите конец диапазона B (не включается): ");
            int b = int.Parse(Console.ReadLine());
            int[] arr = new int[k];
            Random r = new Random();
            Console.WriteLine($"\nДиапазон: [{a}, {b})");
            Console.WriteLine("Сгенерированный массив:");
            for (int i = 0; i < k; i++)
            {
                arr[i] = r.Next(a, b);
                Console.Write(arr[i] + " ");
            }
            int minIdx = 0, maxIdx = 0;
            for (int i = 1; i < k; i++)
            {
                if (arr[i] < arr[minIdx]) minIdx = i;
                if (arr[i] > arr[maxIdx]) maxIdx = i;
            }
            Console.WriteLine($"\n\nМинимальный элемент: {arr[minIdx]} (индекс {minIdx})");
            Console.WriteLine($"Максимальный элемент: {arr[maxIdx]} (индекс {maxIdx})");
            Console.WriteLine("\nЭлементы между ними (включая min и max):");
            int start = Math.Min(minIdx, maxIdx);
            int end = Math.Max(minIdx, maxIdx);
            for (int i = start; i <= end; i++) Console.Write(arr[i] + " ");
        }
        catch
        {
            Console.WriteLine("Ошибка ввода!");
        }
    }
}