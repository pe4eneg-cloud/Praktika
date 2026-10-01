using System;
class Person
{
    private string name; // имя
    private int age; // возраст
    private string address; // адрес
    public void SetName(string name) { this.name = name; } // установить имя
    public string GetName() { return name; } // получить имя
    public void SetAge(int age) { this.age = age; } // установить возраст
    public int GetAge() { return age; } // получить возраст
    public void SetAddress(string address) { this.address = address; } // установить адрес
    public string GetAddress() { return address; } // получить адрес
    public void PrintInfo() { Console.WriteLine($"Имя: {name}, Возраст: {age}, Адрес: {address}"); } // вывести информацию
}
class P
{
    static void Main()
    {
        try
        {
            Person p1 = new Person(); // создаём первого человека
            Console.Write("Введите имя первого человека: ");
            p1.SetName(Console.ReadLine());
            Console.Write("Введите возраст: ");
            p1.SetAge(int.Parse(Console.ReadLine()));
            Console.Write("Введите адрес: ");
            p1.SetAddress(Console.ReadLine());
            Person p2 = new Person(); // создаём второго человека
            Console.Write("\nВведите имя второго человека: ");
            p2.SetName(Console.ReadLine());
            Console.Write("Введите возраст: ");
            p2.SetAge(int.Parse(Console.ReadLine()));
            Console.Write("Введите адрес: ");
            p2.SetAddress(Console.ReadLine());
            Console.WriteLine("\nСписок людей:");
            p1.PrintInfo(); // выводим первого
            p2.PrintInfo(); // выводим второго
        }
        catch
        {
            Console.WriteLine("Ошибка ввода!");
        }
    }
}