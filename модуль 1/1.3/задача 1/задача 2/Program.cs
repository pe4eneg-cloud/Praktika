using System;
class P
{
    static void Main()
    {
        try
        {
            Console.Write("Введите максимальную сумму: ");
            int maxSum = int.Parse(Console.ReadLine());

            if (maxSum < 1)
            {
                Console.WriteLine("Сумма должна быть >= 1!");
                return;
            }
            Random r = new Random();
            int[] arr = new int[maxSum];
            int count = 0;
            int sum = 0;
            while (sum < maxSum)
            {
                int num = r.Next(1, 10);
                if (sum + num > maxSum) break;
                arr[count++] = num;
                sum += num;
            }
            Console.WriteLine($"\nМассив ({count} элементов):");
            for (int i = 0; i < count; i++) Console.Write(arr[i] + " ");
            Console.WriteLine($"\nСумма: {sum}");
        }
        catch
        {
            Console.WriteLine("Ошибка ввода!");
        }
    }
}