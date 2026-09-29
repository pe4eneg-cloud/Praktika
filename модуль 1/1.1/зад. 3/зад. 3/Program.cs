using System;
class P
{
    static void Main()
    {
        try
        {
            Console.Write("Введите строку: ");
            string s = Console.ReadLine();
            for (int i = s.Length - 1; i >= 0; i--) Console.Write(s[i]);
        }
        catch
        {
            Console.WriteLine("Ошибка!");
        }
    }
}