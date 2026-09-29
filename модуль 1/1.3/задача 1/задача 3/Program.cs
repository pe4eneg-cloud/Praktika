using System;

class P
{
    static void Main()
    {
        try
        {
            Console.Write("Введите размер квадратной матрицы N: ");
            int n = int.Parse(Console.ReadLine());

            if (n < 1)
            {
                Console.WriteLine("Размер должен быть >= 1!");
                return;
            }

            int[,] matrix = new int[n, n];
            Random r = new Random();

            Console.WriteLine("\nИсходная матрица:");
            for (int i = 0; i < n; i++)
            {
                int sum = 0;
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = r.Next(-50, 51);
                    sum += matrix[i, j];
                    Console.Write($"{matrix[i, j],5}");
                }
                Console.WriteLine($"  | Сумма: {sum}");
            }

            int[] sums = new int[n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    sums[i] += matrix[i, j];
                }
            }

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (sums[j] > sums[j + 1])
                    {
                        int temp = sums[j];
                        sums[j] = sums[j + 1];
                        sums[j + 1] = temp;

                        for (int k = 0; k < n; k++)
                        {
                            int tempVal = matrix[j, k];
                            matrix[j, k] = matrix[j + 1, k];
                            matrix[j + 1, k] = tempVal;
                        }
                    }
                }
            }

            Console.WriteLine("\nМатрица после сортировки строк по возрастанию сумм:");
            for (int i = 0; i < n; i++)
            {
                int sum = 0;
                for (int j = 0; j < n; j++)
                {
                    sum += matrix[i, j];
                    Console.Write($"{matrix[i, j],5}");
                }
                Console.WriteLine($"  | Сумма: {sum}");
            }
        }
        catch
        {
            Console.WriteLine("Ошибка ввода!");
        }
    }
}