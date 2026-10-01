using System;
struct Train
{
    public string destination; // пункт назначения
    public int number; // номер поезда
    public string time; // время отправления
}
class P
{
    static void Main()
    {
        try
        {
            Train[] trains = new Train[5]; // создал массив из 5 поездов
            // ввёл данные о поездах
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Поезд {i + 1}:");
                Console.Write("Пункт назначения: ");
                trains[i].destination = Console.ReadLine();
                Console.Write("Номер поезда: ");
                trains[i].number = int.Parse(Console.ReadLine());
                Console.Write("Время отправления (ЧЧ:ММ): ");
                trains[i].time = Console.ReadLine();
            }
            // отсортировал по номерам поездов пузырьком
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4 - i; j++)
                    if (trains[j].number > trains[j + 1].number)
                    {
                        Train temp = trains[j];
                        trains[j] = trains[j + 1];
                        trains[j + 1] = temp;
                    }
            // вывел отсортированный массив
            Console.WriteLine("\nПоезда по номерам:");
            for (int i = 0; i < 5; i++)
                Console.WriteLine($"№{trains[i].number} | {trains[i].destination} | {trains[i].time}");
            // добавил поиск по номеру поезда
            Console.Write("\nВведите номер поезда для поиска: ");
            int search = int.Parse(Console.ReadLine());
            bool found = false;
            for (int i = 0; i < 5; i++)
                if (trains[i].number == search)
                {
                    Console.WriteLine($"Найден: №{trains[i].number} | {trains[i].destination} | {trains[i].time}");
                    found = true;
                }
            if (!found) Console.WriteLine("Поезд не найден!");
            // отсортировал по пункту назначения, а при одинаковых — по времени
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4 - i; j++)
                {
                    bool swap = false;
                    if (string.Compare(trains[j].destination, trains[j + 1].destination) > 0) swap = true;
                    if (trains[j].destination == trains[j + 1].destination && string.Compare(trains[j].time, trains[j + 1].time) > 0) swap = true;
                    if (swap)
                    {
                        Train temp = trains[j];
                        trains[j] = trains[j + 1];
                        trains[j + 1] = temp;
                    }
                }
            // вывел отсортированный по назначению массив
            Console.WriteLine("\nПоезда по пункту назначения:");
            for (int i = 0; i < 5; i++)
                Console.WriteLine($"№{trains[i].number} | {trains[i].destination} | {trains[i].time}");
        }
        catch
        {
            Console.WriteLine("Ошибка!");
        }
    }
}