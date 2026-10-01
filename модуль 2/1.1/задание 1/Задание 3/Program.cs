using System;
class Author
{
    string name;
    int birthYear;
    public Author(string name, int birthYear) { this.name = name; this.birthYear = birthYear; }
    public void PrintInfo() { Console.WriteLine($"Автор: {name}, Год рождения: {birthYear}"); }
}
class Book
{
    string title;
    int year;
    Author author; // композиция: книга содержит объект автора
    public Book(string title, int year, Author author) { this.title = title; this.year = year; this.author = author; }
    public void PrintInfo()
    {
        Console.WriteLine($"Книга: \"{title}\", Год выпуска: {year}");
        author.PrintInfo(); // вызываем метод вывода автора
    }
}
class P
{
    static void Main()
    {
        try
        {
            Author a1 = new Author("Пушкин", 1799); // создаём первого автора
            Author a2 = new Author("Толстой", 1828); // создаём второго автора
            Book b1 = new Book("Евгений Онегин", 1833, a1); // создаём первую книгу
            Book b2 = new Book("Война и мир", 1869, a2); // создаём вторую книгу
            Console.WriteLine("Список книг:");
            b1.PrintInfo(); // выводим первую книгу
            Console.WriteLine();
            b2.PrintInfo(); // выводим вторую книгу
        }
        catch
        {
            Console.WriteLine("Ошибка!");
        }
    }
}