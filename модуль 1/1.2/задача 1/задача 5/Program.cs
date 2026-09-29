using System;
class P
{
    static void Main()
    {
        try
        {
            Console.Write("Введите количество элементов K: ");
            int k = int.Parse(Console.ReadLine());
            string alphabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
            string consonants = "БВГДЖЗЙКЛМНПРСТФХЦЧШЩ";
            Random r = new Random();
            char[] arr = new char[k];
            Console.WriteLine("\nИсходный массив:");
            for (int i = 0; i < k; i++)
            {
                arr[i] = alphabet[r.Next(alphabet.Length)];
                Console.Write(arr[i] + " ");
            }
            int count = 0;
            for (int i = 0; i < k; i++)
            {
                if (consonants.IndexOf(arr[i]) != -1) count++;
            }
            char[] consArr = new char[count];
            int j = 0;
            for (int i = 0; i < k; i++)
            {
                if (consonants.IndexOf(arr[i]) != -1)
                {
                    consArr[j++] = arr[i];
                }
            }
            Console.WriteLine("\n\nМассив согласных букв:");
            for (int i = 0; i < count; i++) Console.Write(consArr[i] + " ");
        }
        catch
        {
            Console.WriteLine("Ошибка ввода!");
        }
    }
}