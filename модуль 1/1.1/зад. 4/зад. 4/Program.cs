using System;
using System.Linq;
class P
{
    static void Main()
    {
        try
        {
            var r = new Random();
            Console.WriteLine(Enumerable.Range(0, 15).Select(_ => r.Next(-50, 50)).Where(x => x > 0).Average());
        }
        catch
        {
            Console.WriteLine("Ошибка!");
        }
    }
}